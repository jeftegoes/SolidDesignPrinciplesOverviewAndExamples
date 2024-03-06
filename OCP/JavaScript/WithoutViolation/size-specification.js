class SizeSpecification {
  constructor(color) {
    this.color = color;
  }

  isSatisfied(item) {
    return item.size === this.size;
  }
}

module.exports.SizeSpecification = SizeSpecification;
