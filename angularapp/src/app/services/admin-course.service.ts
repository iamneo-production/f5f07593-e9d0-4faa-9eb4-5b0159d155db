import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})

export class AdminCourseService {
  private Url = 'https://8080-abefcabadffbcdcdfefcdccaedfebaefadfa.project.examly.io/api/Admin/ViewCourse';
  private Url1 ='https://8080-abefcabadffbcdcdfefcdccaedfebaefadfa.project.examly.io/api/Admin/deleteCourse?id'
constructor(private http : HttpClient) { }
getCourse()
{
return this.http.get<any>('https://8080-abefcabadffbcdcdfefcdccaedfebaefadfa.project.examly.io/api/Admin/ViewCourse')
  .pipe(map((res:any)=>{
  return res;
  }))

  }
  GetId(id: number){
    return this.http.get(`${this.Url}=${id}`);
  }
  deleteRecord(id: number){
    return this.http.delete(`${this.Url1}=${id}`);
  }
  }