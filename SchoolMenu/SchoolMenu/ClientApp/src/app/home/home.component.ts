import { Component, OnDestroy } from '@angular/core';
import { Observable, Subject, takeUntil } from 'rxjs';
import { Menu } from '../models/Menu';
import { MenuService } from '../services/menu.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnDestroy {
  public menu: Menu | null = null;

  private subscriptions: Subject<void> = new Subject();

  constructor(private menuService: MenuService) {
    menuService.getAll()
      .pipe(takeUntil(this.subscriptions))
      .subscribe(m => {
        this.menu = m[0];
      });
  }
  ngOnDestroy(): void {
    this.subscriptions.next();
    this.subscriptions.complete();
  }
}
