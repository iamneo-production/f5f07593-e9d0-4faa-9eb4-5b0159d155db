import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ViewacademyComponent } from './user/viewacademy/viewacademy.component';




import { AddacademyComponent } from './admin/addacademy/addacademy.component';


import { AdminacademyComponent } from './admin/admin-academy/adminacademy.component';

import { NavAdminComponent } from './admin/nav-admin/nav-admin.component';
import { NavComponent } from './user/nav/nav.component';

const routes: Routes = [
  {path:'',redirectTo: '/home',pathMatch:'full'},
  
  {path:'home',
  component:NavAdminComponent
  },
  
  
   // path:'user/viewCourse/:id',
   
   // path:'user/addadmission/{{course.courseId}}',
   
  
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
