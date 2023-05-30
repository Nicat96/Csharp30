using TASK_1;

namespace P235
{
	class Program 
	{

		static void Main(string[] args) 
		{
            Console.Write("Engineer sayını daxil edin: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Engineer[] engineers = new Engineer[n];
            decimal totalSalary = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Engineer adı ve soyadı: ");
                string fullName = Console.ReadLine();
                Console.Write("Maaş: ");
                decimal salary = Convert.ToDecimal(Console.ReadLine());

                Engineer engineer = new Engineer();
                engineer.FullName = fullName;
                engineer.Salary = salary;

                engineers[i] = engineer;
                totalSalary += engineer.Salary;
            }

            decimal averageSalary = totalSalary / n;
            Console.WriteLine("Engineer-lerin maaş ortalaması: " + averageSalary);





        }



	}





}
