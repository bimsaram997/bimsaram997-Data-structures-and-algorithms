// const stack = new Stack();
// stack.push(10);
// stack.push(20);
// stack.push(30);
// stack.push(40);
// stack.push(50);
// stack.push(60);
// stack.push(70);
// stack.pop();

// console.log("Peek: " + stack.peek());
// console.log("Stack: " + stack.display());
// console.log("Is Empty: " + stack.isEmpty());

// const queue = new Queue();
// console.log(queue.enequeue(10));
// console.log(queue.enequeue(20));
// console.log(queue.enequeue(30));
// console.log(queue.enequeue(40));
// console.log(queue.enequeue(50));
// console.log(queue.enequeue(60));
// console.log(queue.enequeue(70));
// console.log(queue.enequeue(80));
// console.log(queue.peek());
// console.log(queue.dequeue());
// console.log(queue.printQueue());


// const priorityQueue =  new PriorityQueue();
// console.log(priorityQueue.isEmpty());
// console.log(priorityQueue.front());
// priorityQueue.enqueue("Bimsara", 2);
// priorityQueue.enqueue("Janith", 1);
// priorityQueue.enqueue("Harsha", 1);
// priorityQueue.enqueue("Sineth", 2);
// priorityQueue.enqueue("Anuja", 3);

// console.log(priorityQueue.printPQueue());
// console.log(priorityQueue.front().element);
// console.log(priorityQueue.rear().element);
// console.log(priorityQueue.dequeue().element);
// console.log(priorityQueue.printPQueue());
// priorityQueue.enqueue("Sunil", 2);
// console.log(priorityQueue.printPQueue());

// const list = new LinkedList();
// list.addNode(1);
// listlist.printLinedList();.addNode(2);
// list.addNode(3);
// list.addNode(4);
// list.addNode(5);
// //list.printLinedList();
// list.insertAt(1,0);


//Dyanamic array

const array =  new DynamicArray(5);
array.add("A");
array.add("B");
array.add("C");
array.add("D");
array.add("E");
array.add("F");
//array.insert(0, "X");


//array.delete("A");
console.log(array.toString());
console.log("Index is  : " +array.search("B")); 
console.log("Cpacity " + array.capacity);
console.log("Size " + array.size);
console.log(array.isEmpty());