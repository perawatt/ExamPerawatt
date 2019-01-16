import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { Product } from '../../models/product';

/**
 * Generated class for the ProductsPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-products',
  templateUrl: 'products.html',
})
export class ProductsPage {
  items: any = [];
  constructor(public navCtrl: NavController, public navParams: NavParams,private httpClient: HttpClient) {
  }

  AddToCart(_product: Product){
  let option = { "headers": { "Content-Type": "application/json" } };
  this.httpClient.post("https://localhost:44324/api/cart/AddCart",
  _product,
    option).subscribe((result: Product) => {        
      console.log(result);
      alert("เพิ่มสินค้าเข้าตะกร้าสำเร็จ");
    }, error => {
      console.log(error);
    });
  }

  ionViewWillEnter(){
    this.httpClient.get("https://localhost:44324/api/cart/GetAllProduct")
      .subscribe((data: any) => {
        console.log(JSON.stringify(data));
        this.items = data;
        console.log(this.items);
      }, error => {
        // If error
      });
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad ProductsPage');
  }

}
