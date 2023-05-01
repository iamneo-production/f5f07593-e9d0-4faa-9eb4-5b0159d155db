import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AddacademyComponent } from '../admin/addacademy/addacademy.component';
import { academyModel } from '../admin/addacademy/addacademy.component';

const URL: any = 'https://localhost:44398/api/Admin/AddInstitute';

@Injectable({
  providedIn: 'root',
})
export class AddacademyService {
  constructor(private http: HttpClient) {}

  Create(data: academyModel): Observable<any> {
    return this.http.post<academyModel>(URL, data);
  }
}

