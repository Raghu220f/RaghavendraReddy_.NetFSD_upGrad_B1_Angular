// Assignment 11: Getters & Setters

class User {
    constructor(password) {
        this._password = "";
        this.password = password; 
    }

    set password(newPassword) {
        if (newPassword.length >= 6) {
            this._password = newPassword;
            console.log("Password set successfully.");
        } else {
            console.log("Password must be at least 6 characters.");
        }
    }

    get password() {
        return this._password;
    }
}

let user1 = new User("secret123");
console.log(user1.password);

user1.password = "123";
console.log(user1.password);

user1.password = "newpass";
console.log(user1.password);