import { Component, OnInit, inject } from '@angular/core'; // Added OnInit and inject
import { FormsModule } from '@angular/forms';
import { Student } from '../../models/student.model';
import { StudentService } from '../../services/student-service';
import { CommonModule } from '@angular/common';
import { Router, RouterLink, ActivatedRoute } from '@angular/router'; // Added ActivatedRoute

@Component({
  selector: 'app-students-list',
  standalone: true,
  imports: [FormsModule, CommonModule, RouterLink],
  templateUrl: './students-list.html',
  styleUrl: './students-list.css',
})
export class StudentsList implements OnInit {
  stdList: Student[] = [];
  
  // Using modern 'inject' or constructor injection works
  private studentService = inject(StudentService);
  private router = inject(Router);
  private activatedRoute = inject(ActivatedRoute);

  ngOnInit() {
    // Corrected syntax: Just call getData when the component loads
    this.getData();
    
    // If you specifically need to react to route data changes:
    this.activatedRoute.data.subscribe({
      next: (data) => {
        console.log('Route data:', data);
        this.getData();
      }
    });
  }
  
getData() {
    this.studentService.getStudents()
        .subscribe({next: (data) => {this.stdList = data;
        console.log(data);},
          error:(e)=>console.error(e)
        });
  }
}
