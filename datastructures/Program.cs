Console.WriteLine("Datastructures ON");

#region Enumerable
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
#endregion

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
#endregion

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
#endregion


Console.WriteLine("Datastructures OFF");