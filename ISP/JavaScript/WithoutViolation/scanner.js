class Scanner {
  constructor() {
    if (this.constructor.name === "Scanner")
      throw new Error("Scanner is abstract");
  }
  scan() {}
}

module.exports.Scanner = Scanner;
