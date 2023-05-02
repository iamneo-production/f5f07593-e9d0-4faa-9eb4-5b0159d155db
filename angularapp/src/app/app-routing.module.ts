import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';


import { AdminStudentComponent } from './admin/admin-student/admin-student.component';

import { NavComponent } from './user/nav/nav.component';
import { NavAdminComponent } from './admin/nav-admin/nav-admin.component';

const routes: Routes = [
  {path:'',redirectTo: '/home',pathMatch:'full'},
  {
path:'home',
component:NavAdminComponent
  },
 // {path:'user/viewInstitute',
  //component:ViewacademyComponent
  //},
  
  //{
   // path:'user/viewCourse/:id',
  // path:'user/viewCourse',  
   // component:ViewcourseComponent
 // },
 // {
   // path:'signup',
   // component:SignupComponent
 // },
  //{
   // path:'user/addadmission/{{course.courseId}}',
  //path:'user/addadmission',
   // component:AddadmissionComponent
  //},
  //{
   // path:'login',
   // component:LoginComponent
 // },
  {
    path:'admin/Student',
    component:AdminStudentComponent
  },
  
  
  //{
  //path:'admin/Institute',
  //component:AdminacademyComponent
  //}
  
 // {
   // path:'admin/Institute/add',
   // component:AddacademyComponent
 // },
 // {
   // path:'admin/Course',
   // component:admincourseComponent
    //},
 // {
   // path:'admin/Course/add',
   // component:AddcourseComponent
 // },
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
