/*
This is HashSet<int> because it expects an integer type as key
This would be different if the input was a string type. What would change is the GetHAshCode() funciton
It would need to change so that I can generate an integer from the string key input.

Again if it would expect a T type as input, all I would chamge is the GetHashCode(T input) function,
so that I would somehow generate an integer from a property of T. Such as T.Age or sth like that.
*/
public class RadgaulHashSet
{
    private int bucketSize = 50;
    //This is an array of List<int>
    private List<int>[] _buckets;

    public RadgaulHashSet()
    {
        _buckets = new List<int>[bucketSize];

        for (int i = 0; i < _buckets.Length; i++)
        {
            _buckets[i] = new List<int>();
        }
    }

    private int GetHashCode(int key)
    {
        return key % bucketSize;
    }

    public void Add(int key)
    {
        var hashCode = GetHashCode(key);

        if (!_buckets[key].Contains(key))
            _buckets[key].Add(key);
    }

    public void Remove(int key)
    {
        var hashCode = GetHashCode(key);

        if (_buckets[key].Contains(key))
            _buckets[key].Remove(key);
    }

    public bool Contains(int key)
    {
        var hashCode = GetHashCode(key);

        if (_buckets[key].Contains(key))
            return true;

        return false;
    }
}