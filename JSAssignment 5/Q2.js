//Assignment 2: Bank Account System

class BankAccount {
    constructor(accountHolder, balance) {
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    deposit(amount) {
        if (amount > 0) {
            this.balance += amount;
            console.log(`₹${amount} deposited successfully.`);
        } else {
            console.log("Invalid deposit amount.");
        }
    }

    withdraw(amount) {
        if (amount > this.balance) {
            console.log("Insufficient balance. Withdrawal failed.");
        } else if (amount <= 0) {
            console.log("Invalid withdrawal amount.");
        } else {
            this.balance -= amount;
            console.log(`₹${amount} withdrawn successfully.`);
        }
    }

    checkBalance() {
        console.log(`Current balance: ₹${this.balance}`);
    }
}

let acc1 = new BankAccount("Rahul", 5000);

acc1.deposit(2000);      // 7000
acc1.withdraw(3000);     // 4000
acc1.withdraw(5000);     // Insufficient balance
acc1.checkBalance();     // 4000