import { Product } from "./product";

export class Cart {
    constructor(
      public Id: string,
      public Products: Product[],
      public SumNoDiscount: number,
      public Discount: number,
      public SumWithDiscount: number
    ) { }
  }