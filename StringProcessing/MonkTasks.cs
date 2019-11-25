using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProcessing
{
    public class MonkTasks
    {
        public MonkTasks()
        {   
        }
        
        private int _tests;//Number of tests in testcase

        public int Tests
        {
            get { return _tests; }
            set { _tests = value; }
        }
        private int numDays;

        public int NumDays
        {
            get { return numDays; }
            set { numDays = value; }
        }
        private int [] _tasks;  

        public int [] Tasks    
        {
            get { return  _tasks; }
            set {  _tasks = value; }
        }

        static void Main (string [] args)
        {
            MonkTasks mT = new MonkTasks();
            string tasks = "3 4 7 10";
            int [] tasksPerDay = mT.NonDecreasingTaskList(4, tasks);
            foreach (var item in tasksPerDay)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        public int [] NonDecreasingTaskList(int nDays, string numTasks)
        {
            //int.TryParse(Console.ReadLine(), out int value);
            //int numTests = value;
            //int.TryParse(Console.ReadLine(), out value);
            //int numDays = value;
            string [] tasks = numTasks.Split(' ');
            Dictionary<int, int> mapping = new Dictionary<int, int>();
            int[] inputArray = new int[nDays];

            //for (int i = 0; i < nDays; i++)
            //{
            //    char.TryParse(tasks[i], out char result);
            //    inputArray[i] = result - '0';
            //}
            for (int i = 0; i < nDays; i++) {
                if (!int.TryParse(tasks[i], out int result)){
                    Console.WriteLine("There was a problem parsing the input string");
                }
                inputArray[i] = result;
            }

            int[] outputArray = new int[nDays];

            for (int j = 0; j < nDays; j++)
            {
                //Calculate the binary value of each value in inputArray
                //arrange the array in nondecreasing order
                int counter = 0;
                int temp = inputArray[j];
                while (inputArray[j] != 0)
                {
                    inputArray[j] = inputArray[j] & (inputArray[j] - 1);
                    counter++;
                }
                //Dictionary of <key, value> pairs 
                mapping.Add(temp, counter);
                //outputArray[j] = counter;
            }
            var dict = mapping.OrderByDescending(pair => pair.Value).ToArray();
            var dict2 = mapping.OrderBy(pair => pair.Value).ToArray();
            //int[] keys = infos.Where(kvp => kvp.Value == "Sur").Select(kvp => kvp.Key).ToArray();
            outputArray = dict2.Select(kvp => kvp.Key).ToArray();
            return outputArray;
        }
    }
}
