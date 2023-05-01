import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, NgForm } from '@angular/forms';
import { AddacademyService } from 'src/app/services/addacademy.service';

export class academyModel {
  InstituteName!: string;
  InstituteDescription!: string;
  InstituteAddress!: string;
  Mobile!:string;
  Email!:string;
  ImgUrl!:string;
}

@Component({
  selector: 'app-addacademy',
  templateUrl: './addacademy.component.html',
  styleUrls: ['./addacademy.component.css'],
})
export class AddacademyComponent implements OnInit {
  academyform!: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    public addacademy: AddacademyService
  ) {}

  ngOnInit(): void {
    this.academyform = this.formBuilder.group({
      InstituteName: ['', Validators.required],
      InstituteDescription: ['', Validators.required],
      InstituteAddress: ['', Validators.required],
      Mobile:['', Validators.required],
      Email:['', Validators.required],
      ImgUrl:['', Validators.required]

    });
  }

  onSubmit(): void {
    if (this.academyform.valid) {
      this.addacademy.Create(this.academyform.value).subscribe((res) => {
        console.log(res);
      alert('Institute Added');
        
      });

      this.academyform.reset();
    } else {
      alert('Form should not be null');
    }
  }
}
