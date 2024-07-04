class DynamicArray {

     constructor(capacity = 10) {
        this.size = 0; // Initialize size to 0
        this.capacity = capacity; // Set the capacity to the provided value or default to 10
        this.array = new Array(this.capacity); // Initialize the array with the given capacity
    }

    add(data) {
        if (this.size >= this.capacity) {
            this.grow();
        }
        this.array[this.size] = data; 
        this.size++;
    }

    insert(index, data) {
        if (index < 0 || index > this.size) {
            throw new RangeError('Index out of bounds');
        }

        if (this.size >= this.capacity) {
            this.grow();
        }

        for (let i = this.size; i > index; i--) {
            this.array[i] = this.array[i - 1];
        }
        this.array[index] = data;
        this.size++;
    }

    delete(data) {
        for(let i = 0; i < this.size; i++) {
            if(this.array[i] === data) {
                for(let j = 0; j < (this.size - j - 1); j++) {
                    this.array[i+j] = this.array[i+j+1];
            }
            this.array[this.size -1] = null
            this.size--;
            if(this.size <= (this.capacity/3)){
                this.shrink();
            }
        }
        }
    }

    search(data) {
        for(let i=0; i<this.size; i++) {
            if(this.array[i] == data) {
                return i;
            }
        }
        return -1;
    }

    grow() {
        var newCpacity = this.capacity *2;
        this.newArray = new Array(newCpacity);
        this.capacity = this.newCpacity;
        this.array = [...this.array, ...this.newArray]
    }

    shrink(){
        var newCpacity = this.capacity /2;
        this.newArray = new Array(newCpacity);
        this.capacity = this.newCpacity;
        this.array = [...this.array, ...this.newArray]
    }

    isEmpty() {
        return this.size == 0
    }

    toString() {
        let string = "";
        for (let i = 0; i < this.size; i++) {
            string += this.array[i] + ",";
        }

        if (string !== "") {
            string = "[" + string.substring(0, string.length - 1) + "]";
        } else {
            string = "[]";
        }
        return string;
    }

}