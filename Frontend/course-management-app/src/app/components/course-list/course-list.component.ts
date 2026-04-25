import { Component, Input, Output, EventEmitter } from '@angular/core';
import { Course } from '../../models/course.model';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-course-list',
  standalone: false,
  templateUrl: './course-list.component.html',
  styleUrl: './course-list.component.css'
})
export class CourseListComponent {
  @Input() courses: Course[] = [];
  @Output() deleteCourse = new EventEmitter<number>();
  @Output() editCourse = new EventEmitter<Course>();

  onDelete(id: number): void {
    this.deleteCourse.emit(id);
  }

  onEdit(course: Course): void {
    this.editCourse.emit(course);
  }
}
