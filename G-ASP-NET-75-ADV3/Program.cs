namespace G_ASP_NET_75_ADV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1 - Student Grade Manager

            List<int> grades = new List<int>
        {
            85, 92, 78, 95, 88, 70, 100, 65
        };

            Console.WriteLine("Exercise 1 - Student Grade Manager");

            Console.WriteLine("Grades: " + string.Join(", ", grades));
            Console.WriteLine("Count: " + grades.Count);
            Console.WriteLine("First Grade: " + grades.First());
            Console.WriteLine("Last Grade: " + grades.Last());

            grades.Sort();

            Console.WriteLine("Sorted Grades: " + string.Join(", ", grades));

            int firstAbove90 = grades.First(g => g > 90);
            Console.WriteLine("First Grade Above 90: " + firstAbove90);

            List<int> failingGrades = grades.Where(g => g < 75).ToList();
            Console.WriteLine("Failing Grades: " + string.Join(", ", failingGrades));

            grades.RemoveAll(g => g < 75);
            Console.WriteLine("After Removing Failing Grades: " + string.Join(", ", grades));

            bool has100 = grades.Any(g => g == 100);
            Console.WriteLine("Any Grade Equals 100: " + has100);

            List<string> gradeMessages = grades
                .Select(g => "Grade: " + g)
                .ToList();

            Console.WriteLine("Grade Messages:");

            foreach (string grade in gradeMessages)
            {
                Console.WriteLine(grade);
            }

            #endregion
        }
    }
}
