import { Component } from '@angular/core';
import { JsonPipe } from '@angular/common';
import { FormsModule, NgForm } from '@angular/forms';

@Component({
  selector: 'app-my-form',
  imports: [JsonPipe,FormsModule],
  templateUrl: './my-form.html',
  styleUrl: './my-form.css',
})
export class MyForm {
  onSubmit(f:NgForm){
    
console.log(f.value);          
    console.log(f.value.first);    
    console.log(f.value.last);
    console.log(f.controls['first'].value);
    console.log(f.valid);

  }
}
