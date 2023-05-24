//Stack implementation using one array
public class RadgaulStack
{
    private int size;
    private int last;
    private int[] stack;

    public RadgaulStack(int maxSize)
    {
        size = maxSize;
        last = -1;
        stack = new int[maxSize];
    }

    public void Push(int val)
    {
        last++;
        if(last < size)
            {
                stack[last] = val;
            }
            else
            {
                last--;
            }
        
        return;
    }

    public int Pop()
    {
        if(last >= 0)
            return stack[last--];

        return -1;
    }

    public void Increment(int k, int val)
    {
        k = k > last + 1 ? last + 1 : k;

        for (int i = 0; i < k; i++)
        {
            stack[i] += val;
        }
        return;
    }

    public int Top()
    {
        if(last >= 0)
            return stack[last];
        return -1;
    }
}