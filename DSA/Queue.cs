namespace DSA;

class Queue
{
    public int[] queue;
    public int size;
    public int front;
    public int rear;

    void Enqueue(int value)
    {
        if (rear == size - 1)
        {
            Console.WriteLine("Overflow");
        }
        else
        {
            if (front == -1)
            {
                front = 0;
            }

            rear++;
            queue[rear] = value;
            Console.WriteLine("Enqueued: "+ value);
        }
    }

    void Dequeue()
    {
        if (front == -1 || front > rear)
        {
            Console.WriteLine("Queue underflow");
        }
        else if(front > rear)
        {
            front = -1;
            rear = -1;
        }
        else
        {
            int removed = queue[front];
            front++;
            Console.WriteLine("Dequeued: "+removed);
        }
    }

    void peek()
    {
        if (front == -1 || front > rear)
        {
            Console.WriteLine("Queue is Empty");
        }
        else
        {
            Console.WriteLine(queue[front]);
        }
    }

    public static void Main()
    {
        Queue q1 = new Queue();
        q1.size = 5;
        q1.queue = new int[q1.size];
        q1.front = -1;
        q1.rear = -1;
        
        q1.Enqueue(10);
        q1.Enqueue(20);
        q1.Enqueue(30);
        q1.Dequeue();
        q1.Dequeue();
        q1.peek();
        Console.WriteLine("Queue is Created");
    }
}
