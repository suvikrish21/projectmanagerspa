import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import  {HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MenuComponent } from './menu/menu.component';
import { ProjectComponent } from './project/project.component';
import { UserComponent } from './user/user.component';
import { TaskAddComponent } from './task-add/task-add.component';
import { TaskViewComponent } from './task-view/task-view.component';

import { ProjmgrapiService } from './projmgrapi.service';
import { DatePipe } from '@angular/common';
import { ProjmodalComponent } from './projmodal/projmodal.component';
import { UserFilterPipe } from 'src/app/user/userfilter';

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    ProjectComponent,
    UserComponent,
    TaskAddComponent,
    TaskViewComponent,
    ProjmodalComponent,
    UserFilterPipe
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    HttpModule
  ],
  providers: [ProjmgrapiService, DatePipe],
  bootstrap: [AppComponent]
})
export class AppModule { }
