namespace StudentHub
{
    internal class Student
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public Student() { }
        public Student(string studentId, string studentName, int age, string course)
        {
            StudentId = studentId;
            StudentName = studentName;
            Age = age;
            Course = course;
        }
    }
}