namespace G_ASP_NET_75_ADV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    #region Exercise 1 - Student Grade Manager

            //    List<int> grades = new List<int>
            //{
            //    85, 92, 78, 95, 88, 70, 100, 65
            //};

            //    Console.WriteLine("Exercise 1 - Student Grade Manager");

            //    Console.WriteLine("Grades: " + string.Join(", ", grades));
            //    Console.WriteLine("Count: " + grades.Count);
            //    Console.WriteLine("First Grade: " + grades.First());
            //    Console.WriteLine("Last Grade: " + grades.Last());

            //    grades.Sort();

            //    Console.WriteLine("Sorted Grades: " + string.Join(", ", grades));

            //    int firstAbove90 = grades.First(g => g > 90);
            //    Console.WriteLine("First Grade Above 90: " + firstAbove90);

            //    List<int> failingGrades = grades.Where(g => g < 75).ToList();
            //    Console.WriteLine("Failing Grades: " + string.Join(", ", failingGrades));

            //    grades.RemoveAll(g => g < 75);
            //    Console.WriteLine("After Removing Failing Grades: " + string.Join(", ", grades));

            //    bool has100 = grades.Any(g => g == 100);
            //    Console.WriteLine("Any Grade Equals 100: " + has100);

            //    List<string> gradeMessages = grades
            //        .Select(g => "Grade: " + g)
            //        .ToList();

            //    Console.WriteLine("Grade Messages:");

            //    foreach (string grade in gradeMessages)
            //    {
            //        Console.WriteLine(grade);
            //    }

            //    #endregion

            #region Exercise 2 - Leaderboard

            //SortedDictionary<int, string> leaderboard =
            //    new SortedDictionary<int, string>();

            //leaderboard.Add(500, "Ahmed");
            //leaderboard.Add(200, "Sara");
            //leaderboard.Add(800, "Ali");
            //leaderboard.Add(350, "Mona");

            //Console.WriteLine("\nExercise 2 - Leaderboard");

            //Console.WriteLine("Leaderboard:");

            //foreach (var player in leaderboard)
            //{
            //    Console.WriteLine(player.Key + " = " + player.Value);
            //}

            //Console.WriteLine("First Key: " + leaderboard.First().Key);
            //Console.WriteLine("First Value: " + leaderboard.First().Value);

            //Console.WriteLine("Score 500 Exists: " + leaderboard.ContainsKey(500));

            //if (leaderboard.TryGetValue(999, out string playerName))
            //{
            //    Console.WriteLine("Player with score 999: " + playerName);
            //}
            //else
            //{
            //    Console.WriteLine("Player with score 999: Not Found");
            //}

            //leaderboard.Remove(200);

            //Console.WriteLine("After Removing Score 200:");

            //foreach (var player in leaderboard)
            //{
            //    Console.WriteLine(player.Key + " = " + player.Value);
            //}

            #endregion



            #region Exercise 3 - Phone Book

            //Dictionary<string, string> phoneBook =
            //    new Dictionary<string, string>();

            //phoneBook.Add("Ahmed", "01011111111");
            //phoneBook.Add("Sara", "01122222222");
            //phoneBook.Add("Ali", "01233333333");
            //phoneBook.Add("Mona", "01544444444");

            //Console.WriteLine("\nExercise 3 - Phone Book");

            //phoneBook["Omar"] = "01055555555";

            //try
            //{
            //    phoneBook.Add("Ahmed", "01099999999");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Add Error: " + ex.Message);
            //}

            //bool added = phoneBook.TryAdd("Ahmed", "01099999999");

            //Console.WriteLine("TryAdd succeeded: " + added);


            //bool exists = phoneBook.ContainsKey("Youssef");

            //Console.WriteLine("Youssef Exists: " + exists);

            //string phone = phoneBook.GetValueOrDefault("Youssef", "Not Found");

            //Console.WriteLine("Youssef Phone: " + phone);

            //Console.WriteLine("Keys:");
            //Console.WriteLine(string.Join(", ", phoneBook.Keys));

            //Console.WriteLine("Values:");
            //Console.WriteLine(string.Join(", ", phoneBook.Values));

            #endregion
            #region Exercise 4 - Unique Email Validator

            //    HashSet<string> emails =
            //        new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            //    emails.Add("ahmed@test.com");
            //    emails.Add("AHMED@test.com");
            //    emails.Add("@test.com");
            //    emails.Add("=@Test.Com");

            //    Console.WriteLine("\nExercise 4 - Unique Email Validator");

            //    Console.WriteLine("Email Count: " + emails.Count);

            //    Console.WriteLine(
            //        "AHMED@test.com and ahmed@test.com are treated as the same email."
            //    );

            //    Console.WriteLine(
            //        "Sara@test.com and Sara@Test.Com are treated as the same email."
            //    );

            //    HashSet<int> setA = new HashSet<int>
            //{
            //    1, 2, 3, 4, 5
            //};

            //    HashSet<int> setB = new HashSet<int>
            //{
            //    4, 5, 6, 7, 8
            //};

            //    HashSet<int> unionSet = new HashSet<int>(setA);
            //    unionSet.UnionWith(setB);

            //    Console.WriteLine("UnionWith: " + string.Join(", ", unionSet));

            //    HashSet<int> intersectSet = new HashSet<int>(setA);
            //    intersectSet.IntersectWith(setB);

            //    Console.WriteLine(
            //        "IntersectWith: " + string.Join(", ", intersectSet)
            //    );

            //    HashSet<int> exceptSet = new HashSet<int>(setA);
            //    exceptSet.ExceptWith(setB);

            //    Console.WriteLine(
            //        "ExceptWith: " + string.Join(", ", exceptSet)
            //    );

            //    HashSet<int> subset = new HashSet<int>
            //{
            //    1, 2
            //};

            //    Console.WriteLine(
            //        "{1,2} Is Subset Of Set A: " + subset.IsSubsetOf(setA)
            //    );

            #endregion

            #region Exercise 5 - Print Queue Simulator

            //Queue<string> printQueue = new Queue<string>();

            //printQueue.Enqueue("Report.pdf");
            //printQueue.Enqueue("Invoice.pdf");
            //printQueue.Enqueue("Letter.docx");
            //printQueue.Enqueue("Resume.pdf");
            //printQueue.Enqueue("Photo.jpg");

            //Console.WriteLine("\nExercise 5 - Print Queue Simulator");

            //Console.WriteLine("Queue:");
            //Console.WriteLine(string.Join(", ", printQueue));

            //Console.WriteLine("Count: " + printQueue.Count);

            //Console.WriteLine(
            //    "Next Document: " + printQueue.Peek()
            //);

            //Console.WriteLine("Processing Queue:");

            //while (printQueue.Count > 0)
            //{
            //    string document = printQueue.Dequeue();

            //    Console.WriteLine("Printing: " + document);
            //}

            //// TryDequeue on empty queue
            //if (printQueue.TryDequeue(out string nextDocument))
            //{
            //    Console.WriteLine("Printing: " + nextDocument);
            //}
            //else
            //{
            //    Console.WriteLine("TryDequeue: Queue is empty");
            //}

            #endregion



            #region Exercise 6 - Browser History

            Stack<string> browserHistory = new Stack<string>();

            browserHistory.Push("google.com");
            browserHistory.Push("github.com");
            browserHistory.Push("stackoverflow.com");
            browserHistory.Push("youtube.com");
            browserHistory.Push("claude.ai");

            Console.WriteLine("\nExercise 6 - Browser History");

            Console.WriteLine(
                "Current Page: " + browserHistory.Peek()
            );

            Console.WriteLine("Going Back:");

            for (int i = 0; i < 3; i++)
            {
                string page = browserHistory.Pop();

                Console.WriteLine("Left: " + page);
            }

            Console.WriteLine(
                "Current Page After Going Back: " + browserHistory.Peek()
            );

            // TryPop on empty stack
            while (browserHistory.Count > 0)
            {
                browserHistory.Pop();
            }

            if (browserHistory.TryPop(out string pageAfterEmpty))
            {
                Console.WriteLine("Page: " + pageAfterEmpty);
            }
            else
            {
                Console.WriteLine("TryPop: Stack is empty");
            }

            #endregion
        }

    }
}
