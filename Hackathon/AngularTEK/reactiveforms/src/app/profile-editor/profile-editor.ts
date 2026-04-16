import { Component } from '@angular/core';
import { FormControl, ReactiveFormsModule, FormGroup ,Validator} from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-profile-editor',
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './profile-editor.html',
  styleUrl: './profile-editor.css',
})
export class ProfileEditor {
  profileForm = new FormGroup({
    firstName: new FormControl(''),
    lastName: new FormControl(''),
    address: new FormGroup({
      street: new FormControl(''),
      city: new FormControl(''),
      state: new FormControl(''),
      zip: new FormControl('')
    }),
  });
submitted = false;

  updateProfile() {
    this.profileForm.controls.firstName.setValue('Nancy');
    this.profileForm.controls.lastName.setValue('Drew');
    this.profileForm.controls.address.setValue({
      street: '373 bellandur main road',
      city: 'Bangalore ',
      state: 'Karnataka',
      zip: '703019'
    });
  }
  resetForm() {
    this.profileForm.controls.firstName.setValue('');
    this.profileForm.controls.lastName.setValue('');
    this.profileForm.controls.address.setValue({
      street: '',
      city: '',
      state: '',
      zip: ''
    });
  }

  onSubmit() {
  this.submitted = true;
  console.warn(this.profileForm.value);
  console.log('First Name: ' + this.profileForm.controls.firstName.value);
  console.log('Last Name: ' + this.profileForm.controls.lastName.value);
  console.log('Street: ' + this.profileForm.controls.address.value.street);
  console.log('City: ' + this.profileForm.controls.address.value.city);
  console.log('State: ' + this.profileForm.controls.address.value.state);
  console.log('Zip: ' + this.profileForm.controls.address.value.zip); 
  this.resetForm();
  }

}
