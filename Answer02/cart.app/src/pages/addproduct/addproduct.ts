import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { Product } from '../../models/product';

/**
 * Generated class for the AddproductPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-addproduct',
  templateUrl: 'addproduct.html',
})
export class AddproductPage {
  item : Product = new Product("","",0,0,0,0);
  constructor(public navCtrl: NavController, public navParams: NavParams,public httpClient: HttpClient) {
  }

  onSubmit()
  { 
    let option = { "headers": { "Content-Type": "application/json" } };
    this.httpClient.post("https://localhost:44324/api/cart/AddProduct",
    this.item,
      option).subscribe((result: any) => {        
        console.log(result);
        alert("เพิ่มสินค้าเข้าสู่ระบบสำเร็จ");
      }, error => {
        console.log(error);
      });
  }

  clear()
  {
    this.item = new Product("","",0,0,0,0);
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad AddproductPage');
  }

}
