public class Resume

{

    // Attributess

    public string _name = "";

    public List<Job> _jobs = new List<Job>();

    // Method

    public void DisplayResume()

    {

        Console.WriteLine($"Name: {_name}");

        Console.WriteLine();

        Console.WriteLine("Jobs:");

        Console.WriteLine("");

        foreach (Job job in _jobs)

        {

            job.DisplayJobDetails();

            Console.WriteLine();

        }

    }

}