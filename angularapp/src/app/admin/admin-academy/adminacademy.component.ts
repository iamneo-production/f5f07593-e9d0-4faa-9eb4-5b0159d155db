import { Component, OnInit } from '@angular/core';
import { academyModel } from 'src/app/admin/addacademy/addacademy.component';
import { AdminacademyService } from '../../services/admin-academy.service';
@Component({
  selector: 'app-adminacademy',
  templateUrl: './adminacademy.component.html',
  styleUrls: ['./adminacademy.component.css']
})
export class AdminacademyComponent implements OnInit {
// searchdata!:string;
// InstituteName!:string;
// InstituteAdress!:string;
// filteracademy!:any;
  public academyList: any;
  constructor(private api: AdminacademyService) { }
  
  ngOnInit(): void {
    this.api.getAcademy().subscribe(res => {
        this.academyList = res;
      }); 
    }
      deleteRecord(id:number){
       window.location.reload();
        console.log(id);
      this.api.deleteRecord(id).subscribe((result)=>{
        console.warn(result);
      });
  }
  


  // search() {

  //       // Implement the logic to filter jobs based on the search location
    
  //       this.filteracademy = this.academyList.filter(search => search.InstituteName.toLowerCase().includes(this.searchdata.toLocaleLowerCase()));
    
  //     }
}





