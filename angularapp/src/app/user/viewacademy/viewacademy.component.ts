import { Component, OnInit } from '@angular/core';
import { academyModel } from 'src/app/admin/addacademy/addacademy.component';
import { ViewacademyService } from 'src/app/services/viewacademy.service';

@Component({
  selector: 'app-viewacademy',
  templateUrl: './viewacademy.component.html',
  styleUrls: ['./viewacademy.component.css']
})
export class ViewacademyComponent implements OnInit {
// searchdata!:string;
// InstituteName!:string;
// InstituteAdress!:string;
// filteracademy!:any;
  public academyList: any;
  constructor(private api: ViewacademyService) { }
  
  ngOnInit(): void {
    this.api.getAcademy().subscribe(res => {
        this.academyList = res;
      });  
  }

  onacedemyClick(academyList:any){
    const insid=academyList.instituteId;
    console.log(insid);
  }

  // search() {

  //       // Implement the logic to filter jobs based on the search location
    
  //       this.filteracademy = this.academyList.filter(search => search.InstituteName.toLowerCase().includes(this.searchdata.toLocaleLowerCase()));
    
  //     }
}





