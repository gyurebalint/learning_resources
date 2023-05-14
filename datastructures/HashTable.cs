//Dictionary implementation with two lists.
public class RadgaulHashTable
{
    private List<int> _keys;
    private List<int> _values;

    public RadgaulHashTable()
    {
        _keys = new List<int>();
        _values = new List<int>();
    }

    public void Put(int key, int value)
    {
        if(_keys.Contains(key))
        {
            var index = _keys.IndexOf(key);
            _values[index] = value;
            return;
        }

        _keys.Add(key);
        _values.Add(value);
    }

    public int Get(int key)
    {
        if(!_keys.Contains(key))return -1;

        return _values[_keys.IndexOf(key)];
    }

    public void Remove(int key)
    {
        if(!_keys.Contains(key)) return;

        var index = _keys.IndexOf(key);
        _keys.RemoveAt(index);
        _values.RemoveAt(index);
    }
}