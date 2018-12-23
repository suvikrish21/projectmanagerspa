import { Component, OnInit } from '@angular/core';
import { ProjmgrapiService } from '../projmgrapi.service';
import  {DatePipe} from '@angular/common';

import { ProjectData } from '../projdatamodel';
import { AppSettings } from 'src/app/app_settings';

@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.css']
})
export class ProjectComponent implements OnInit {


  public projList; 
  
  public proj = new ProjectData();
  public action = "Add";
  public usrList;

  public projSortText = "project1";

  constructor(private projmgrservice : ProjmgrapiService, private datepipe: DatePipe) { }

  ngOnInit() {
  
    this.getProjects();
    this.getUsers();
    
  }

  
  sortProjectBy(sortByValue) {


      this.projSortText = sortByValue;
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

  editProject(projectid : number) {

     
    const url = AppSettings.ProjectAPIEndPoint + "/projects/";
   

    this.projmgrservice.get(url + projectid).subscribe(
      res => {
        console.log(res);
      
        this.proj = 
        {
        project_name: res.project1,
        start_dt : res.start_dt == null ? null :   this.datepipe.transform(new Date(res.start_dt), 'yyyy-MM-dd'), 
        end_dt : res.end_dt == null ? null :  this.datepipe.transform(new Date(res.end_dt),  'yyyy-MM-dd'), 
        priority : res.priority == null? 0 : res.priority,
       
        project_id : res.project_id,
        manager  : res.users == null ? null :res.users[0]
        
        };

        this.action = "Update";
      }
   )

  }




  addProject(isValid : boolean) {

    if (isValid) {

   
    const url = AppSettings.ProjectAPIEndPoint + "/projects/";
  

     if (this.action =="Add")
     {
    var newProj = {"project1":  this.proj.project_name,
                   "start_dt": this.proj.start_dt,
                   "end_dt": this.proj.end_dt,
                   "priority": this.proj.priority,
                    "users" : [{ 
                      "user_id" : this.proj.manager.user_id 
                     
                          }]

                   };
   

    this.projmgrservice.post(url, newProj).subscribe(
      res => {
        console.log(res);

        this.getProjects();
      }
    );


    
  }
  if (this.action == "Update") {

    var editProj = 
    {"project1":  this.proj.project_name,
    "start_dt": this.proj.start_dt,
    "end_dt": this.proj.end_dt,
    "priority": this.proj.priority,
    "project_id": this.proj.project_id,
    "users" : [{ 
      "user_id" : this.proj.manager.user_id 
     
          }]

    };

    this.projmgrservice.put(url, editProj.project_id, editProj).subscribe(
      res => {
        console.log(res);


        this.getProjects();
      }
    );


  }
}
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
}
