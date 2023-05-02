import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { AdminStudentService } from 'src/app/services/admin-student.service';
//import { StudentModel } from 'src/app/user/addadmission/addadmission.component';
import{Location} from '@angular/common';

@Component({
  selector: 'app-admin-student',
  templateUrl: './admin-student.component.html',
  styleUrls: ['./admin-student.component.css']
})
export class AdminStudentComponent implements OnInit {
  public studentList: any;
  constructor(private api: AdminStudentService,
    private location:Location) { }
  
  ngOnInit(): void {
    this.api.getStudents().subscribe(res => {
        this.studentList = res;
       
      });  
  }

  deleteRecord(id:number){
    window.location.reload();
    console.log(id);
  this.api.deleteRecord(id).subscribe((result)=>{
    console.warn(result);
  });
}
// edit(){
//   let edit{
//     ""
//   }
// }

}