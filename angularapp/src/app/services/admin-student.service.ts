import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AdminStudentService {
  private apiUrl = 'https://localhost:44398/api/Admin/DeleteStudent?studentId';
  private Url = 'https://localhost:44398/api';

constructor(private http : HttpClient) { }
getStudents()
{
return this.http.get(this.Url+'/Admin/ViewStudent/');
  }
    deleteRecord(id: number){
      return this.http.delete(`${this.apiUrl}=${id}`);
    }
  
    edit(id:number,data:any){
      return this.http.put(this.Url+'/admin/EditStudent'+`/${id}`,data);
      }
      
  }
  
  
  
  
  