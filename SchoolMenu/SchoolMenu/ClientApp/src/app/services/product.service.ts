import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { AddProduct, Product } from '../models/Product';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  baseUrl: string;
  constructor(private http: HttpClient) {
    this.baseUrl = environment.baseUrl + 'Product/';
  }

  getAll(): Observable<Product[]> {
    return this.http.get<Product[]>(this.baseUrl + `get-all`);
  }

  add(dto: AddProduct): Observable<void> {
    return this.http.post<void>(this.baseUrl + `add`, dto);
  }

  delete(id: string): Observable<void> {
    return this.http.delete<void>(this.baseUrl + `delete?id=${id}`);
  }

  update(dto: Product): Observable<void> {
    return this.http.put<void>(this.baseUrl + `update`, dto);
  }

}
