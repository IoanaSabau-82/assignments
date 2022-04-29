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
number = 12.55;  //se poate refolosi acelasi nume de variabila, dynamically typed

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

let number1 = 2

document.getElementById("numbers").innerHTML = 
"raise number 1 to 2nd power, result: "+ number1.toExponential(2) + "<br>" +
"round number, no digits " + number.toFixed(0)+ "<br>" +
"round number, 2 digits "+ number.toFixed(2)+ "<br>" +
"round number, 4 digits "+ number.toFixed(4)+ "<br>" +
"convert string '100' to number, result: "+Number("100")+ "<br>" +
"convert true to number, result: "+Number(true)+ "<br>" +
"convert string 'dana' to number, result:"+Number("dana")+ "<br>"+
"parse string '10' to int" + parseInt("10");

//metode pe string-uri
var text = "textul tau aici";
text = 'nu conteaza daca sunt unul sau 2 apostrofuri'

document.getElementById("strings").innerHTML = 
`length: ${text.length } <br>
second character ${text[1]} <br>
second character's code ${text.charCodeAt(1)} <br>
to uppercase ${text.toUpperCase()} <br>
does text end with char 'a'? - ${text.endsWith("a")}<br>
first index of char 'n' - ${text.indexOf('n')}<br>
last index of char 'i' - ${text.lastIndexOf('i')}<br>
`;

text = text.replace("nu", "poate");
console.log(text);

var list = text.split(" ");
list.forEach(console.log);

//arrays
text = list.concat([1,2,3]);
console.log(text);

//boolean
var bool = true;
console.log(`first bool is ${bool}`);
bool = false;
console.log(`than bool is ${bool}`);

//null
let sum = null;
console.log(`is sum null? - ${sum == null}`);

//undefined
var undef;
console.log(undef);

//object
var dog = {
    name : "Sookie",
    color : "brown",
    size : "overweight small breed :)"
}

dog.bark = "hysterical";
console.log(dog.name, dog.color, dog.size, dog.bark);
dog["color"] = "spotted";
console.log(dog.color);
delete dog.color;
console.log(dog.color);