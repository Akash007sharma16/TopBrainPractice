import { Routes } from '@angular/router';
import { HomeComponent } from './home/home';
import { OrdersComponent } from './orders/orders';

export const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'orders', component: OrdersComponent }
];