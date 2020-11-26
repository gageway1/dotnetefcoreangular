import { Injectable } from '@angular/core';
import { BehaviorSubject, Subject } from 'rxjs';
import { User } from '../Models/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private _user: BehaviorSubject<User> = new BehaviorSubject<User>(null);
  constructor() {
  }

  public changeUser(user: User) {
    this._user.next(user);
  }

  get user() {
    return this._user.asObservable();
  }

}
