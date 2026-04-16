import { Routes } from '@angular/router';
import { StudentsList } from './components/students-list/students-list';
import { StudentDetails } from './components/student-details/student-details';
//import { Home } from './components/home/home';

export const routes: Routes = [
    {path:'studentlist',component: StudentsList},
    {path:'studentId/:id',component:StudentDetails},
    //{path:'',component:Home,pathMatch:'full'},
];
