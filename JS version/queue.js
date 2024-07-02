class Queue {
    constructor() {
        this.items  = [];
        this.frontIndex = 0;
        this.backIndex = 0;
    }

    enequeue(item) {
        this.items[this.backIndex] = item;
        this.backIndex++;
        return item + " Inserted";
    }

    dequeue() {
        const item = this.items[this.frontIndex];
        delete this.items[this.frontIndex];
        this.frontIndex++;
        return item + " Deleted";






         
    }

    peek() {
        return this.items[this.frontIndex];
    }

    printQueue() {
        return this.items;
    }
}