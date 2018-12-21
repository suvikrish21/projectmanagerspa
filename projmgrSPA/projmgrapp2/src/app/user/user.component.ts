import { Component, OnInit } from '@angular/core';
import { ProjmgrapiService } from '../projmgrapi.service';
import { UserData } from '../usrdatamodel';
import { AppSettings } from 'src/app/app_settings';


@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

   public userList; 
   public user = new UserData(); 
   public action = "Add";

  constructor(private projmgrservice : ProjmgrapiService) { 
      this.getUsers();
  }

  ngOnInit() {
  }


   resetUser() {

    this.user = new UserData();
    this.action = "Add";

   }

  deleteUser(userid : number) {

    const url = AppSettings.ProjectAPIEndPoint + "/users/";
  
    this.projmgrservice.delete(url, userid).subscribe(
      res => {
        console.log(res);
        
        this.getUsers();
      }
   )
  }


  editUser(userid : number) {

    const url = AppSettings.ProjectAPIEndPoint + "/users/";
  
    this.projmgrservice.get(url + userid).subscribe(
      res => {
        console.log(res);
        this.user = 

        {
        employee_id : res.emp_id ,
        first_name : res.first_name, 
        last_name : res.last_name, 
        user_id : res.user_id
        };

        this.action = "Update";
      }
   )

  }

  addUser() {

    const url = AppSettings.ProjectAPIEndPoint + "/users/";
  
   

    if (this.action == "Add")  {

      var newUser = {
        "first_name" : this.user.first_name,
        "last_name" : this.user.last_name, 
        "emp_id" : this.user.employee_id, 
       
       };


    this.projmgrservice.post(url, newUser).subscribe(
      res => {
        console.log(res);


        this.getUsers();
      }
    );
  } 
  if (this.action == "Update") {

    var editUser = {
      "first_name" : this.user.first_name,
      "last_name" : this.user.last_name, 
      "emp_id" : this.user.employee_id, 
      "user_id" : this.user.user_id
     };

    this.projmgrservice.put(url, editUser.user_id, editUser).subscribe(
      res => {
        console.log(res);


        this.getUsers();
      }
    );


  }

    
  }

  getUsers() {
   
    const url = AppSettings.ProjectAPIEndPoint + "/users/";
  

    this.projmgrservice.get(url).subscribe(
       res => {
         console.log(res);
         this.userList = res;
       }
    )
  }

}