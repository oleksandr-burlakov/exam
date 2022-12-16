import { Component, OnDestroy, OnInit } from '@angular/core';
import { Form, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable, Subject, takeUntil } from 'rxjs';
import { Product } from '../models/Product';
import { MealService } from '../services/meal.service';
import { ProductService } from '../services/product.service';


@Component({
  selector: 'app-meal-create',
  templateUrl: './meal-create.component.html',
  styleUrls: ['./meal-create.component.css']
})
export class MealCreateComponent implements OnInit, OnDestroy {
  private subscriptions: Subject<void> = new Subject();
  private productsArray: string[] = [];
  public menuId!: string;
  public products!: Observable<Product[]>;
  public form: FormGroup;

  constructor(private route: ActivatedRoute,
    private mealService: MealService,
    private productService: ProductService,
    private router: Router,
    private fb: FormBuilder) {
      this.form = fb.group({
        name: new FormControl('', Validators.required),
        price: 0,
        recipe: '',
      });
     }

  
  ngOnInit(): void {
    this.route.params
      .pipe(takeUntil(this.subscriptions))
      .subscribe(p => {
        this.menuId = p['id'];
      })
    this.products = this.productService.getAll();
  }



  ngOnDestroy(): void {
    this.subscriptions.next();
    this.subscriptions.complete();
  }


  handleSubmit(): void {
    let productIds = 

    this.mealService.add({
      menuId: this.menuId,
      name: this.form.get('name')?.value,
      price: this.form.get('price')?.value,
      recipe: this.form.get('recipe')?.value,
      productIds: this.productsArray
    })
    .pipe(takeUntil(this.subscriptions))
    .subscribe(p => {
      this.router.navigate(['day-menu', this.menuId]);
    });
  }

  onChange(id:string, event: any) {
    let isChecked = event.target.checked;
    if(isChecked) {
      this.productsArray.push(id);
    } else {
      let index = this.productsArray.findIndex(x => x == id)
      this.productsArray.splice(index, 1);
    }
  }
}
