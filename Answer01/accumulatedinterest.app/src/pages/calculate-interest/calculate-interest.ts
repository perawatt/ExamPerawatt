import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

/**
 * Generated class for the CalculateInterestPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-calculate-interest',
  templateUrl: 'calculate-interest.html',
})
export class CalculateInterestPage {
  items : any = [];
  percent : number;
  balance : number;
  year : number;
  constructor(public navCtrl: NavController, public navParams: NavParams,private httpClient: HttpClient) {
    this.percent = this.navParams.get('percent');
  }

  getCalculate(){
    console.log(this.percent,this.balance,this.year);
    this.httpClient.get("https://localhost:44387/api/Interest/Get/"+this.percent+"/"+this.balance+"/"+this.year)
    .subscribe((data: any) => {
      this.items = data;
      console.log(JSON.stringify(data));
    }, error => {
      // If error
    });
  }

  clear()
  {
    this.balance = 0;
    this.year = 0;
    this.items = [];
  }


  ionViewDidLoad() {
    console.log('ionViewDidLoad CalculateInterestPage');
  }

}
