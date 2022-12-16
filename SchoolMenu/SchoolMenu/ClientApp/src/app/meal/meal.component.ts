import { Component, OnInit } from '@angular/core';
import { Location } from '@angular/common';

@Component({
  selector: 'app-meal',
  templateUrl: './meal.component.html',
  styleUrls: ['./meal.component.css']
})
export class MealComponent implements OnInit {

  constructor(private _location: Location) { }

  ngOnInit(): void {
  }

  backLocation(event: any): void {
    event.preventDefault();
    this._location.back();
  }
}
