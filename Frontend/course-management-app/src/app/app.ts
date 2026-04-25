import { Component, OnInit } from '@angular/core';
import { CourseService } from './services/course.service';
import { Course } from './models/course.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.html',
  standalone: false,
  styleUrl: './app.css'
})
export class App implements OnInit {
  courses: Course[] = [];
  editingCourse: Course | null = null;
  errorMessage = '';

  constructor(private courseService: CourseService) {}

  ngOnInit(): void {
    this.loadCourses();
  }

  loadCourses(): void {
    this.courseService.getCourses().subscribe({
      next: (data) => (this.courses = data),
      error: () => (this.errorMessage = 'Failed to load courses. Is the API running?')
    });
  }

  onSubmitCourse(courseData: Omit<Course, 'id'>): void {
    if (this.editingCourse) {
      this.courseService.updateCourse(this.editingCourse.id, courseData).subscribe({
        next: () => {
          this.editingCourse = null;
          this.loadCourses();
        },
        error: () => (this.errorMessage = 'Failed to update course.')
      });
    } else {
      this.courseService.addCourse(courseData).subscribe({
        next: () => this.loadCourses(),
        error: () => (this.errorMessage = 'Failed to add course.')
      });
    }
  }

  onDeleteCourse(id: number): void {
    this.courseService.deleteCourse(id).subscribe({
      next: () => this.loadCourses(),
      error: () => (this.errorMessage = 'Failed to delete course.')
    });
  }

  onEditCourse(course: Course): void {
    this.editingCourse = course;
  }

  onCancelEdit(): void {
    this.editingCourse = null;
  }
}
