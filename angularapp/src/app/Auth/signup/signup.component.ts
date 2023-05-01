import { Component, OnInit } from '@angular/core';

import { FormGroup, FormBuilder, Validators, NgForm } from '@angular/forms';

import { RegisterService } from 'src/app/services/register.service';

export class RegisterModel {
  Email!: string;

  Password!: string;

  Username!: string;

  MobileNumber!: string;

  UserRole!: any;
}

@Component({
  selector: 'app-signup',

  templateUrl: './signup.component.html',

  styleUrls: ['./signup.component.css'],
})
export class SignupComponent implements OnInit {
  registerForm!: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    public registerservice: RegisterService
  ) {}

  ngOnInit(): void {
    this.registerForm = this.formBuilder.group({
      UserName: ['', Validators.required],

      Email: ['', [Validators.required, Validators.email]],

      Password: ['', [Validators.required, Validators.minLength(6)]],

      MobileNumber: ['', Validators.required],

      UserRole: ['', Validators.required],
    });
  }

  onSubmit(): void {
    if (this.registerForm.valid) {
      this.registerservice.Create(this.registerForm.value).subscribe((res) => {
        console.log(res);
      });

      this.registerForm.reset();
    } else {
      alert('Form should not be null');
    }
  }
}
