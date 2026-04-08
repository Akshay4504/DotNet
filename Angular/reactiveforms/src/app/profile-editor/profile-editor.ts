import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-profile-editor',
  imports: [CommonModule],
  templateUrl: './profile-editor.html',
  styleUrl: './profile-editor.css',
})
export class ProfileEditor {
  profileForm=new FormGroup({
    firstName:new FormControl(''),
    lastName:new FormControl(''),
    address:new FormControl('street,city,state,zip'),
  });
  submitted=false;

  updateName(){
    console.log(this.profileForm.controls.firstName.value);

    this.profileForm.controls.firstName.setValue('Akshay');
    this.profileForm.controls.lastName.setValue('Anand');

  }

  resetForm(){
    this.profileForm.controls.firstName.setValue('');
    this.profileForm.controls.lastName.setValue('');
    this.profileForm.controls.address.controls.street.setValue('');
    this.profileForm.controls.address.controls.city.setValue('');
    this.profileForm.controls.address.controls.state.setValue('');
    this.profileForm.controls.address.controls.zip.setValue('');
  }

  onSubmit(){
    this.submitted=true;
    console.warn(this.profileForm.value);
    console.log('First name: ' + this.profileForm.controls.firstName.value);
    console.log('Last name: '+ this.profileForm.controls.lastName.value);

    this.resetForm();
  }
}
