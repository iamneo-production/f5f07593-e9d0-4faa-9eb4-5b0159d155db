import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SignupComponent } from './Auth/signup/signup.component';
import { LoginComponent } from './Auth/login/login.component';
import { NavComponent } from './user/nav/nav.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { ViewacademyComponent } from './user/viewacademy/viewacademy.component';
import { AddadmissionComponent } from './user/addadmission/addadmission.component';
import { AddcourseComponent } from './admin/addcourse/addcourse.component';
import { ViewcourseComponent } from './user/viewcourse/viewcourse.component';
import { AddacademyComponent } from './admin/addacademy/addacademy.component';
// import { editcourseComponent } from './admin/editcourse/editcourse.component';
import { AdminStudentComponent } from './admin/admin-student/admin-student.component';
import { AdminacademyComponent } from './admin/admin-academy/adminacademy.component';
import { admincourseComponent } from './admin/admin-course/admin-course.component';
import { NavAdminComponent } from './admin/nav-admin/nav-admin.component';
import{CommonModule} from '@angular/common'





@NgModule({
  declarations: [
    AppComponent,
    SignupComponent,
    LoginComponent,
    NavComponent,
    ViewacademyComponent,
    AddadmissionComponent,
    AddcourseComponent,
    ViewcourseComponent,
    AddacademyComponent,
    // editcourseComponent,
    AdminStudentComponent,

    AdminacademyComponent,
    admincourseComponent,
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
