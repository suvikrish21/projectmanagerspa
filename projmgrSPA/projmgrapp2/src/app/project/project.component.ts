import { Component, OnInit } from '@angular/core';
import { ProjmgrapiService } from '../projmgrapi.service';
import { DatePipe } from '@angular/common';

import { ProjectData } from '../projdatamodel';
import { AppSettings } from '../app_settings';

@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.css']
})
export class ProjectComponent implements OnInit {


  public projList;
  public usrSrchText;
  public proj = new ProjectData();
  public action = "Add";
  public usrList;
  public errorDt = false;
  public projSortText = "project1";
  public statusMessage : string;

  constructor(private projmgrservice: ProjmgrapiService, private datepipe: DatePipe) { }

  ngOnInit() {

    this.getProjects();
    this.getUsers();

  }


  sortProjectBy(sortByValue) {

    this.statusMessage = null;
    this.projSortText = sortByValue;
  }


  compareDates() {

    this.errorDt = (new Date(this.proj.start_dt).getTime()) >= 
    (new Date(this.proj.end_dt).getTime());

  }

  setProjectDates(e: Event) {

    var chkbox = e.target as HTMLInputElement;
    //console.log("set project dates " + chkbox.checked);



    if (chkbox.checked) {
      var todayDt = Date.now();
      this.proj.start_dt = this.datepipe.transform(todayDt, "yyyy-MM-dd");
      this.proj.end_dt = this.datepipe.transform((todayDt + 86400 * 1000), "yyyy-MM-dd");
    }
    else {
      this.proj.start_dt = null;
      this.proj.end_dt = null;
    }

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

  editProject(projectid: number) {

    this.statusMessage = null;

    const url = AppSettings.ProjectAPIEndPoint + "/projects/";


    this.projmgrservice.get(url + projectid).subscribe(
      res => {
        //console.log(res);

        this.proj =
          {
            project_name: res.project1,
            start_dt: res.start_dt == null ? null : this.datepipe.transform(new Date(res.start_dt), 'yyyy-MM-dd'),
            end_dt: res.end_dt == null ? null : this.datepipe.transform(new Date(res.end_dt), 'yyyy-MM-dd'),
            priority: res.priority == null ? 0 : res.priority,
            is_duration : res.start_dt !== null && res.end_Dt !== null,
            project_id: res.project_id,
            manager: res.users == null ? null : res.users[0]

          };

          //console.log("duration " +this.proj.is_duration);

        this.action = "Update";
      }
    )

  }

  resetProject() {

    this.proj = new ProjectData();
    this.statusMessage = null;
    this.action = "Add";

  }


  addProject(isValid: boolean) {

    if (this.errorDt)
        return;

    if (isValid) {


      const url = AppSettings.ProjectAPIEndPoint + "/projects/";


      if (this.action == "Add") {
        var newProj = {
          "project1": this.proj.project_name,
          "start_dt": this.proj.start_dt,
          "end_dt": this.proj.end_dt,
          "priority": this.proj.priority,
          "users": this.proj.manager == null ? null : [{
            "user_id": this.proj.manager.user_id

          }]

        };


        this.projmgrservice.post(url, newProj).subscribe(
          res => {
            //console.log(res);
            this.statusMessage = "Project Added";

            this.getProjects();
          }
        );



      }
      if (this.action == "Update") {

        var editProj =
          {
            "project1": this.proj.project_name,
            "start_dt": this.proj.start_dt,
            "end_dt": this.proj.end_dt,
            "priority": this.proj.priority,
            "project_id": this.proj.project_id,
            "users": this.proj.manager == null ? null : [{
              "user_id": this.proj.manager.user_id

            }]

          };

        this.projmgrservice.put(url, editProj.project_id, editProj).subscribe(
          res => {
            //console.log(res);

            this.statusMessage = "Project Updated";
            this.getProjects();
          }
        );


      }
    }
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
}
