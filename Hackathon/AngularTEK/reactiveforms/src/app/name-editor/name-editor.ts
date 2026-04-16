import { Component } from '@angular/core';
import { FormControl, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-name-editor',
  imports: [ReactiveFormsModule],
  templateUrl: './name-editor.html',
  styleUrl: './name-editor.css',
})
export class NameEditor {
  myname = new FormControl('');
  mylastname = new FormControl(''); 

  updateName() {
  console.log(this.myname.value);
  this.myname.setValue('');
  this.mylastname.setValue('');
  }
}
