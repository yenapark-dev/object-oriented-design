using System;
namespace JobDemo
{
    public class Job
    {
        //constructor
        public Job(int jobNumber, string customerName, string jobDescription,
                   double estimatedHours)
        {
            this.JobNumber = jobNumber;
            this.CustomerName = customerName;
            this.JobDescription = jobDescription;
            this.EstimatedHours = estimatedHours;

        }

        public int JobNumber { get; set; }
        public string CustomerName { get; set; }
        public string JobDescription { get; set; }
        public double EstimatedHours
        {
            get { return hours; }
            set
            {
                cost = value * COST_PER_HOUR;
                hours = value;
            }
        }

        private const double COST_PER_HOUR = 45.0;
        private double cost;
        private double hours;

        public double Cost
        {
            get
            {
                return cost;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Job))
                    return false;

            bool sameJobNumber = ((Job)obj).JobNumber == this.JobNumber;
            return sameJobNumber;
        }

        public override int GetHashCode()
        {
            return JobNumber;
        }

        public override string ToString()
        {
            return string.Format("Number={0} Name={1} Desc={2} Hours={3} Cost={4}",
                JobNumber, CustomerName, JobDescription, EstimatedHours, Cost);
        }
    }
}
