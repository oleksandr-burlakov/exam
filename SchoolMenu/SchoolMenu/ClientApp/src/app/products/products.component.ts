import { Location } from '@angular/common';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { Observable, Subject, takeUntil } from 'rxjs';
import { Product } from '../models/Product';
import { ProductService } from '../services/product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit, OnDestroy {
  private subscriptions: Subject<void> = new Subject();

  public products!: Observable<Product[]>;
  public name!: string;
  public price!: number;

  constructor(private _location: Location,
    private productService: ProductService) { }

  ngOnDestroy(): void {
    this.subscriptions.next();
    this.subscriptions.complete();
  }

  ngOnInit(): void {
    this.products = this.productService.getAll();
  }

  getBack(event: any): void {
    event.preventDefault();
    this._location.back();
  }

  delete(id: string): void {
    this.productService.delete(id)
      .pipe(takeUntil(this.subscriptions))
      .subscribe(p => {
        this.products = this.productService.getAll();
      });
  }

  public add(): void {
    this.productService.add({
      name: this.name,
      productPrice : this.price
    })
      .pipe(takeUntil(this.subscriptions))
      .subscribe(p => {
        this.name = '';
        this.price = 0;
        this.products = this.productService.getAll();
      });
  }
}
