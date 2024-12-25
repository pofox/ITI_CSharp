namespace ITI_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int,string> list = new SortedList<int,string>();
            list.Add(4, "four");
            list.Add(1, "one");
            list.Add(2, "two");
            list.Add(5, "five");
            list.Add(3, "three");
            PrintKeysAndValues(list);
            list.SetValueAtIndex(4, "V");
            PrintKeysAndValues(list);
            Console.WriteLine($"list contains key 3 : {list.ContainsKey(3)}");
            Console.WriteLine($"list capacity : {list.Capacity}");
            Console.WriteLine($"list count : {list.Count}");
            list.Remove(4);
            PrintKeysAndValues(list);
            Console.WriteLine($"list contains value \"five\" : {list.ContainsValue("five")}");
            list.RemoveAt(2);
            PrintKeysAndValues(list);
            Console.WriteLine($"index of key 1 : {list.IndexOfKey(1)}");
            Console.WriteLine($"index of value three : {list.IndexOfValue("three")}");
            list.Clear();
            PrintKeysAndValues(list);
        }
        public static void PrintKeysAndValues(SortedList<int,string> myList)
        {
            Console.WriteLine("\t-KEY-\t-VALUE-");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine("\t{0}:\t{1}", myList.GetKeyAtIndex(i), myList.GetValueAtIndex(i));
            }
            Console.WriteLine();
        }
    }
}
