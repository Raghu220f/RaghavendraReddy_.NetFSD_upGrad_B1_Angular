// Assignment 5: Employee Salary System

class Employee {
    constructor(name, salary) {
        this.name = name;
        this.salary = salary;
    }

    getDetails() {
        console.log(`Name: ${this.name}`);
        console.log(`Base Salary: ₹${this.salary}`);
    }
}

class Manager extends Employee {
    constructor(name, salary, bonus) {
        super(name, salary);
        this.bonus = bonus;
    }

    getTotalSalary() {
        return this.salary + this.bonus;
    }
}

class Director extends Manager {
    constructor(name, salary, bonus, stockOptions) {
        super(name, salary, bonus);
        this.stockOptions = stockOptions;
    }

    getFullCompensation() {
        return this.salary + this.bonus + this.stockOptions;
    }
}


let emp = new Employee("Rahul", 50000);
emp.getDetails();

console.log("------------");

let mgr = new Manager("Amit", 80000, 20000);
mgr.getDetails();
console.log("Total Salary (Manager): ₹" + mgr.getTotalSalary());

console.log("------------");

let dir = new Director("Sneha", 150000, 50000, 100000);
dir.getDetails();
console.log("Full Compensation (Director): ₹" + dir.getFullCompensation());