import { Component, OnInit } from '@angular/core';
import { ProjmgrapiService } from '../projmgrapi.service';
import { UserData } from '../usrdatamodel';
import { AppSettings } from '../app_settings';


@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  public userList;
  public user = new UserData();
  public action = "Add";

  public sortText = "first_name";
  public statusMessage : string;

  constructor(private projmgrservice: ProjmgrapiService) {
    this.getUsers();
  }

  ngOnInit() {
  }

  sortUserBy(sortByValue) {

    this.statusMessage = null;
    this.sortText = sortByValue;
  }

  resetUser() {

    this.user = new UserData();
    this.statusMessage = null;
    this.action = "Add";

  }

  deleteUser(userid: number) {

    const url = AppSettings.ProjectAPIEndPoint + "/users/";

    this.projmgrservice.delete(url, userid).subscribe(
      res => {
        //console.log(res);
        this.statusMessage = " User Deleted";
          

        this.getUsers();
      }
    )
  }


  editUser(userid: number) {

    this.statusMessage = null;
    const url = AppSettings.ProjectAPIEndPoint + "/users/";

    this.projmgrservice.get(url + userid).subscribe(
      res => {
        //console.log(res);
        this.user =

          {
            employee_id: res.emp_id,
            first_name: res.first_name,
            last_name: res.last_name,
            user_id: res.user_id
          };

        this.action = "Update";
      }
    )

  }

  addUser(isValid: boolean) {

    if (isValid) {

      const url = AppSettings.ProjectAPIEndPoint + "/users/";



      if (this.action == "Add") {

        var newUser = {
          "first_name": this.user.first_name,
          "last_name": this.user.last_name,
          "emp_id": this.user.employee_id,

        };


        this.projmgrservice.post(url, newUser).subscribe(
          res => {
            //console.log(res);

            this.statusMessage = " User Added";
            

            this.getUsers();
          } ,
        
        error => {
        //console.log(error);
        this.statusMessage =  "Unable to process the user request";
      }
        );
      }
      if (this.action == "Update") {

        var editUser = {
          "first_name": this.user.first_name,
          "last_name": this.user.last_name,
          "emp_id": this.user.employee_id,
          "user_id": this.user.user_id
        };

        this.projmgrservice.put(url, editUser.user_id, editUser).subscribe(
          res => {
            //console.log(res);
            this.statusMessage = " User Updated";
          

            this.getUsers();
          }
        );

      }


    }


  }

  getUsers() {

    const url = AppSettings.ProjectAPIEndPoint + "/users/summary/";


    this.projmgrservice.get(url).subscribe(
      res => {
        //console.log(res);
        this.userList = res;
      } ,
      error => {
        //console.log(error);
        this.statusMessage =  "Unable to fetch the users";
      }
    )
  }

}
