fetch('https://torc-book-libary.azurewebsites.net/book/')
    .then(response => response.json())
    .then(data => {
        const resultsContainer = document.getElementById('resultsContainer');
        resultsContainer.innerHTML = '';

        const table = document.createElement('table');
        table.id = 'searchResults';
        
        const headerRow = document.createElement('tr');
        const headers = ['Title', 'Author', 'ISBN'];
        headers.forEach(headerText => {
            const th = document.createElement('th');
            th.textContent = headerText;
            headerRow.appendChild(th);
        });
        table.appendChild(headerRow);

        data.forEach(book => {
            const row = document.createElement('tr');
            const titleCell = document.createElement('td');
            titleCell.textContent = book.title;
            const authorCell = document.createElement('td');
            authorCell.textContent = `${book.firstName} ${book.lastName}`;
            const isbnCell = document.createElement('td');
            isbnCell.textContent = book.isbn;
            row.appendChild(titleCell);
            row.appendChild(authorCell);
            row.appendChild(isbnCell);
            table.appendChild(row);
        });

        resultsContainer.appendChild(table);
    })
    .catch(error => console.error('Api error:', error));