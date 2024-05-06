using System.Text;

namespace SingleResponsability
{
    public class StudentRepository
    {
        private static FakeStorage<Student> storage = new FakeStorage<Student>();

        public StudentRepository()
        {
            storage = new();
            InitData();
        }

        private void InitData()
        {
            storage.Add(new Student(1, "Jorge Martinez", new List<double>() { 3, 4.5 }));
            storage.Add(new Student(2, "Isaac Montiel", new List<double>() { 4, 5 }));
            storage.Add(new Student(3, "Cesar Olvera", new List<double>() { 2, 3 }));
        }

        public IEnumerable<Student> GetAll() 
        {
            return storage.GetAll();
        }
    }
}