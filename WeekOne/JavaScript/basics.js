
/*

Data Types

    Boolean
    Null
    Undefined
    Number
    String
*/

//Basic variable assignment
var x = 'Hello, World!';

//but don't do this...
x = 'Oh crap. Global variable.'

//objects
var person = {
    name: 'Krombopulos Michael',
    occupation: 'Interstellar assassin',
    quotes: [
        'Oh boy, here I go killin\' again!',
        'I\'m very discreet. I have no code of ethics. ' +
        'I will kill anyone, anywhere. Children, animals, old people, ' +
        'doesn\'t matter. I just love killing.'
    ],
    toString: function() {
        return this.name + ' ' + this.occupation;
    }
};

//functions
function add(x,y) {
    var result = x + y;
    console.log(result);
};

//NOTE: Functions are FIRST CLASS Objects in JS. Meaning you can pass them as arguments.

//logic
if(5 > 1) {
    console.log('yep');
}

if(1) {
    console.log('yep');
}

if(-1) {
    console.log('yep');
}

if(0) {
    console.log('yep');
}

if() {

} else if() {

} else {

}

var i = 10;
while(i--) { console.log(i); }

for(var i = 0; i < 10; i++) { console.log(i); }

//arrays
var arr = [];
var arr = new Array();
var arr = Array();

arr = [1,2,3,4,5];

arr.forEach(function(element){
    console.log(element);
});

//tips and debugging
console.log();

alert('yo');

debugger;

/* Footguns
* https://github.com/stevekwan/best-practices/blob/master/javascript/gotchas.md
* Type coercion
*
* Truthiness and Equality
*
* Closures
*
* */


