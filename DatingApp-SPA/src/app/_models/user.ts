import { Photo } from './photo';

export interface User {
    id: number;
    username: string;
    knownAs: string;
    age: number;
    gender: string;
    created: Date;
    lastActive: Date;
    photoUrl: string;
    city: string;
    country: string;
    interests?: string; // ?: znamena optional, musi byt az za povinnymi atr.
    introduction?: string;
    lookingFor?: string;
    photos?: Photo[];
}
