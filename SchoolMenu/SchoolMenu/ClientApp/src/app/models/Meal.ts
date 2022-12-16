export class Meal {
    id: string;
    incomePrice: number;
    outcomePrice: number;
    name: string;
    recipe: string;
    products: string;

    public constructor(id: string, incomePrice: number, outcomePrice: number, name: string, recipe: string, products: string) {
        this.id = id;
        this.incomePrice = incomePrice;
        this.outcomePrice = outcomePrice;
        this.name = name;
        this.recipe = recipe;
        this.products = products;
    }
};

export class MealAdd {
    name: string;
    price: number;
    recipe: string;
    menuId: string;
    productIds: string[];

    public constructor(name:string,price:number, recipe: string, menuId: string, productIds: string[]) {
        this.name = name;
        this.price = price;
        this.recipe = recipe;
        this.menuId = menuId;
        this.productIds = productIds;
    }
};