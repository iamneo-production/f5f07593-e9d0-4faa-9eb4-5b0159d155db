import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { ViewcourseService } from 'src/app/services/viewcourse.service';

@Component({
  selector: 'app-viewcourse',
  templateUrl: './viewcourse.component.html',
  styleUrls: ['./viewcourse.component.css']
})
export class ViewcourseComponent implements OnInit {
  public courseList: any;
 // @Output() recordClicked = new EventEmitter<string>();
  constructor(private api: ViewcourseService) { }
  
  ngOnInit(): void {
    this.api.getCourse().subscribe(res => {
        this.courseList = res;
      });  
  }
//   onRecordClick(courseList: any) {
//     const recordId = courseList.id;
//     this.recordClicked.emit(recordId);
// }
}
