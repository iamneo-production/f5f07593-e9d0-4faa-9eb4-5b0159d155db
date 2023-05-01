import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ViewacademyComponent } from './user/viewacademy/viewacademy.component';
import { SignupComponent } from './Auth/signup/signup.component';
import { ViewcourseComponent } from './user/viewcourse/viewcourse.component';
import { AddadmissionComponent } from './user/addadmission/addadmission.component';
import { LoginComponent } from './Auth/login/login.component';
import { AddacademyComponent } from './admin/addacademy/addacademy.component';
import { AdminStudentComponent } from './admin/admin-student/admin-student.component';
import { AddcourseComponent } from './admin/addcourse/addcourse.component';
import { AdminacademyComponent } from './admin/admin-academy/adminacademy.component';
import { admincourseComponent } from './admin/admin-course/admin-course.component';
import { NavAdminComponent } from './admin/nav-admin/nav-admin.component';
import { NavComponent } from './user/nav/nav.component';

const routes: Routes = [
  {path:'',redirectTo: '/home',pathMatch:'full'},
  {
path:'home',
component:LoginComponent
  },
  {path:'user/viewInstitute',
  component:ViewacademyComponent
  },
  
  {
   // path:'user/viewCourse/:id',
   path:'user/viewCourse',
    component:ViewcourseComponent
  },
  {
    path:'signup',
    component:SignupComponent
  },
  {
   // path:'user/addadmission/{{course.courseId}}',
   path:'user/addadmission',
    component:AddadmissionComponent
  },
  {
    path:'login',
    component:LoginComponent
  },
  {
    path:'admin/Student',
    component:AdminStudentComponent
  }
  ,
  {
    path:'admin/Student/add',
    component:AddacademyComponent
  },
  {
  path:'admin/Institute',
  component:AdminacademyComponent
  }
  ,
  {
    path:'admin/Institute/add',
    component:AddacademyComponent
  },
  {
    path:'admin/Course',
    component:admincourseComponent
    },
  {
    path:'admin/Course/add',
    component:AddcourseComponent
  },
  {
    path:'navbar',
    component:NavAdminComponent
  },
  {
    path:'nav',
    component:NavComponent
  }



];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
