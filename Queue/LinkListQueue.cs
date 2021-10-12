using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    /// <summary>
    /// Queue means first in First out
    ///  Enqueue Adds an item to the queue. If the queue is full, 
    ///  then it is said to be an Overflow condition. 
    /// </summary>

    class LinkListQueue
    {
        Node head;
        /// <summary>
        /// Enqueues the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        
        public void Enqueue(int item)
        {
            Node new_node = new Node(item);
            if (this.head==null) //creating instance 
            {
                this.head = new_node; //if null then new node will assign for ex (56) will assign here
            }
            else
            {
                Node temp = this.head;
                while(temp.next !=null) //if temp is not equal to null then it will go to the next node
                {
                    temp = temp.next;
                }
                temp.next = new_node; //assigning new node for ex (30) will assign then after (70) will assign
            }
            Console.WriteLine("Inserted into list" + new_node.data); 

        }

        /// <summary>
        ///  Removes an item from the queue. The items are popped in the same order in which they are pushed. 
        ///  If the queue is empty, 
        ///  then it is said to be an Underflow condition. 
        /// </summary>
        public void Dequeue()
        {
            //if queue is empty then return null
            if (this.head==null)
            {
                Console.WriteLine("The Queue is Empty"); 
                return;
            }
            //store previous head and move head pointer one step ahead to delete the current element
            Node temp = this.head;
            this.head = this.head.next;
            Console.WriteLine("Item deleted is {0}", temp.data);

        }

        /// <summary>
        /// displaying the instance.
        /// </summary>
        public void display()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            else
            {
                while(temp!=null)
                {
                    Console.WriteLine(" " + temp.data);
                    temp = temp.next;
                }
            }
        }
        


    }
}
