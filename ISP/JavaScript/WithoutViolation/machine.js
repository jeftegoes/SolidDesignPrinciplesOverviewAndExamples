class Machine {
  constructor() {
    if (this.constructor.name === "Machine")
      throw new Error("Machine is abstract");
  }

  print(doc) {}
  fax(doc) {}
  scan(doc) {}
}

module.exports.Machine = Machine;
