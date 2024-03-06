const { Product } = require("./product");
const { Color } = require("./color");
const { Size } = require("./size");
const { ProductFilter } = require("./product-filter");
const { BetterFilter } = require("./better-filter");
const { ColorSpecification } = require("./color-specification");
const { AndSpecification } = require("./and-specification");
const { SizeSpecification } = require("./size-specification");

let apple = new Product("Apple", Color.green, Size.small);
let tree = new Product("Tree", Color.green, Size.large);
let house = new Product("House", Color.blue, Size.large);

let products = [apple, tree, house];

let pf = new ProductFilter();
console.log(`Green products (old):`);
for (let p of pf.filterByColor(products, Color.green))
  console.log(`*${p.name} is green.`);

let bf = new BetterFilter();
console.log(`Green products (new):`);
for (let p of bf.filter(products, new ColorSpecification(Color.green))) {
  console.log(`*${p.name} is green.`);
}

console.log(`Large and green products:`);
let spec = new AndSpecification(
  new ColorSpecification(Color.green),
  new SizeSpecification(Size.large)
);
for (let p of bf.filter(products, spec)) {
  console.log(`*${p.name} is large and green.`);
}
