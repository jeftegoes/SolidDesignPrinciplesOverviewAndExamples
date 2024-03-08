const { MultiFunctionPrinter } = require("./multi-function-printer");
const { OldFashionedPrinter } = require("./old-fashioned-printer");

let multiFunctionPrinter = new MultiFunctionPrinter();
multiFunctionPrinter.scan();

let oldFashionedPrinter = new OldFashionedPrinter();
oldFashionedPrinter.scan();
