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
            Console.WriteLine(list[1].ToString());
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
