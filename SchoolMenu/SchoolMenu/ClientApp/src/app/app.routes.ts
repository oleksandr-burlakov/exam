import { Routes } from "@angular/router";
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { MenuComponent } from "./menu/menu.component";
import { DayMenuComponent } from "./day-menu/day-menu.component";
import { MealComponent } from "./meal/meal.component";
import { ProductsComponent } from "./products/products.component";
import { MealCreateComponent } from "./meal-create/meal-create.component";

export const appRoutes: Routes = [

    { path: '', component: HomeComponent, pathMatch: 'full' },
    { path: 'menu/:id', component: MenuComponent},
    { path: 'day-menu/:id', component: DayMenuComponent},
    { path: 'meal/:id', component: MealComponent },
    { path: 'new-meal/:id', component: MealCreateComponent },
    { path: 'products', component: ProductsComponent}
];