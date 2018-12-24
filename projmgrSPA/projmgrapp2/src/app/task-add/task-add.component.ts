import { Component, OnInit } from '@angular/core';
import { ProjmgrapiService } from '../projmgrapi.service';
import { DatePipe } from '@angular/common';
import { TaskData } from '../taskdatamodel';
import { AppSettings } from 'src/app/app_settings';
import { ProjectData } from 'src/app/projdatamodel';
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


  }

  compareDates() {

    this.errorDt = (new Date(this.tsk.start_dt).getTime()) >= 
    (new Date(this.tsk.end_dt).getTime());

  }

  editTask(taskid: number) {


    const url = AppSettings.ProjectAPIEndPoint + "/tasks/";


    this.projmgrservice.get(url + taskid).subscribe(
      res => {
        console.log(res);

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


    const url = AppSettings.ProjectAPIEndPoint + "/projects/";

    this.projmgrservice.get(url).subscribe(
      res => {
        console.log(res);
        this.projList = res;
      }
    )
  }


  getParentTasks() {

    const url = AppSettings.ProjectAPIEndPoint + "/ptasks/";

    this.projmgrservice.get(url).subscribe(
      res => {
        console.log(res);
        this.parentTaskList = res;
      }
    )
  }

  getUsers() {

    const url = AppSettings.ProjectAPIEndPoint + "/users/";


    this.projmgrservice.get(url).subscribe(
      res => {
        console.log(res);
        this.usrList = res;
      }
    )
  }

  addTask(isValid: boolean) {

    if (!isValid)
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
          console.log(res);


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
          console.log(res);


        }
      );



    }




  }

}
