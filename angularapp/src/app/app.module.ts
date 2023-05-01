import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { AddadmissionComponent } from './user/addadmission/addadmission.component';
import { AdminStudentComponent } from './admin/admin-student/admin-student.component';
//import { ToastrModule } from 'ngx-toastr';
import { NavAdminComponent } from './admin/nav-admin/nav-admin.component';
import{CommonModule} from '@angular/common'





@NgModule({
  declarations: [
    AppComponent,
    AddadmissionComponent,
    AdminStudentComponent,
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
   // ToastrModule,
    CommonModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
