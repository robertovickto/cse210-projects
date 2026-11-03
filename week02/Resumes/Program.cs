using System;
using System.Threading.Tasks.Dataflow;

class Program

{

    static void Main(string[] args)

    {

        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job firstJob = new Job();

        {

            firstJob._company = "Doctors on Call";

            firstJob._jobTitle = "Medical Laboratory Technician";

            firstJob._startYear = 2022;

            firstJob._endYear = 2022;

        }

        Job secondJob = new Job();

        {

            secondJob._company = "Multi-Solutions Diagnostics Ltd";

            secondJob._jobTitle = "Medical Laboratory Technician";

            secondJob._startYear = 2022;

            secondJob._endYear = 2023;

        }

        Job thridJob = new Job();

        {

            thridJob._company = "Guards Brigade Medicall Center";

            thridJob._jobTitle = "Medical Laboratory Technician";

            thridJob._startYear = 2023;

            thridJob._endYear = 2025;

        }

        Job fourthJob = new Job();

        {

            fourthJob._company = "Elvion Couture";

            fourthJob._jobTitle = "Apprentice";

            fourthJob._startYear = 2025;

            fourthJob._endYear = 2026;

        }

        Job fifthJob = new Job();

        {

            fifthJob._company = "BYU-Parhway Wolrdwide";

            fifthJob._jobTitle = "Software Developer";

            fifthJob._startYear = 2026;

            fifthJob._endYear = 2028;

        }

        Resume robertoVickto = new Resume();

        Console.WriteLine("");

        robertoVickto._name = "Roberto Vickto";

        robertoVickto._jobs.Add(firstJob);

        robertoVickto._jobs.Add(secondJob);

        robertoVickto._jobs.Add(thridJob);

        robertoVickto._jobs.Add(fourthJob);

        robertoVickto._jobs.Add(fifthJob);

        robertoVickto.DisplayResume();

    }

}