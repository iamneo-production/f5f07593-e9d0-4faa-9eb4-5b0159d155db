  import { HttpClient } from '@angular/common/http';
  import { Injectable } from '@angular/core';
  import { Observable } from 'rxjs';
import { AddcourseComponent, CourseModel } from '../admin/addcourse/addcourse.component';
  
  const URL: any = 'https://8080-abefcabadffbcdcdfefcdccaedfebaefadfa.project.examly.io/api/Admin/addCourse';
  
  @Injectable({
    providedIn: 'root',
  })
  export class AddcourseService {
    constructor(private http: HttpClient) {}
  
    Create(data: CourseModel): Observable<any> {
      return this.http.post<CourseModel>(URL, data);
    }
  }
  
  