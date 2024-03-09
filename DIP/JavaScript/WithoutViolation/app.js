const { Relationships } = require("./relationships");
const { Person } = require("./person");
const { Research } = require("./research");

let parent = new Person("Jefté");
let child1 = new Person("Brenno");
let child2 = new Person("Brunno");

let rels = new Relationships();
rels.addParentAndChild(parent, child1);
rels.addParentAndChild(parent, child2);

let res = new Research(rels);
