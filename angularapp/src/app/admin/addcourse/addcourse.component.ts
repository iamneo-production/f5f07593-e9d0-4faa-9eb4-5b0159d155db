import { Component, OnInit } from '@angular/core';

import { FormGroup, FormBuilder, Validators, NgForm } from '@angular/forms';

import { AddcourseService } from '../../services/addcourse.service';


export class CourseModel {
  CourseName!: string;

  CourseDescription!: string;

  CourseDuration!: string;
}

@Component({
  selector: 'app-addcourse',

  templateUrl: './addcourse.component.html',

  styleUrls: ['./addcourse.component.css'],
})
export class AddcourseComponent implements OnInit {
  courseform!: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    public addCourse: AddcourseService
  ) {}

  ngOnInit(): void {
    this.courseform = this.formBuilder.group({
      CourseName: ['', Validators.required],
      CourseDescription: ['', Validators.required],
      CourseDuration: ['', Validators.required],
    });
  }

  onSubmit(): void {
    if (this.courseform.valid) {
      this.addCourse.Create(this.courseform.value).subscribe((res) => {
        console.log(res);
        alert('Course Added');
      });

      this.courseform.reset();
    } else {
      alert('Form should not be null');
    }
  }
}
