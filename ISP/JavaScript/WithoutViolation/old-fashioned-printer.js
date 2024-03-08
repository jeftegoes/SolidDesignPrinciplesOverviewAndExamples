const { Machine } = require("./machine");

class OldFashionedPrinter extends Machine {
  print(doc) {
    // ok
  }

  fax(doc) {
    // do nothing
  }

  scan(doc) {
    throw new Error("Not implemented!");
  }
}

module.exports.OldFashionedPrinter = OldFashionedPrinter;
