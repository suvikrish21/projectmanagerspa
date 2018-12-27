import { Component, OnInit } from '@angular/core';
import { ProjmgrapiService } from '../projmgrapi.service';
import { DatePipe } from '@angular/common';
import { Router } from '@angular/router';

import { TaskData } from '../taskdatamodel';
import { AppSettings } from '../app_settings';

@Component({
  selector: 'app-task-view',
  templateUrl: './task-view.component.html',
  styleUrls: ['./task-view.component.css']
})
export class TaskViewComponent implements OnInit {

 
  public tskSortText = "task1";
  public tskvw = new TaskData();
  public projList;
  public projTskList;
  public statusMessage : string;
  public projSrchText;
  public projtask;

  constructor(private projmgrservice: ProjmgrapiService,
    private router: Router,
    private datepipe: DatePipe) { }


  ngOnInit() {

 
    this.getProjects();
  }


  editTask(tskid: number) {

  
    this.router.navigate(['./taskAdd/' + tskid]);

  }



  getProjects() {


    const url = AppSettings.ProjectAPIEndPoint + "/projects/";

    this.projmgrservice.get(url).subscribe(
      res => {
        //console.log(res);
        this.projList = res;
      }
    )
  }

  endTask(tsk: any) {

   
    const url = AppSettings.ProjectAPIEndPoint + "/tasks/";

    tsk.status = "COMPLETE";
    this.projmgrservice.put(url, tsk.task_id, tsk).subscribe(
      res => {
        //console.log(res);

        this.statusMessage = "Task Completed at "+ this.datepipe.transform(Date.now(), "dd-MMM-yyyy h:mm:ss a");
  
        this.getTasks(this.tskvw.project.project_id);
      }
    )

  }

  sortTaskBy(sortByValue) {

    this.statusMessage = null;
    this.tskSortText = sortByValue;
  }


  getProjectTask(project: any) {

    this.getTasks(project.project_id);

    this.tskvw.project = project;

    

  }

  getTasks(projectId : number) {

    const url = AppSettings.ProjectAPIEndPoint + "/tasks/?projid=" + projectId;


    this.projmgrservice.get(url).subscribe(
      res => {
        //console.log(res);
        this.projTskList = res;
      }
    )
  }

}
