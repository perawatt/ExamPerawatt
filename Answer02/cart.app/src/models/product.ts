export class Product {
    constructor(
      public Id: string,
      public Name: string,
      public Price: number,
      public Amount: number,
      public Discount: number,
      public Sum: number
    ) { }
  }