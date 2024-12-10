import React from 'react';
import ReactDOM from 'react-dom/client';
import './css/index.css';
import App from './App';
import { setAxiosFactory } from './api/proxy/proxy';
import { axiosSwaggerInstance, queryClient } from './api/api';
import { QueryClientProvider } from '@tanstack/react-query';


const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);

setAxiosFactory(() => axiosSwaggerInstance);

root.render(
  <React.StrictMode>
    <QueryClientProvider  client={queryClient}>
      <App />
    </QueryClientProvider >
  </React.StrictMode>
);
