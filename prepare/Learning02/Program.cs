using System;

class Program
{
    static void Main(string[] args)
    {
        // Created two instances or objects
        Job job1 = new Job();
        Job job2 = new Job();

        // Added values to each instance
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._endYear = 2010;
        job1._startYear = 2008;

        job2._company = "Microsoft";
        job2._jobTitle = "Accountant";
        job2._startYear = 2005;
        job2._endYear = 2009;

        // Created a resume instance
        Resume myResume = new Resume();
        myResume._name = "Pedro Garcia";
        // Added each job to the resume's list
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();

    }
}