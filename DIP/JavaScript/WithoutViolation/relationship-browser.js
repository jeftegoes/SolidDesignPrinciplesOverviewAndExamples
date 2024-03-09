class RelationshipBrowser {
  constructor() {
    if (this.constructor.name === "RelationshipBrowser")
      throw new Error("RelationshipBrowser is abstract!");
  }

  findAllChildrenOf(name) {}
}

module.exports.RelationshipBrowser = RelationshipBrowser;
