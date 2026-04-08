import { Component } from '@angular/core';
import { Hero } from '../Hero';
import {FormsModule} from '@angular/forms'
import { CommonModule } from '@angular/common';
import { JsonPipe } from '@angular/common';


@Component({
  selector: 'app-hero-form',
  imports: [FormsModule,CommonModule,JsonPipe],
  templateUrl: './hero-form.html',
  styleUrl: './hero-form.css',
})
export class HeroForm {
  powers=['Really Smart','Super Flexible','Super Hot','Weather changer'];
  myhero=new Hero(18,'De. IQ',this.powers[0],'check overstreet');

  submitted=false;
  onSubmit(){
    console.log(this.myhero.id,this.myhero.alterEgo);
    this.submitted=true; 
  }
}
