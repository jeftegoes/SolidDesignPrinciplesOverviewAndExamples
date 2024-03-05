const fs = require("fs");

class Persistence {
  constructor(journal) {
    this.journal = journal;
  }

  saveToFile(filename) {
    fs.writeFileSync(filename, this.journal.toString());
  }
}

module.exports.Persistence = Persistence;
