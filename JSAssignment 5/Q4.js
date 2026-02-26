//Assignment 4: Vehicle Inheritance

class Vehicle {
    constructor(brand, speed) {
        this.brand = brand;
        this.speed = speed;
    }

    start() {
        console.log(`${this.brand} vehicle is starting at ${this.speed} km/h.`);
    }
}

class Car extends Vehicle {
    constructor(brand, speed, fuelType) {
        super(brand, speed); // calling parent constructor
        this.fuelType = fuelType;
    }

    showDetails() {
        console.log(`Brand: ${this.brand}`);
        console.log(`Speed: ${this.speed} km/h`);
        console.log(`Fuel Type: ${this.fuelType}`);
    }
}

let car1 = new Car("Toyota", 120, "Petrol");

car1.start();        // Calling parent method
car1.showDetails();  // Child method