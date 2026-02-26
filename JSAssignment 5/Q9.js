// Assignment 9: Use ES6 Features Inside Class
class Product {
    constructor({ name, price, category = "General" }) {
        this.name = name;
        this.price = price;
        this.category = category;
    }

    getDetails = () => {
        return `Product: ${this.name} | Price: ₹${this.price} | Category: ${this.category}`;
    }

    applyDiscount = (discount = 0) => {
        this.price = this.price - discount;
        return `Discounted Price: ₹${this.price}`;
    }

    cloneProduct = (extraDetails = {}) => {
        return new Product({ ...this, ...extraDetails });
    }
}


let p1 = new Product({ name: "Laptop", price: 60000 });

console.log(p1.getDetails());

console.log(p1.applyDiscount(5000));

let p2 = p1.cloneProduct({ name: "Gaming Laptop", category: "Electronics" });

console.log(p2.getDetails());