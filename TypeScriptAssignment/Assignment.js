"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
function PlayGame(playWith) {
    return `you played a game with a ${playWith.type} ball`;
}
let result = PlayGame({ bouncy: true, type: "tennis" });
console.log(result);
class SewingMachine {
    constructor() {
        this.needle = "size2";
    }
    speed() {
        return 5;
    }
}
//cu mai putini param e ok, mai multi nu (type compatibility)
let calculateSum;
calculateSum = function () {
    let sum = 0;
    let input = [4, 5, 6];
    for (let i of input)
        sum += i;
    return sum;
};
let calculateSum1;
calculateSum1 = function (input) {
    let sum = 0;
    for (let i of input)
        sum += i;
    return sum;
};
console.log(calculateSum([1, 5]));
//classes and acces modifiers
class Dog {
    constructor(theBreed, theName) {
        this.hasCip = false;
        this.age = 1;
        this.breed = theBreed, this.name = theName;
    }
    addCip(cip) {
        this.hasCip = true;
        return `${this.name} has cip ${cip} and hasCip property is now ${this.hasCip}`;
    }
    ;
    bark(sound) {
        console.log(`I bark ${sound}`);
    }
    ;
}
let charly = new Dog("russel terrier", "Charles");
//has cip and age not accesible att all
//name can't be re-assigned
//addCip method can use the hasCip value
console.log(charly.addCip(123));
class SmallDog extends Dog {
    constructor() {
        super(...arguments);
        //cannot acces hasCip
        this.age = 2;
    }
    bark(sound) {
        super.bark(sound);
        console.log("the hole street should hear me");
    }
}
;
new SmallDog("pug", "Grumpy").bark("woh");
function toList(in1, in2) {
    return [in1, in2];
}
;
let myFunc = toList;
console.log(myFunc(1, 2));
//class
class GenericFurnitureDetails {
    constructor(theItem, theProducer) {
        this.item = theItem;
        this.producer = theProducer;
    }
    display() {
        console.log(`this ${this.item} is produced by ${this.producer}`);
    }
    ;
}
let product = {
    sofa: "Carla",
    color: "red"
};
let dressoirDumbo = new GenericFurnitureDetails(123, "someProducer");
console.log(dressoirDumbo.item, dressoirDumbo.producer);
dressoirDumbo.display();
//could be usefull for different types of objects that have properties with the same name
let sofaCarla = new GenericFurnitureDetails(product, "someProducer");
console.log(sofaCarla.item, sofaCarla.producer);
sofaCarla.display();
//this with regular or arrow functions
let fruitTree = {
    name: "appleTree",
    ripe: "autummn",
    etProduction: 50,
    pick() {
        console.log(`${this} tree will be ripe in ${this.ripe}`);
    }
};
let fruitTree1 = {
    name: "appleTree",
    ripe: "autummn",
    etProduction: 50,
    pick: function () {
        return () => {
            console.log(`${this} tree will be ripe in ${this.ripe}`);
        };
    }
};
fruitTree.pick();
var pickMe = fruitTree1.pick();
pickMe();
