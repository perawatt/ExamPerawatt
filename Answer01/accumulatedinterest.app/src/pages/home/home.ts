import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { CalculateInterestPage } from '../calculate-interest/calculate-interest';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  percent : number;
  constructor(public navCtrl: NavController) {

  }
  gotoCalculate()
  {
    this.navCtrl.push(CalculateInterestPage,{"percent": this.percent});
  }

}
