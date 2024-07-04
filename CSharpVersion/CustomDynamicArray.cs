using NPOI.HSSF.Record.Chart;
using NPOI.OpenXmlFormats.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpVersion
{
    public class CustomDynamicArray
    {
        int size;
        int capacity;
        Object[] array;

        public CustomDynamicArray(int initialCapacity = 10)
        {
            size = 0;
            capacity = initialCapacity;
            array = new object[capacity];
        }

        public void add(Object data)
        {
            if(size >= capacity)
            {
                grow();

            }
            this.array[size] = data;
            this.size++;
        }


        public bool isEmpty()
        {
            return this.size == 0;
        }

        public string toString()
        {
           
            string stringCode = "";
            for (int i = 0; i < this.size; i++)
            {
                stringCode += this.array[i] + ",";
            }

            if (stringCode != "")
            {
                stringCode = "[" + stringCode.Substring(0, stringCode.Length - 1) + "]";
            }
            else
            {
                stringCode = "[]";
            }
            return stringCode;
        }

        public void inserAt(int index, Object data)
        {
            if (index < 0 || index > this.size)
            {
                throw new Exception("Index out of bounds");

            }
            if (size >= capacity)
            {
                grow();

            }
            for( int i =this.size; i > index; i-- )
            {
                this.array[i] = this.array[i - 1];
            }
            this.array[index] =  data;
            this.size++;
        }

        public void delete(Object data)
        {
            for (int i = 0; i < this.size; i++)
            {
                if (this.array[i] == data)
                {
                    for(int j = 0; j <(this.size - j -1); j++)
                    {
                        this.array[i + j] = this.array[i + j + 1];
                    }
                }
                this.array[this.size - 1] = null;
                this.size--;
                if (this.size <= (this.capacity / 3))
                {
                    shrink();
                }
            }
        }

        public int search(Object data)
        {
            for(int i =0; i < this.size; i++)
            {
                if (this.array[i] == data)
                {
                    return i;
                }
              
            }
            return -1;
        }
        public void grow()
        {
            int newCapacity = this.capacity * 2;
            Object[] newArray = new Object[newCapacity];
            this.capacity= newCapacity;
            Array.Copy(this.array, newArray, this.size);
            this.array = newArray;
        }

        public void shrink()
        {

        }
    }
}
