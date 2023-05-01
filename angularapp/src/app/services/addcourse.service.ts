  import { HttpClient } from '@angular/common/http';
  import { Injectable } from '@angular/core';
  import { Observable } from 'rxjs';
import { AddcourseComponent, CourseModel } from '../admin/addcourse/addcourse.component';
  
  const URL: any = 'https://localhost:44398/api/Admin/addCourse';
  
  @Injectable({
    providedIn: 'root',
  })
  export class AddcourseService {
    constructor(private http: HttpClient) {}
  
    Create(data: CourseModel): Observable<any> {
      return this.http.post<CourseModel>(URL, data);
    }
  }
  
  