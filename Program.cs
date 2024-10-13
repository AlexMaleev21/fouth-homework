namespace dz4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Employee employee1 = new Employee(20000);
            Employee employee2 = new Employee(15000);
            int additionTask1 = 2000;
            Employee newEmployee1 = employee1 + additionTask1;
            Console.WriteLine(newEmployee1.Salary);
            Employee newEmployee2 = employee2 + additionTask1;
            Console.WriteLine(newEmployee2.Salary);
            Console.WriteLine(employee1 == employee2);
            Console.WriteLine(employee1 != employee2);
            Console.WriteLine(employee1 > employee2);
            Console.WriteLine(employee1 < employee2);
            Console.WriteLine(employee1.Equals(employee2));
            //Task 2
            City city1 = new City(50000);
            City city2 = new City(150000);
            int additionTask2 = 3500;
            City newCity1 = city1 + additionTask2;
            Console.WriteLine(newCity1.CitizenAmount);
            City newCity2 = city2 + additionTask2;
            Console.WriteLine(city1.CitizenAmount);
            Console.WriteLine(city1 == city2);
            Console.WriteLine(city1 != city2);
            Console.WriteLine(city1 > city2);
            Console.WriteLine(city1 < city2);
            Console.WriteLine(city1.Equals(city2));
            //Task 3
            CreditCard creditCard1 = new CreditCard(5000, 245);
            CreditCard creditCard2 = new CreditCard(5000, 245);
            int additionTask3 = 700;
            CreditCard newCreditCard1 = creditCard1 + additionTask3;
            Console.WriteLine(newCreditCard1.MoneyAmount);
            CreditCard newCreditCard2 = creditCard2 + additionTask3;
            Console.WriteLine(newCreditCard2.MoneyAmount);
            Console.WriteLine(creditCard1 == creditCard2);
            Console.WriteLine(creditCard1 != creditCard2);
            Console.WriteLine(creditCard1 > creditCard2);
            Console.WriteLine(creditCard1 < creditCard2);
            Console.WriteLine(creditCard1.Equals(creditCard2));
        }
    }
}
