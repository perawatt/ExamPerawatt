import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { Cart } from '../../models/cart';
import { Product } from '../../models/product';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  products : Product[] = [];
  cart: Cart = new Cart("",this.products,0,0,0);
  constructor(public navCtrl: NavController,private httpClient: HttpClient) {

  }
  ionViewWillEnter(){
    this.httpClient.get("https://localhost:44324/api/cart/GetMyCart")
      .subscribe((data: any) => {
        console.log(JSON.stringify(data));
        this.cart = data;
        console.log(JSON.stringify(data));
        console.log(this.cart);
      }, error => {
        // If error
      });
  }
}
