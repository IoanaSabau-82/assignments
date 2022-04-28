//alert("script1");
let newEl = document.createElement("p");
let innerContent = "this is the window lenght" + screen.width.toString();
console.log(innerContent);
newEl.innerHTML=innerContent;
document.body.append(newEl);

//declaram, dupa initializam
var string;
string = "winter is comming";
console.log(string);

//declaram + initializam
var string = "the north remembers";
console.log(string);

// mm variabile in acc rand

var product = "apple", um = "kg", minQty = 1;
console.log(product, um, minQty);

//numere

var number;
number = 100;
number = 12.55;
number = "1"; //se poate refolosi acelasi nume de variabila, dynamically typed

//infinit
console.log(1/0);

//op incorecta
console.log("ana"*5);

//metode pe numere
console.log(isNaN(1/0));
console.log(isNaN("ana"*5));
console.log(isFinite(1/0));
console.log(isFinite(10));
console.log(isFinite(Infinity));