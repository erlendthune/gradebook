namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            Name = name;
            grades = new List<double>();
        }
        public void AddGrade(double grade) 
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;

            foreach(var number in grades)
            {
                result += number;
            }

            Console.WriteLine($"Average grade: {result / grades.Count}");
        }

        public void ComputeAverageGrade() 
        {

        }
        private List<double> grades;
        public string Name;
    }
}