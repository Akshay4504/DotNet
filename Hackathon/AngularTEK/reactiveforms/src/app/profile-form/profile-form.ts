import { Component, inject } from '@angular/core';
import { FormBuilder , ReactiveFormsModule, Validators} from '@angular/forms';
import { CommonModule } from '@angular/common';
import { JsonPipe } from '@angular/common';

@Component({
  selector: 'app-profile-form',
  imports: [ReactiveFormsModule, CommonModule, JsonPipe],
  templateUrl: './profile-form.html',
  styleUrl: './profile-form.css',
})
export class ProfileForm {

  constructor() {}///inject the service FormBuilder in the constructor of the component.
  
  private formBuilder: FormBuilder=inject(FormBuilder);

  profileForm = this.formBuilder.group({
    firstName: ['',[Validators.required, Validators.minLength(5)]],
    lastName: ['',[Validators.required, Validators.minLength(5)]],
    address :this.formBuilder.group({
      street:[''],
      city:[''],
      state:[''],
      zip:['']
    })
  });

  updateProfile() {
    this.profileForm.patchValue({
      firstName: 'Nancy',
      address: {
        street: '123 Drew Street',
            }
    });
  }

  onSubmit() {
    console.log(this.profileForm.value);
    console.log(this.profileForm.controls.firstName);
    console.log(this.profileForm.controls.address.controls.city);
  }
}
