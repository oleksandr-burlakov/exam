import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { DayMenu, DayMenuInsert } from '../models/DayMenu';

@Injectable({
  providedIn: 'root'
})
export class DayMenuService {
  baseUrl: string;
  constructor(private http: HttpClient) {
    this.baseUrl = environment.baseUrl;
  }

  getById(id: string): Observable<DayMenu[]> {
    return this.http.get<DayMenu[]>(this.baseUrl + `DayMenu/get-by-menu-id?menuId=${id}`);
  }

  add(menu: DayMenuInsert): Observable<void> {
    return this.http.post<void>(this.baseUrl + 'DayMenu/add', menu);
  }

  delete(id: string): Observable<void> {
    return this.http.delete<void>(this.baseUrl + `DayMenu/delete?menuId=${id}`);
  }
}
