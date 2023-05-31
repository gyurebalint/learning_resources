/*Design your implementation of the circular double-ended queue (deque).

Implement the MyCircularDeque class:

    MyCircularDeque(int k) Initializes the deque with a maximum size of k.
    boolean insertFront() Adds an item at the front of Deque. Returns true if the operation is successful, or false otherwise.
    boolean insertLast() Adds an item at the rear of Deque. Returns true if the operation is successful, or false otherwise.
    boolean deleteFront() Deletes an item from the front of Deque. Returns true if the operation is successful, or false otherwise.
    boolean deleteLast() Deletes an item from the rear of Deque. Returns true if the operation is successful, or false otherwise.
    int getFront() Returns the front item from the Deque. Returns -1 if the deque is empty.
    int getRear() Returns the last item from Deque. Returns -1 if the deque is empty.
    boolean isEmpty() Returns true if the deque is empty, or false otherwise.
    boolean isFull() Returns true if the deque is full, or false otherwise.
*/

public class RadgaulCircularQueue
{
    private int size;
    private int head;
    private int tail;
    private int[] q;
    public RadgaulCircularQueue(int k)
    {
        q = new int[k];
        head = -1;
        tail = -1;
        size = k;
    }

    public bool InsertFront(int value)
    {
        if(IsFull())return false;
        if(IsEmpty())
        {
            head = 0;
            tail = (tail + 1) % size;
            q[tail] = value;
            return true;
        }

        if(head == 0) head = size - 1;
        else head = head - 1;
        q[head] = value;
        return true;
    }

    public bool InsertLast(int value)
    {
        if(IsFull())return false;
        if(IsEmpty())
        {
            head = 0;
        }

        tail = (tail + 1) % size;
        q[tail] = value;
        return true;
    }

    public bool DeleteFront()
    {
        if(IsEmpty())return false;
        if(head == tail)
        {
            head = -1;
            tail = -1;
        }
        else head = (head + 1) % size;
        return true;
    }

    public bool DeleteLast()
    {
        if(IsEmpty())return false;
        if(head == tail)
        {
            head = -1;
            tail = -1;
            return true;
        }
        if(tail == 0) tail = size;
        else tail = tail - 1;

        return true;
    }

    public int GetFront()
    {
        if(IsEmpty())return -1;
        return q[head];
    }
    public int GetLast()
    {
        if(IsEmpty())return -1;
        return q[tail];
    }

    public bool IsEmpty()
    {
        return head == -1;
    }
    public bool IsFull()
    {
        return (tail + 1) % size == head;
    }
}