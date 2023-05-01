import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { RegisterModel } from '../Auth/signup/signup.component';

const URL: any = 'https://localhost:44398/api/Auth/Register';

@Injectable({
  providedIn: 'root',
})
export class RegisterService {
  constructor(private http: HttpClient) {}

  Create(data: RegisterModel): Observable<any> {
    return this.http.post<RegisterModel>(URL, data);
  }
}
