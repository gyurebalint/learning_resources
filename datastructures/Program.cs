Console.WriteLine("Datastructures ON");

#region Enumerable
Console.WriteLine("ENUMERABLE START-----------------------------");
Radgaul[] aweSomeProgrammersLikeYou = new Radgaul[2]
{
    new Radgaul("gyure", "balint"),
    new Radgaul("YouAre", "Awesome"),
};

PackOfRadgauls awesomes = new PackOfRadgauls(aweSomeProgrammersLikeYou);
foreach (var aweSomeProgrammes in awesomes)
{
    Console.WriteLine(aweSomeProgrammes.FirstName);
    Console.WriteLine(aweSomeProgrammes.LastName);
}
Console.WriteLine("ENUMERABLE END-----------------------------\n");
#endregion

Console.WriteLine("HASHSET START-----------------------------");
#region HashSet
RadgaulHashSet myHashSet = new RadgaulHashSet();
myHashSet.Add(1);                           // set = [1]
myHashSet.Add(2);                           // set = [1, 2]
Console.WriteLine(myHashSet.Contains(1));   // return True
Console.WriteLine(myHashSet.Contains(3));   // return False, (not found)
myHashSet.Add(2);                           // set = [1, 2]
Console.WriteLine(myHashSet.Contains(2));   // return True
myHashSet.Remove(2);                        // set = [1]
Console.WriteLine(myHashSet.Contains(2));   // return False, (already removed)
Console.WriteLine("HASHSET END-----------------------------\n");
#endregion


Console.WriteLine("HASHTABLE START-----------------------------");
#region HashTable
RadgaulHashTable myHashMap = new();
myHashMap.Put(1, 1); // The map is now [[1,1]]
myHashMap.Put(2, 2); // The map is now [[1,1], [2,2]]
Console.WriteLine(myHashMap.Get(1));    // return 1, The map is now [[1,1], [2,2]]
Console.WriteLine(myHashMap.Get(3));    // return -1 (i.e., not found), The map is now [[1,1], [2,2]]
myHashMap.Put(2, 1); // The map is now [[1,1], [2,1]] (i.e., update the existing value)
Console.WriteLine(myHashMap.Get(2));    // return 1, The map is now [[1,1], [2,1]]
myHashMap.Remove(2); // remove the mapping for 2, The map is now [[1,1]]
Console.WriteLine(myHashMap.Get(2));    // return -1 (i.e., not found), The map is now [[1,1]]
Console.WriteLine("HASHTABLE END-----------------------------\n");
#endregion


Console.WriteLine("STACK START-----------------------------");
RadgaulStack stk = new RadgaulStack(3); // Stack is Empty []
stk.Push(1);                            // stack becomes [1]
stk.Push(2);                            // stack becomes [1, 2]
Console.WriteLine(stk.Pop());           // return 2 --> Return top of the stack 2, stack becomes [1]
stk.Push(2);                            // stack becomes [1, 2]
stk.Push(3);                            // stack becomes [1, 2, 3]
stk.Push(4);                            // stack still [1, 2, 3], Do not add another elements as size is 4
stk.Increment(5, 100);                  // stack becomes [101, 102, 103]
stk.Increment(2, 100);                  // stack becomes [201, 202, 103]
Console.WriteLine(stk.Pop());           // return 103 --> Return top of the stack 103, stack becomes [201, 202]
Console.WriteLine(stk.Pop());           // return 202 --> Return top of the stack 202, stack becomes [201]
Console.WriteLine(stk.Pop());           // return 201 --> Return top of the stack 201, stack becomes []
Console.WriteLine(stk.Pop());           // return -1 --> Stack is empty return -1.
Console.WriteLine("STACK END-----------------------------\n");

Console.WriteLine("Datastructures OFF");