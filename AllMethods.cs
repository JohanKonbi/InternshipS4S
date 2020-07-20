using System;
using System.Text;
using System.IO;
using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace InternShipPipeline
{
    public class AllMethods
    {
        public static int hello;

        public static void StartCheck() //Prints the last date and time this file was activated, then immediately overwrites it.
        {
            if(File.Exists("TestData.txt"))
            {
                StreamReader streamReader = File.OpenText("TestData.txt");
                Console.WriteLine("Current Date: " + streamReader.ReadLine());
            }
            else
            {
                try
                {

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public static int Substract(int one, int two)
        {
            return one - two;
        }

        public struct Person
        {
            public string firstName;
            public string lastName;
            public string birthDate;
        }

        public static Person[] Initialize()
        {
            Person p1 = new Person(), p2 = new Person(), p3 = new Person(), p4 = new Person(), p5 = new Person();
            p1.firstName = "Abraham"; p1.lastName = "Ehmans"; p1.birthDate = "01/12/1954";
            p2.firstName = "Boris"; p2.lastName = "Dorn"; p2.birthDate = "01/12/1942";
            p3.firstName = "Christine"; p3.lastName = "Crohnbergen"; p3.birthDate = "05/12/1954";
            p4.firstName = "Dharwin"; p4.lastName = "Bucaresti"; p4.birthDate = "01/5/2000";
            p5.firstName = "Evelynn"; p5.lastName = "Amlitzer"; p5.birthDate = "01/5/1954";
            return new Person[] { p1, p2, p3, p4, p5 };
        }

        public static string[] OrderBy(int option)
        {
            Person[] array = Initialize();
            string[] sorted = new string[array.Length];
            switch(option)
            {
                case 0:
                    //Order By First Name
                    array = MergeSort(array, 0, array.Length - 1, CompareFirstName);
                    for(int i = 0; i < array.Length; i++)
                    {
                        sorted[i] = array[i].firstName;
                    }
                    return sorted;
                case 1:
                    //Order By Last Name
                    array = MergeSort(array, 0, array.Length - 1, CompareLastName);
                    for (int i = 0; i < array.Length; i++)
                    {
                        sorted[i] = array[i].firstName;
                    }
                    return sorted;
                default:
                    return sorted;
            }
        }
        #region MergeSort
        public static Person[] MergeSort(Person[] array, int head, int tail, Func<Person, Person, bool> compare)
        {
            if (head < tail)
            {
                Person[] start = new Person[tail - head];
                int middle = (head + tail) / 2;
                Person[] left = MergeSort(array, head, middle, compare);
                Person[] right = MergeSort(array, middle + 1, tail, compare);
                start = Merge(left, right, compare);
                return start;
            }
            Person[] oneElement = new Person[1];
            oneElement[0] = array[head];
            return oneElement;
        }

        public static Person[] Merge(Person[] left, Person[] right, Func<Person, Person, bool> compare)
        {
            Person[] mergedList = new Person[left.Length + right.Length];
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (compare(left[i], right[j]))
                {
                    if (left[i].firstName != null)
                    {
                        mergedList[k] = left[i];
                        k++;
                    }
                    i++;
                }
                else
                {
                    if (right[j].firstName != null)
                    {
                        mergedList[k] = right[j];
                        k++;
                    }
                    j++;
                }
            }
            for (; i < left.Length; i++)
            {
                mergedList[k] = left[i];
                k++;
            }
            for (; j < right.Length; j++)
            {
                mergedList[k] = right[j];
                k++;
            }
            return mergedList;
        }
        
        public static bool CompareFirstName(Person a, Person b)
        {
            int test = string.Compare(a.firstName, b.firstName);
            if (test == -1)
            {
                return true;
            }
            return false;
        }

        public static bool CompareLastName(Person a, Person b)
        {
            int test = string.Compare(a.lastName, b.lastName);
            if (test == -1)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
