import { Component, inject } from '@angular/core';
import { FormBuilder, Validators, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-login-form',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './login-form.html',
  styleUrl: './login-form.css'
})
export class LoginForm {

  loggedIn = false;
  showHint = false;

  constructor() {}
  private formBuilder: FormBuilder =inject(FormBuilder);

  loginForm = this.formBuilder.group({
    username: ['', [Validators.required, Validators.minLength(10)]],
    password: ['', [Validators.required, Validators.minLength(8)]],
  });

  onSubmit() {
    if (this.loginForm.valid) {
      console.log(this.loginForm.value); 
    }
  }

  ToggleHint() {
    this.showHint = !this.showHint;
  }

  GetUserName() {
    return this.loginForm.get('username');
  }

  GetPassword() {
    return this.loginForm.get('password');
  }
}
