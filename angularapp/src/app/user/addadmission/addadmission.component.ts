import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, NgForm } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { AddadmissionService } from 'src/app/services/addadmission.service';


export class StudentModel {
  studentName!: string;
  studentDOB!: Date;
  address!: string;
  mobile!: string;
  sslc!: number;
  hsc!: number;
  diploma!: number;
  eligibility!: string;
  courseId!:number;
}

@Component({
  selector: 'app-addadmission',
  templateUrl: './addadmission.component.html',
  styleUrls: ['./addadmission.component.css'],
})
export class AddadmissionComponent implements OnInit {
  admissionform!: FormGroup;
  studentName!: any;
  studentDOB!: any;
  address!: any;
  mobile!: any;
  sslc!: any;
  hsc!: any;
  diploma!: any;
  eligibility!: any;
  courseId!:any;
  constructor(
    private formBuilder: FormBuilder,
    public addAdmission: AddadmissionService
  ) { }

  ngOnInit(): void {
    this.admissionform = this.formBuilder.group({
      studentName:[''], 
      studentDOB:[''],       
      address: [''],
      mobile:[''], 
      sslc:[''], 
      hsc:[''], 
      diploma:[''], 
      eligibility:[''], 
      courseId:[''],
    });
   
  }

  onSubmit(): void {

    if (this.admissionform.valid) {
      this.addAdmission.Create(this.admissionform.value).subscribe((res) => {
        console.log(res);
        alert('Form submitted');
      });

      this.admissionform.reset();
    } else {
      alert('Form should not be null');
    }
  }
  // onRecordClicked(id: string) {
  //   this.selectedCourseId = id;
  //   }
}



