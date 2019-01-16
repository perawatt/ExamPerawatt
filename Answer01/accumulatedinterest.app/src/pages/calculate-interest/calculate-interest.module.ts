import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { CalculateInterestPage } from './calculate-interest';

@NgModule({
  declarations: [
    CalculateInterestPage,
  ],
  imports: [
    IonicPageModule.forChild(CalculateInterestPage),
  ],
})
export class CalculateInterestPageModule {}
