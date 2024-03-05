const { Journal } = require("./journal");

let j = new Journal;
j.addEntry("I cried today.");
j.addEntry("I ate a bug.");
console.log(j.toString());
