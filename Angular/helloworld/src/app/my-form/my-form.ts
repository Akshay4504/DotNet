
import { JsonPipe } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule,NgForm } from '@angular/forms';

@Component({
  selector: 'app-my-form',
  imports: [FormsModule,JsonPipe],
  templateUrl: './my-form.html',
  styleUrl: './my-form.css',
})
export class MyForm {
  onSubmit(f: NgForm){
    console.log(f.value);
    console.log(f.value.first,'',f.value.last);
    console.log(f.controls['first'].value);
    console.log(f.valid);
  }
}
