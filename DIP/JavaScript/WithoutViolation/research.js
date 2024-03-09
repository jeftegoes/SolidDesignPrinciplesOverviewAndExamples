const { Relationship } = require("./relationship");

class Research {
  // constructor(relationships) {
  //   let relations = relationships.data;
  //   for (let rel of relations.filter(
  //     (r) => r.from.name === "Jefté" && r.type == Relationship.parent
  //   )) {
  //     console.log(`Jefté has a child named ${rel.to.name}`);
  //   }
  // }

  constructor(browser) {
    for (let p of browser.findAllChildrenOf("Jefté")) {
      console.log(`Jefté has a child named ${p.name}`);
    }
  }
}

module.exports.Research = Research;
