import { Component } from '@angular/core';
import {FormsModule} from '@angular/forms';

@Component({
  selector: 'app-binding',
  imports: [FormsModule],
  templateUrl: './binding.html',
  styleUrl: './binding.css',
})
export class Binding {
  fontColor='blue';
  sayHelloId=1;
  canClick=false;
  message='Hello World!';
  name="mary jane";

  sayMessage(){
    alert(this.message);
    this.canClick=true;
    console.log(this.name);
  }
}
