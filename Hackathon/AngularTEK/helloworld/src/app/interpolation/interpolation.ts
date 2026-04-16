import { Component } from '@angular/core';

@Component({
  selector: 'app-interpolation',
  imports: [],
  templateUrl: './interpolation.html',
  styleUrl: './interpolation.css',
})
export class Interpolation {
  public text: string="Hello";
  public caption :string="Clik Me";
  num: number =0;
  randomNums:number[]=[3,4,5,6,8,21,345,67];
  private count:number=0;

  ngOnIt():void{  }

  getCurrentTime():any{
    return Date.now();
  }
}
