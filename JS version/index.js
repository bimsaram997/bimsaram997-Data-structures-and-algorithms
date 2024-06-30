const stack = new Stack();
stack.push(10);
stack.push(20);
stack.push(30);
stack.push(40);
stack.push(50);
stack.push(60);
stack.push(70);
stack.pop();

console.log("Peek: " + stack.peek());
console.log("Stack: " + stack.display());
console.log("Is Empty: " + stack.isEmpty());

const queue = new Queue();
console.log(queue.enequeue(10));
console.log(queue.enequeue(20));
console.log(queue.enequeue(30));
console.log(queue.enequeue(40));
console.log(queue.enequeue(50));
console.log(queue.enequeue(60));
console.log(queue.enequeue(70));
console.log(queue.enequeue(80));
console.log(queue.peek());
console.log(queue.dequeue());
console.log(queue.printQueue());






