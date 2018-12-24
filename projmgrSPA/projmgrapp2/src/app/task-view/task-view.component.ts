import { Component, OnInit } from '@angular/core';
import { ProjmgrapiService } from '../projmgrapi.service';
import { DatePipe } from '@angular/common';
import { Router } from '@angular/router';

import { TaskData } from '../taskdatamodel';
import { AppSettings } from 'src/app/app_settings';

@Component({
  selector: 'app-task-view',
  templateUrl: './task-view.component.html',
  styleUrls: ['./task-view.component.css']
})
export class TaskViewComponent implements OnInit {

  public tskList;
  public tskSortText = "task1";
  public tskvw = new TaskData();
  public projList;
  public projTskList;
  public statusMessage : string;

  constructor(private projmgrservice: ProjmgrapiService,
    private router: Router,
    private datepipe: DatePipe) { }


  ngOnInit() {

    this.getTasks();
    this.getProjects();
  }


  editTask(tskid: number) {

  
    this.router.navigate(['./taskAdd/' + tskid]);

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

  endTask(tsk: any) {

   
    const url = AppSettings.ProjectAPIEndPoint + "/tasks/";

    tsk.status = "COMPLETE";
    this.projmgrservice.put(url, tsk.task_id, tsk).subscribe(
      res => {
        //console.log(res);

        this.statusMessage = "Task Completed";
  
        this.getTasks();
      }
    )

  }

  sortTaskBy(sortByValue) {

    this.statusMessage = null;
    this.tskSortText = sortByValue;
  }


  getProjectTask(project: any) {

    this.tskvw.project = project;

    this.projTskList = this.tskList.
      filter((tsk1: any) => tsk1.project.project_id === project.project_id);


  }

  getTasks() {

    const url = AppSettings.ProjectAPIEndPoint + "/tasks/";


    this.projmgrservice.get(url).subscribe(
      res => {
        //console.log(res);
        this.tskList = res;
      }
    )
  }

}
