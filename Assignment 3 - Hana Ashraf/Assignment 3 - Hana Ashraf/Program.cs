namespace Assignment_3___Hana_Ashraf
{
    struct StudentsData
    {
        public string Name;
        public string YearLevel;
        public double gradesAverage;
      
    }
    //struct Books
    //{
    //    public string title;
    //    public string author;
    //    public int publicationYear;
    //    public string genre;
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            double[] studentGrades = new double[5];
            string[] yearsLevel = { "fresh man", "sophomore", "junior", "senior" };
            
            Console.Write("please enter number of students\n");
            int size = Convert.ToInt32(Console.ReadLine());
            StudentsData[] studentsNumber = new StudentsData[size];

            for (int i = 0; i < studentsNumber.Length; i++)
            {
                Console.WriteLine($"please enter student Data\n student {i + 1} Name:");
                studentsNumber[i].Name = Console.ReadLine();


                Console.WriteLine($"student {i + 1} Year Level:");
                string enteredYearLevel;
                bool isContain = false;

                while (isContain == false)
                {
                    enteredYearLevel = Console.ReadLine();
                    for (int x = 0; x < yearsLevel.Length; x++)
                    {

                        if (enteredYearLevel == yearsLevel[x])
                        {
                            studentsNumber[i].YearLevel = enteredYearLevel;
                            isContain = true;
                            break;
                        }
                    }
                    if (isContain == false)
                    {
                        Console.WriteLine("Please enter one of these Year Levels");
                        Console.WriteLine(string.Join(", ", yearsLevel));
                    }
                }


                Console.WriteLine($"please enter courses grades for {i + 1} student");
                double gradesSum = 0;
                for (int c = 0; c < 5; c++)
                {
                    Console.WriteLine($"C{c + 1} is:");
                    studentGrades[c] = Convert.ToDouble(Console.ReadLine());
                    gradesSum += studentGrades[c];
                }
                studentsNumber[i].gradesAverage = gradesSum / 5;


               
                Console.WriteLine($"average grades for {studentsNumber[i].Name} is {studentsNumber[i].gradesAverage}");
                Console.WriteLine($"Student name is {studentsNumber[i].Name}\n");
                Console.WriteLine("student grades is ");


                for (int x = 0; x < 5; x++)
                {
                    Console.WriteLine ($"C{x+1}: {studentGrades[x]}");
                }
                Console.WriteLine($"Student Year Level is {studentsNumber[i].YearLevel}\n");
            }



            for (int x = 0; x < studentsNumber.Length; x++)
            {
                double largestAverage = 0;
                if (largestAverage < studentsNumber[x].gradesAverage)
                {
                    largestAverage = studentsNumber[x].gradesAverage;
                    Console.WriteLine($"the highest average grade is {largestAverage} and it's for {studentsNumber[x].Name} ");
                    break;
                }
            }

        }






























            //string[] booksGenre = { "Fiction", "NonFiction", "Mystery", "ScienceFiction", "Biography" };
            //string enteredGenre;

                //Books[] books = new Books[3];
                //bool isContains;

                //for (int i = 0; i < books.Length; i++)
                //{
                //    Console.WriteLine($"please enter number {i} book Data \nBook Title :\n");
                //    books[i].title = Console.ReadLine();
                //    Console.WriteLine("Book Author :");
                //    books[i].author = Console.ReadLine();
                //    Console.WriteLine("Book Publication Year :");
                //    books[i].publicationYear = Convert.ToInt32(Console.ReadLine());
                //    Console.WriteLine("Book Genre :");

                //bool isImpty = true;
                //while (isImpty == true)
                //{
                //    enteredGenre = Console.ReadLine();


                //    for (int j = 0; j < booksGenre.Length; j++)
                //    {

                //        if (enteredGenre == booksGenre[j])
                //        {
                //            books[i].genre = enteredGenre;
                //            isImpty = false;
                //            break;
                //        }
                //    }

                //    if (isImpty == true)
                //    {
                //        Console.WriteLine("Not valid please enter a valid genre\n");
                //        Console.WriteLine(String.Join(", ", booksGenre));
                //    }

                //}

                //    Console.WriteLine($"Data of {i} book is Title: {books[i].title} Author: {books[i].title} Publication Year: {books[i].title} Genre: {books[i].title}");
                //}
                //}









        
    }
}