import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ProjectComponent } from '../app/project/project.component';
import { TaskAddComponent } from '../app/task-add/task-add.component';
import { UserComponent } from '../app/user/user.component';
import { TaskViewComponent } from '../app/task-view/task-view.component';


import { TagContentType } from '@angular/compiler';

const routes: Routes = [


  { path : "project" , component :  ProjectComponent},
  { path : "user", component: UserComponent},
  { path : "taskAdd" , component : TaskAddComponent},
  { path : "taskAdd/:id", component : TaskAddComponent},
  { path : "taskView", component : TaskViewComponent},

];

@NgModule({
  imports: [RouterModule, RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
