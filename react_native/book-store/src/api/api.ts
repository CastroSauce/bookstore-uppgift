import { QueryClient } from '@tanstack/react-query';
import axios from 'axios';
import { getEnvVars } from '../environment';

const { apiUrl } = getEnvVars();



export const axiosSwaggerInstance = axios.create({
  baseURL: apiUrl,
  withCredentials: false,
  headers: {
    'X-Requested-With': 'XMLHttpRequest'
  },
  transformResponse: data => data
});



export const queryClient = new QueryClient({
  defaultOptions: {
    queries: {
      // Cached data is refetched after 12 hours
      staleTime: 1000 * 60 * 60 * 12 ,
      // Cached data is deleted after 24 hours
      gcTime:  1000 * 60 * 60 * 24 
    }
  }
});

