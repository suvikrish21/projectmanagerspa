import { Component, OnInit } from '@angular/core';
import { ProjmgrapiService } from '../projmgrapi.service';
import { DatePipe } from '@angular/common';
import { TaskData } from '../taskdatamodel';
import { AppSettings } from '../app_settings';
import { ProjectData } from '../projdatamodel';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-task-add',
  templateUrl: './task-add.component.html',
  styleUrls: ['./task-add.component.css']
})
export class TaskAddComponent implements OnInit {



  public tsk = new TaskData();
  public action = "Add";
  public usrList;
  public projList;
  public parentTaskList;
  public errorDt = false;
  public statusMessage : string;
  public usrSrchText;
  public projSrchText;
  public pTaskSrchText;
  public owr;
  public parenttsk;
  public projtsk;


  constructor(private projmgrservice: ProjmgrapiService,
    private datepipe: DatePipe,
    private activatedRoute: ActivatedRoute
  ) { }

  ngOnInit() {

    this.getProjects();
    this.getParentTasks();
    this.getUsers();


    let params: any = this.activatedRoute.snapshot.params;


    if (params.id > 0)
      this.editTask(params.id);
    else
       this.setTaskDates();


  }

  setTaskDates() {

      var todayDt = Date.now();
      this.tsk.start_dt = this.datepipe.transform(todayDt, "yyyy-MM-dd");
      this.tsk.end_dt = this.datepipe.transform((todayDt + 86400 * 1000), "yyyy-MM-dd");
    
  }

  compareDates() {

    this.errorDt = (new Date(this.tsk.start_dt).getTime()) >= 
    (new Date(this.tsk.end_dt).getTime());

  }

  resetTask() {

    this.tsk = new TaskData();
    this.statusMessage = null;
    this.action = "Add";
    this.setTaskDates();

  }

  editTask(taskid: number) {

    this.statusMessage = null;

    const url = AppSettings.ProjectAPIEndPoint + "/tasks/";


    this.projmgrservice.get(url + taskid).subscribe(
      res => {
        //console.log(res);

        this.tsk =
          {
            project: res.project,
            start_dt: res.start_dt == null ? null : this.datepipe.transform(new Date(res.start_dt), 'yyyy-MM-dd'),
            end_dt: res.end_dt == null ? null : this.datepipe.transform(new Date(res.end_dt), 'yyyy-MM-dd'),
            priority: res.priority == null ? 0 : res.priority,
            is_parent_task: false,
            parent_task: res.parent_task,
            owner: res.users == null ? null : res.users[0],
            task_name: res.task1,
            task_id: res.task_id
          };

        this.action = "Update";
      }
    )

  }



  getProjects() {


    const url = AppSettings.ProjectAPIEndPoint + "/projects/summary/";

    this.projmgrservice.get(url).subscribe(
      res => {
        //console.log(res);
        this.projList = res;
      }
    )
  }


  getParentTasks() {

    const url = AppSettings.ProjectAPIEndPoint + "/ptasks/";

    this.projmgrservice.get(url).subscribe(
      res => {
        //console.log(res);
        this.parentTaskList = res;
      }
    )
  }

  getUsers() {

    const url = AppSettings.ProjectAPIEndPoint + "/users/summary/";


    this.projmgrservice.get(url).subscribe(
      res => {
        //console.log(res);
        this.usrList = res;
      }
    )
  }

  addTask(isValid: boolean) {

    if (!isValid)
      return;

    if (this.errorDt)
         return;

    var newtsk;
    var url;

    if (this.action == "Update") {
      newtsk = {
        "parent_id": this.tsk.parent_task == null ? null : this.tsk.parent_task.parent_id,
        "project_id": this.tsk.project == null ? null : this.tsk.project.project_id,
        "task1": this.tsk.task_name,
        "start_dt": this.tsk.start_dt,
        "end_dt": this.tsk.end_dt,
        "priority": this.tsk.priority,
        "status": "NEW",
        "task_id": this.tsk.task_id,
        "users": this.tsk.owner == null ? null : [{
          "user_id": this.tsk.owner.user_id,
        }]
      };

      url = AppSettings.ProjectAPIEndPoint + "/tasks/";

      this.projmgrservice.put(url, newtsk.task_id, newtsk).subscribe(
        res => {
          //console.log(res);
          
          this.statusMessage ="Task Updated";

          this.getProjects();
        }
      );
    }


    if (this.action == "Add") {




      if (this.tsk.is_parent_task) {

        newtsk = { "parent_task1": this.tsk.task_name };

        url = AppSettings.ProjectAPIEndPoint + "/ptasks/";
      }
      else {
        newtsk = {
          "parent_id": this.tsk.parent_task == null ? null : this.tsk.parent_task.parent_id,
          "project_id": this.tsk.project == null ? null : this.tsk.project.project_id,
          "task1": this.tsk.task_name,
          "start_dt": this.tsk.start_dt,
          "end_dt": this.tsk.end_dt,
          "priority": this.tsk.priority,
          "status": "NEW",
          "users": this.tsk.owner == null ? null : [{
            "user_id": this.tsk.owner.user_id

          }]


        };

        url = AppSettings.ProjectAPIEndPoint + "/tasks/";
      }

      this.projmgrservice.post(url, newtsk).subscribe(
        res => {
          //console.log(res);
          this.statusMessage ="Task Added";

          this.getParentTasks();

        } ,
        
        error => {
        //console.log(error);
        this.statusMessage =  "Unable to process the task request";
      }
      );



    }




  }

}
