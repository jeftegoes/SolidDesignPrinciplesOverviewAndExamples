class BetterFilter {
  filter(items, spec) {
    return items.filter((x) => spec.isSatisfied(x));
  }
}

module.exports.BetterFilter = BetterFilter;
