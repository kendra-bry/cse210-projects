using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new()
        {
            _company = "Adobe",
            _jobTitle = "Jr. Software Engineer",
            _startYear = 2015,
            _endYear = 2017
        };

        Job job2 = new()
        {
            _company = "Entrata",
            _jobTitle = "Software Engineer",
            _startYear = 2017,
            _endYear = 2019
        };

        Resume resume = new()
        {
            _name = "Kenda Bryant",
            _jobs = new List<Job>
            {
                job1,
                job2
            }
        };

        resume.Display();
    }



}