const { Rectangle } = require("./rectangle");
const { Square } = require("./square");

let useIt = function (rc) {
  let width = rc._width;
  rc.height = 10;
  console.log(`Expected area of ${10 * width}, ` + `got ${rc.area}.`);
};

let rc = new Rectangle(2, 3);
useIt(rc);

let sq = new Square(5);
useIt(sq);
