const { Printer } = require("./printer");
const { Scanner } = require("./scanner");

class Photocopier {
  constructor() {
    if (this.constructor.name === "Photocopier")
      throw new Error("Photocopier is abstract");
  }

  print() {}
}

module.exports.Photocopier = Photocopier;
