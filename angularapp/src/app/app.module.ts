import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { NavComponent } from './user/nav/nav.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { ViewacademyComponent } from './user/viewacademy/viewacademy.component';



import { AddacademyComponent } from './admin/addacademy/addacademy.component';



import { AdminacademyComponent } from './admin/admin-academy/adminacademy.component';


import { NavAdminComponent } from './admin/nav-admin/nav-admin.component';
import{CommonModule} from '@angular/common'





@NgModule({
  declarations: [
    AppComponent,
  
    NavComponent,
    ViewacademyComponent,
 


    AddacademyComponent,
   

    AdminacademyComponent,

    NavAdminComponent
    
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    RouterModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,

    CommonModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
