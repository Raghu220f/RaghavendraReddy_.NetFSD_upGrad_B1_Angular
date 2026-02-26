// Assignment 12: Private Fields (ES2022)

class Wallet {
    #balance = 0;

    constructor(initialAmount = 0) {
        this.#balance = initialAmount;
    }

    addMoney(amount) {
        if (amount > 0) {
            this.#balance += amount;
            console.log(`₹${amount} added.`);
        } else {
            console.log("Invalid amount.");
        }
    }

    spendMoney(amount) {
        if (amount > this.#balance) {
            console.log("Insufficient balance.");
        } else if (amount <= 0) {
            console.log("Invalid amount.");
        } else {
            this.#balance -= amount;
            console.log(`₹${amount} spent.`);
        }
    }

    getBalance() {
        return `Current Balance: ₹${this.#balance}`;
    }
}

let myWallet = new Wallet(1000);

myWallet.addMoney(500);
myWallet.spendMoney(300);

console.log(myWallet.getBalance());


// console.log(myWallet.#balance); // This will cause error: