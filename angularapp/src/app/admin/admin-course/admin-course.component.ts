import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { AdminCourseService } from 'src/app/services/admin-course.service';
import { ViewcourseService } from 'src/app/services/viewcourse.service';

@Component({
  selector: 'app-viewcourse',
  templateUrl: './admin-course.component.html',
  styleUrls: ['./admin-course.component.css']
})
export class admincourseComponent implements OnInit {
  public courseList: any;
 // @Output() recordClicked = new EventEmitter<string>();
  constructor(private api: AdminCourseService) { }
  
  ngOnInit(): void {
    this.api.getCourse().subscribe(res => {
        this.courseList = res;
      });  
  }
  deleteRecord(id:number){
    window.location.reload();
    console.log(id);
  this.api.deleteRecord(id).subscribe((result)=>{
    console.warn(result);
  });
}
//   onRecordClick(courseList: any) {
//     const recordId = courseList.id;
//     this.recordClicked.emit(recordId);
// }
}
