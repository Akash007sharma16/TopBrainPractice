import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { OrderStatusPipe } from '../order-status-pipe';
@Component({
  selector: 'app-orders',
  standalone: true,
  imports: [CommonModule, OrderStatusPipe],
  templateUrl: './orders.html',
  styleUrls: ['./orders.css']
})
export class OrdersComponent {

  orders = [
    { id: 'ORD-001', name: 'Laptop', price: 55000, date: new Date('2023-10-23'), status: 2 },
    { id: 'ORD-002', name: 'Phone', price: 20000, date: new Date('2023-10-23'), status: 2 },
    { id: 'ORD-003', name: 'Shoes', price: 3000, date: new Date('2023-10-23'), status: 3 },
    { id: 'ORD-004', name: 'Headphones', price: 8000, date: new Date('2023-10-24'), status: 1 },
    { id: 'ORD-005', name: 'Keyboard', price: 4500, date: new Date('2023-10-25'), status: 1 },
    { id: 'ORD-006', name: 'Monitor', price: 18000, date: new Date('2023-10-26'), status: 3 },
  ];

}