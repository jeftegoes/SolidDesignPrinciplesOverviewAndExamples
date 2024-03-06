const { Product } = require("./product");
const { Color } = require("./color");
const { Size } = require("./size");
const { ProductFilter } = require("./product-filter");

let apple = new Product("Apple", Color.green, Size.small);
let tree = new Product("Tree", Color.green, Size.large);
let house = new Product("House", Color.blue, Size.large);

let products = [apple, tree, house];

let pf = new ProductFilter();
console.log(`Green products (old):`);
for (let p of pf.filterByColor(products, Color.green))
    console.log(`*${p.name} is green.`);
