using System;

namespace JobDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Job job1 = new Job(1, "Steve", "fix sink", 2);
            Job job2 = new Job(2, "Mark", "fix wall", 1);
            Job job3 = new Job(1, "Steve", "fix roof", 5);
            //Job job3 = job1;

            if (job1.Equals(job3))
               Console.WriteLine("job1 and job 3 are equal");
            else
                Console.WriteLine("job1 and job 3 are NOT equal");

            // == : reference equalitiy
            // unlike .Equals: same attributes
            if (job1 == job3)
                Console.WriteLine("job1 and job 3 are equal");
            else
                Console.WriteLine("job1 and job 3 are NOT equal");

            Console.WriteLine("job1 = " + job1.ToString());
        }

    }
}
