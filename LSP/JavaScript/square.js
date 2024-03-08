const { Rectangle } = require("./rectangle");

class Square extends Rectangle {
  constructor(size) {
    super(size, size);
  }

  set width(value) {
    this._width = this._height = value;
  }

  set height(value) {
    this._width = this._height = value;
  }
}

module.exports.Square = Square;
