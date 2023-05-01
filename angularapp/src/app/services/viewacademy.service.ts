import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ViewacademyService {
constructor(private http : HttpClient) { }
getAcademy()
{
return this.http.get<any>('https://localhost:7194/api/Admin/viewInstitute')
  .pipe(map((res:any)=>{
  return res;
  }))
  }
  }