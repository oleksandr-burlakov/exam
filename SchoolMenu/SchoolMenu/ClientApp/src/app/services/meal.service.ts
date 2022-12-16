import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Meal, MealAdd } from '../models/Meal';


@Injectable({
  providedIn: 'root'
})
export class MealService {

  baseUrl: string;
  constructor(private http: HttpClient) {
    this.baseUrl = environment.baseUrl + 'Meal/';
  }

  getByMenuId(id: string): Observable<Meal[]> {
    return this.http.get<Meal[]>(this.baseUrl + `get-by-menu-id?menuId=${id}`);
  }

  add(meal: MealAdd): Observable<void> {
    return this.http.post<void>(this.baseUrl + 'add', meal);
  }

  delete(id: string): Observable<void> {
    return this.http.delete<void>(this.baseUrl + `delete?id=${id}`);
  }
}
