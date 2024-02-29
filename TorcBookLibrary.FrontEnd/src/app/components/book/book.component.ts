import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BookService } from '../../services/book.service';
import { Book } from '../../classes/book';
import { FormsModule } from '@angular/forms';


@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './book.component.html',
  styleUrl: './book.component.scss'
})

export class BookComponent {
  books: Book[] | undefined;
  searchTerm: string = '';

  constructor(private service: BookService) {}


  ngOnInit(): void {
    this.loadBooks()
  }

  loadBooks(): void {
    this.service.getBooks().subscribe(
      (data: any[]) => {
        this.books = data;
      },
      error => {
        console.error('Error fetching books:', error);
      }
    );
  }

  searchBooks(): void {
    if (this.searchTerm.trim() !== '' && this.searchTerm.length >= 3) {
      this.service.searchBooks(this.searchTerm).subscribe(
        (data: any[]) => {
          this.books = data;
        },
        error => {
          console.error('Error searching books:', error);
        }
      );
    } else {
      alert("The search term must be at least 3 characters long.")
      this.loadBooks();
    }
  }
}
