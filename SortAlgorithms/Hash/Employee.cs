namespace SortAlgorithms.Hash
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private int _id;

        public Employee(string firstName, string lastName, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _id = id;
        }

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }
    }
}