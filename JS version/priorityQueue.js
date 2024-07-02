class QElement {
  constructor(element, priority) {
    this.element = element;
    this.priority = priority;
  }
}

class PriorityQueue {
  constructor() {
    this.items = [];
  }

  enqueue(element, priority) {
    let qElement = new QElement(element, priority);
    let contain = false;
    for (let i = 0; i < this.items.length; i++) {
      if (this.items[i].priority > qElement.priority) {
        this.items.splice(i, 0, qElement);
        contain = true;
        break;
      }
    }
    // if the element have the highest priority
    // it is added at the end of the queue
    if (!contain) {
      this.items.push(qElement);
    }
  }

  dequeue() {
    if (this.isEmpty()) {
      return "underflow";
    }
    return this.items.shift();
  }

  front() {
    if (this.isEmpty()) {
      return "underflow";
    }
    return this.items[0];
  }

  rear() {
    if (this.isEmpty()) {
      return "underflow";
    }
    return this.items[this.items.length - 1];
  }

  isEmpty() {
    // return true if the queue is empty.
    return this.items.length == 0;
  }

  printPQueue() {
    let str = "";
    for (let i = 0; i < this.items.length; i++)
      str += this.items[i].element + " ";
    return str;
  }
}
