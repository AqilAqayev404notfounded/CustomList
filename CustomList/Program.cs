using CustomList;

CustomList<int> customList = new CustomList<int>();
customList.Add(1);
customList.Add(2);
customList.Add(3);
customList.Add(4);
customList.Add(5);
customList.Remove(4);
foreach (int x in customList)
{
    Console.WriteLine(x);
}
Console.WriteLine("===========================");
List<int> list = new List<int>();
list.Add(1);
list.Add(2);
list.Add(3);

list.Add(4);
list.Add(5);
foreach (int x in list)
{
    Console.WriteLine(x);
}
foreach (var item in list.FindAll(x => x == 5))
{
    Console.WriteLine(item);
}