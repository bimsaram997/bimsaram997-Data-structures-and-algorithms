class Node {
    constructor(data){
        this.data =  data;
        this.next =  null;
    }
}

class LinkedList {
    constructor(){
        this.head = null;
        this.tail = null;
    }

    addNode(data) {
        const node = new Node(data);
        if (this.head == null) {
            this.head = node;
        }else {
            this.tail.next = node;
        }
        this.tail = node;
    }

    printLinedList() {
        let current = this.head;
        while (current != null) {
            console.log(current.data);
            current = current.next;
        }
    }

    get(index) {
        let current = this.head;
        let i =0;
        while(i < index) {
            current = current.next;
            i++;
        }
        return current.data;

    }

    insertAt(index, data) { 
        if (index == 0){
            const node = new Node(data);
            node.next = this.head;
            this.head = node;
        }  else {
            let current =  this.head;
            let previous =  null;
            let i =0;
            while(i < index) {
                previous = current;
                current = current.next;
                i++;
            }
            const node = new Node(data);
            node.next = current;
            previous.next =  node;

        }
    }

    removeFrom(index) {
        if (index == 0){
            const node = new Node(data);
            node.next = this.head;
            this.head = node;
        }  else {
            let current =  this.head;
            let previous =  null;
            let i =o;
            while(i < index) {
                previous = current;
                current = current.next;
                i++;
            }
            
            return previous.next =  node;

        }
    }
}