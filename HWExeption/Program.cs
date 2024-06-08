namespace HWExeption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { -5, 0, -10, -15, -20 };

            try
            {
                double average = GetAverageOfPositiveNumbers(numbers);
                Console.WriteLine($"Среднее арифметическое положительных чисел: {average}");
            }
            catch (NoPositiveNumbersException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            ContactsManager contactsManager = new ContactsManager();

            try
            {
                contactsManager.AddContact("John Doe", "123456789");
                contactsManager.AddContact("Jane Smith", "987654321");
                contactsManager.AddContact("", "456789123");
            }
            catch (InvalidContactException ex)
            {
                Console.WriteLine(ex.Message);
            }

            List<Contact> contacts = contactsManager.FindContactByName("John Doe");
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Name: {contact.Name}, Phone Number: {contact.PhoneNumber}");
            }
        }

        public static double GetAverageOfPositiveNumbers(List<int> numbers)
        {
            if (!numbers.Any(x => x > 0))
                throw new NoPositiveNumbersException();

            double sum = numbers.Where(x => x > 0).Sum();
            int count = numbers.Count(x => x > 0);
            return sum / count;
        }
    }
}
