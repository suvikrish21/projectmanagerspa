import { Component, OnInit } from '@angular/core';
import { ProjmgrapiService } from '../projmgrapi.service';
import  {DatePipe} from '@angular/common';
import {TaskData} from '../taskdatamodel';
import { AppSettings } from 'src/app/app_settings';
import { ProjectData } from 'src/app/projdatamodel';

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


  constructor(private projmgrservice : ProjmgrapiService, private datepipe: DatePipe) { }

  ngOnInit() {

    this.getProjects();
    this.getParentTasks();
    this.getUsers();
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

  addTask() {


    if (this.action =="Add")
    {


   var newtsk;
   var url;

   if (this.tsk.is_parent_task) {
   
   newtsk = {"parent_task1":  this.tsk.task_name};
  
    url = AppSettings.ProjectAPIEndPoint + "/ptasks/";
   }
   else  {
    newtsk = {"parent_id":  this.tsk.parent_task == null ? null: this.tsk.parent_task.parent_id,
              "project_id" : this.tsk.project == null ? null:this.tsk.project.project_id,
              "task1" : this.tsk.task_name,
              "start_dt" : this.tsk.start_dt,
              "end_dt" : this.tsk.end_dt,
              "priority" : this.tsk.priority,
              "status" : "NEW",
              "users" : [{ 
                "user_id" : this.tsk.owner.user_id 
               
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
