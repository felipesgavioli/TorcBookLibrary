import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  private apiUrl = 'http://localhost:5196/'; // old azure link https://torc-book-libary.azurewebsites.net

  constructor(private http: HttpClient) {}

  getBooks(): Observable<any[]> {
    return this.http.get<any[]>(`${this.apiUrl}book`);
  }
  
  searchBooks(searchTerm: string): Observable<any[]> {
    return this.http.get<any[]>(`${this.apiUrl}book/search?searchTerm=${searchTerm}`);
  }
}
