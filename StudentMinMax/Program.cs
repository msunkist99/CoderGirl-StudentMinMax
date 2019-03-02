using System;
using System.IO;

namespace StudentMinMax
{
    public static class Program
    {
        public static void Main()
        {
            // read from the studentdata.txt file
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] studentsText = File.ReadAllLines(@"C:\Users\msunk\Documents\CoderGirlLC101\Lesson09 CoderGirl-StudentMinMax\CoderGirl-StudentMinMax\studentdata.txt");

            // create an array of Student classes from thestudentdata text
            Student[] students = new Student[studentsText.Length];

            for (int i = 0; i < studentsText.Length; i++)
            {
                {
                    string[] studentTextInputFields = studentsText[i].Split(" ");

                    Student student = new Student();
                    student.Name = studentTextInputFields[0];

                    int[] scores = new int[studentTextInputFields.Length - 1];

                    for (int j = 1; j < studentTextInputFields.Length; j++)
                    {
                        scores[j - 1] = int.Parse(studentTextInputFields[j]);
                        
                    }
                    student.Scores = scores;
                    students[i] = student;
                }
            }


            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} Min: {student.GetMinimumScore()} Max: {student.GetMaximumScore()}");
            }

            Console.ReadLine();
        }
    }
}