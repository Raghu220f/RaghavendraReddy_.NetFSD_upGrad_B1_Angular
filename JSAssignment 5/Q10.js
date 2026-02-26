// Assignment 10: Static Methods

class MathUtils {
    static add(a, b) {
        return a + b;
    }

    static subtract(a, b) {
        return a - b;
    }

    static multiply(a, b) {
        return a * b;
    }
}

console.log(MathUtils.add(10, 20));       // 30
console.log(MathUtils.subtract(30, 5));  // 25
console.log(MathUtils.multiply(6, 4));   // 24