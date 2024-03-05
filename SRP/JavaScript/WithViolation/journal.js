const fs = require("fs");

class Journal {
  #count = 0;

  constructor() {
    this.entries = [];
  }

  addEntry(text) {
    let count = ++this.#count;
    let entry = `${count}: ${text}`;
    this.entries[count] = entry;
    return count;
  }

  removeEntry(index) {
    delete this.entries[index];
  }

  toString() {
    return Object.values(this.entries).join("\n");
  }

  saveToFile(filename) {
    fs.writeFileSync(filename, this.toString());
  }
}

module.exports.Journal = Journal;
