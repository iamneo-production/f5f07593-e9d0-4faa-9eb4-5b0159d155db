import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AddadmissionComponent } from '../user/addadmission/addadmission.component';
import { StudentModel } from '../user/addadmission/addadmission.component';

const URL: any = 'https://localhost:44398/api/admin/Addstudent';

@Injectable({
  providedIn: 'root',
})
export class AddadmissionService {
  //private Url = 'https://localhost:44398/api/admin/Addstudent';

  constructor(private http: HttpClient) {}

  Create(data: StudentModel): Observable<any> {
    return this.http.post<StudentModel>(URL, data);
  }
  
}

