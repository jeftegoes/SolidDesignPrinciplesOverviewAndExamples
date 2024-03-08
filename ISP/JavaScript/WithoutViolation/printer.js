class Printer {
  constructor() {
    if (this.constructor.name === "Printer")
      throw new Error("Printer is abstract");
  }
  scan() {}
}

module.exports.Printer = Printer;
