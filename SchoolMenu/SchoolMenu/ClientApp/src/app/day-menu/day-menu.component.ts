import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable, Subject, takeUntil } from 'rxjs';
import { Meal } from '../models/Meal';
import { MealService } from '../services/meal.service';

@Component({
  selector: 'app-day-menu',
  templateUrl: './day-menu.component.html',
  styleUrls: ['./day-menu.component.css']
})
export class DayMenuComponent implements OnInit, OnDestroy {

  public menuId!: string;
  private subscriptions: Subject<void> = new Subject();

  public meals!: Observable<Meal[]>;

  constructor(private route: ActivatedRoute,
    private mealService: MealService) { }

  
  ngOnInit(): void {
    this.route.params
      .pipe(takeUntil(this.subscriptions))
      .subscribe(p => {
        this.menuId = p['id'];
        this.meals = this.mealService.getByMenuId(this.menuId);
      })
  }



  ngOnDestroy(): void {
    this.subscriptions.next();
    this.subscriptions.complete();
  }

  deleteMeal(id: string): void {
    this.mealService.delete(id)
      .pipe(takeUntil(this.subscriptions))
      .subscribe(p => {
        this.meals = this.mealService.getByMenuId(this.menuId);
      });
  }

}
