import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import {Student} from '../models/student.model';
import { Observable, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
export class StudentService {
  constructor(private httpClient: HttpClient) {}

  httpOptions = {
    headers: new HttpHeaders( {'Content-Type': 'application/json' } ),
  };
  private baseUrl = 'https://localhost:7133/api';

  getStudents(): Observable<Student[]> {
    const url = `${this.baseUrl}/student/getallstudents`;
    return this.httpClient.get<Student[]>(url, this.httpOptions)
      .pipe(retry(1), catchError(this.errorHandler));
  }

  errorHandler(error: any) {
    let errorMessage = '';
    if (error.error instanceof ErrorEvent) {
      // Get client-side error
      errorMessage = error.error.message;
    } else {
      // Get server-side error
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    console.log(errorMessage);
    return throwError(() => errorMessage);
}
}
