import { Photo } from './photo';

export interface User {
  id: number;
  userName: string;
  firstName: string;
  lastName: string;
  email: string;
  age: number;
  gender: string;
  created: Date;
  lastActive: Date;
  photoUrl: string;
  city: string;
  country: string;
  photos?: Photo;
  roles?: string[];
}
