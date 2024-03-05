const { Journal } = require("./journal");
const { Persistence } = require("./persistence");

const j = new Journal();
j.addEntry("I cried today.");
j.addEntry("I ate a bug.");
console.log(j.toString());

const p = new Persistence(j);
p.saveToFile("journal.txt");
