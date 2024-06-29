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