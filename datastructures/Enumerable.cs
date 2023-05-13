//"A 'Radgaul' is the epitome of a software engineer of the highest order, meaning they code blazingly fast."
using System.Collections;

public class Radgaul
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";

    public Radgaul(string lastName, string firstName)
    {
        LastName = lastName;
        FirstName = firstName;
    }
}

/*
This first implementation uses the IEnumarable interface that C# provides. With the Enumerator combined
you can foreach through the created custom list type we created.

If you are asked not to use anything from the standard library, they are usually want to know if you know
what functions would you implement and how would you implement them. Down in this file you can see
commented out code that has this implementation.
*/
public class PackOfRadgauls : IEnumerable
{
    private Radgaul[] _radgauls;
    public PackOfRadgauls(Radgaul[] inputArray)
    {
        _radgauls = new Radgaul[inputArray.Length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            _radgauls[i] = inputArray[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return (IEnumerator) GetEnumerator();
    }

    public RadgaulEnum GetEnumerator()
    {
        return new RadgaulEnum(_radgauls);
    }
}

public class RadgaulEnum : IEnumerator
{
    private Radgaul[] _radgauls;
    private int position = -1;
    public RadgaulEnum(Radgaul[] radgauls)
    {
        _radgauls = radgauls;
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public Radgaul Current
    {
        get
        {
            try
            {
                return _radgauls[position];
            }
            catch (IndexOutOfRangeException)
            {
                
                throw new InvalidOperationException();
            }
        }
    }

    public bool MoveNext()
    {
        position++;
        return (position < _radgauls.Length);
    }

    public void Reset()
    {
        position = -1;
    }
}

/*
public class FlockOfRadgauls
{
    private Radgaul[] _radgauls;
    private int position = -1;

    public FlockOfRadgauls(Radgaul[] multipleInput)
    {
        _radgauls = new Radgaul[multipleInput.Length];

        for (int i = 0; i < multipleInput.Length; i++)
        {
            _radgauls[i] = multipleInput[i];
        }
    }
    public Radgaul Current
    {
        get
        {
            try
            {
                return _radgauls[position];
            }
            catch (IndexOutOfRangeException)
            {
                
                throw new InvalidOperationException();
            }
        }
    }
    public bool MoveNext()
    {
        position++;
        return (position < _radgauls.Length);
    }

    public void Reset()
    {
        position = -1;
    }
}
*/