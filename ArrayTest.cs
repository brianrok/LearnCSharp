using System;
namespace Learn
{
    public class ArrayTest
    {
        public ArrayTest()
        {
        }

        public static void MyMain() {
            int[] intArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine("The array has {0} dimensions", intArray.Rank);
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
            string[] week = { "mon", "tue", "wed", "thu", "fir", "sat", "sun" };
            ArrayTest[] array = new ArrayTest[10];
            foreach(ArrayTest test in array) {
                Console.WriteLine(test == null);
            }

            int[,,] array3D = { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };
            Console.WriteLine(array3D.Length);
            Console.WriteLine(array3D.GetLength(0));
            Console.WriteLine(array3D.GetLength(1));
            Console.WriteLine(array3D.GetLength(2));

            int[] newArray;
            FillArray(out newArray);
            foreach(int value in newArray) {
                Console.WriteLine(value);
            }

            int[] refArray = null;
            FillArray2(ref refArray);
            foreach (int value in refArray)
			{
				Console.WriteLine(value);
			}

            var varArray = new[] {1, 2, 3 };
            foreach(int value in varArray) {
                Console.WriteLine(value);
            }

            var contact = new[] {
                new {
                    Name = "test",
                    Phone = "test"
                },
                new {
                    Name = "test2",
                    Phone = "test2"
                }
            };
            foreach(var c in contact) {
                Console.WriteLine(c.Name);
            }
        }

        public static void FillArray(out int[] array) {
            array = new int[] {1, 2, 3 };
        }

        public static void FillArray2(ref int[] array) {
            if (array == null)
            {
                array = new int[5];
            }
            array[0] = 1000;
        }
    }
}
