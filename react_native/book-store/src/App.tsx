import React, { useState, useMemo} from 'react';
import './css/App.css';
import {FetchStatus} from '@tanstack/react-query'
import { useBookAllQuery, useBookDELETEMutationWithParameters, useBookPOSTMutation } from './api/proxy/proxy/Query';
import BookElement from './components/BookElement/BookElement';

function App() {

  const { data: books, isLoading, isError, refetch } = useBookAllQuery();
  const { mutateAsync: postBook } = useBookPOSTMutation();
  const { mutateAsync: deleteBook } = useBookDELETEMutationWithParameters();


  const [newBook, setNewBook] = useState({ title: '', author: '', publishDate: '' });

  const handleAddBook = async () => {
    await postBook({
      titel: newBook.title,
      author: newBook.author,
      publishDate: newBook.publishDate,
    });
    await setNewBook({ title: '', author: '', publishDate: '' });
    refetch();
  };


  const  deleteItem = async (id : string) => {

    if(id == '') return;

    await deleteBook({id});
    await refetch();
}

const renderBooks = () => {
  if (isLoading) {
    return <p>Loading...</p>;
  }

  if (isError) {
    return <p>Something went wrong...</p>;
  }

  if(books?.length === 0) {
    return <p>No books found</p>;
  }

  return books?.map((book,index) => <BookElement onDelete={(id) => deleteItem(id)} element={book} key={index}/>);
}

  return (
    <div className="App">
      <header className="App-header">

        <div className='container'>
        <h1>BookStore</h1>

        <form className='input-group' onSubmit={(e) => {
          e.preventDefault();
          handleAddBook();
        }}>
          <input
          className='input'
          value={newBook.title}
          onChange={(e) => setNewBook(oldstate =>({ ...oldstate, title: e.target.value }))}
          placeholder="Title"
          type='text'
          required
          />
          <input
            className='input'
            value={newBook.author}
            onChange={(e) => setNewBook(oldstate => ({ ...oldstate, author: e.target.value }))}
            placeholder="Author"
            type='text'
            required
            />
          <input
          className='input'
          value={newBook.publishDate}
          onChange={(e) => setNewBook(oldstate => ({ ...oldstate, publishDate: e.target.value }))}
          placeholder="Publish Date"
          type='datetime-local'
          required
          />
          <button type='submit' className='submit-button'>Add Book</button>
          </form>
        <div className='book-items-container'>
         {renderBooks()}
        </div>
          </div>
      </header>
    </div>
  );
}

export default App;
