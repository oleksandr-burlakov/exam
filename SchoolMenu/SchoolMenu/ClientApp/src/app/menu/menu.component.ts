import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable, Subject, takeUntil } from 'rxjs';
import { DayMenu } from '../models/DayMenu';
import { DayMenuService } from '../services/day-menu.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit, OnDestroy {
  private menuId!: string;
  private subscriptions: Subject<void> = new Subject();
  public dayMenus!: Observable<DayMenu[]>;
  public daySelect: number = 0;

  constructor(private route: ActivatedRoute,
    private dayMenuService: DayMenuService) {
    
  }

  ngOnDestroy(): void {
    this.subscriptions.next();
    this.subscriptions.complete();
  }

  ngOnInit(): void {
    this.route.params
      .pipe(takeUntil(this.subscriptions))
      .subscribe(p => {
        this.menuId = p['id'];
        this.dayMenus = this.dayMenuService.getById(this.menuId);
      })
  }

  addNewMenu(): void {
    this.dayMenuService.add({
      menuId: this.menuId,
      weekDay: this.daySelect
    })
      .pipe(takeUntil(this.subscriptions))
      .subscribe(p => {
        this.dayMenus = this.dayMenuService.getById(this.menuId);
      });
  }

  delete(id: string): void {
    this.dayMenuService.delete(id)
      .pipe(takeUntil(this.subscriptions))
      .subscribe(p => {
        this.dayMenus = this.dayMenuService.getById(this.menuId);
      });
  }

}
