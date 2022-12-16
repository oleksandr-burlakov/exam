export class Product {
    id: string;
    name: string;
    productPrice: number;

    constructor(id: string, name: string, productPrice: number) {
        this.id = id;
        this.name = name;
        this.productPrice = productPrice;
    }
}

export class AddProduct {
    name: string;
    productPrice: number;

    constructor(name: string, productPrice: number) {
        this.name = name;
        this.productPrice = productPrice;
    }
}