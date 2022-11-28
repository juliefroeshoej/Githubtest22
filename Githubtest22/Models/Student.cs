namespace Githubtest22.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Student(string address)
        {
            Address = address;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
