import { Routes } from '@angular/router';
import { BookComponent } from './components/book/book.component';

export const routes: Routes = [
    { path: '', component: BookComponent },
    { path: 'books', component: BookComponent },
  ];