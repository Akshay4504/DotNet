import { Routes } from '@angular/router';
import { MyHeros } from './my-heros/my-heros';
import { Dashboard } from './dashboard/dashboard';
import { HeroDetails } from './hero-details/hero-details';

export const routes: Routes = [
  { path: 'myheros', component: MyHeros },
  { path: 'dashboard', component: Dashboard },
  { path: 'detail/:id', component: HeroDetails },
  {path:'',component: Dashboard}
];