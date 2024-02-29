export class Book {
    bookId: number;
    title: string;
    firstName: string;
    lastName: string;
    totalCopies: number;
    copiesInUse: number;
    type: string;
    isbn: string;
    category: string;
  
    constructor() {
      this.bookId = 0;
      this.title = '';
      this.firstName = '';
      this.lastName = '';
      this.totalCopies = 0;
      this.copiesInUse = 0;
      this.type = '';
      this.isbn = '';
      this.category = '';
    }
  }
  