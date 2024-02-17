fetch('http://localhost:5196/book/')
    .then(response => response.json())
    .then(data => {
        
    })
    .catch(error => console.error('Api error:', error));
