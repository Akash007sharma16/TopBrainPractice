import { Component, Input, Output, EventEmitter, OnChanges, SimpleChanges } from '@angular/core';
import { Course } from '../../models/course.model';

@Component({
  selector: 'app-course-form',
  standalone: false,
  templateUrl: './course-form.component.html',
  styleUrl: './course-form.component.css'
})
export class CourseFormComponent implements OnChanges {
  @Input() editingCourse: Course | null = null;
  @Output() submitCourse = new EventEmitter<Omit<Course, 'id'>>();
  @Output() cancelEdit = new EventEmitter<void>();

  title = '';
  instructor = '';
  duration: number | null = null;

  ngOnChanges(changes: SimpleChanges): void {
    if (changes['editingCourse'] && this.editingCourse) {
      this.title = this.editingCourse.title;
      this.instructor = this.editingCourse.instructor;
      this.duration = this.editingCourse.duration;
    } else if (changes['editingCourse'] && !this.editingCourse) {
      this.reset();
    }
  }

  onSubmit(): void {
    if (!this.title.trim() || !this.instructor.trim() || !this.duration) return;
    this.submitCourse.emit({ title: this.title.trim(), instructor: this.instructor.trim(), duration: this.duration });
    this.reset();
  }

  onCancel(): void {
    this.reset();
    this.cancelEdit.emit();
  }

  private reset(): void {
    this.title = '';
    this.instructor = '';
    this.duration = null;
  }
}
