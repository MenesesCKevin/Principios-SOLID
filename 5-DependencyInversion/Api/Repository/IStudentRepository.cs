namespace DependencyInversion
{
    public interface IStudentRepository
    {
        void InitData();
 
        IEnumerable<Student> GetAll();
 
        void Add(Student student);
    }
}