import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';



import { AddadmissionComponent } from './user/addadmission/addadmission.component';


import { AdminStudentComponent } from './admin/admin-student/admin-student.component';



import { NavAdminComponent } from './admin/nav-admin/nav-admin.component';


const routes: Routes = [
  {path:'',redirectTo: '/home',pathMatch:'full'},
  {
   // path:'user/addadmission/{{course.courseId}}',
   path:'home',
    component:AddadmissionComponent
  },
   {
    path:'admin/Student',
    component:AdminStudentComponent
  },
  {
    path:'navbar',
    component:NavAdminComponent
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
