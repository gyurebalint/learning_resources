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

Console.WriteLine("Datastructures OFF");