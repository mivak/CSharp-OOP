namespace CommonTypeSystem
{
    using System;

    public class CommonTypeSystemMain
    {
        public static void Main()
        {
            Person firstPerson = new Person("Ivan");
            Person secondPerson = new Person("Dobri", 29);

            Console.WriteLine(firstPerson.ToString());
            Console.WriteLine(secondPerson.ToString());

            BitArray64 arr = new BitArray64(5);
            arr.Add(18446744073709551615);
            arr.Add(204203);
            arr.Add(30494202);
            arr.Add(40494202);
            arr.Add(50494202);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            BitArray64 arr2 = new BitArray64(5);
            arr2.Add(20494202);
            arr2.Add(204203);
            arr2.Add(30494202);
            arr2.Add(40494202);
            arr2.Add(50494202);

            Console.WriteLine(arr.Equals(arr2));
            Console.WriteLine(arr.GetHashCode());

            arr2[0] = 1;
            Console.WriteLine("Check for equality: {0}", arr == arr2);
        }
    }
}