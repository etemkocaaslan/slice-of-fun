namespace SliceOfFun
{
    abstract class Person
    {
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? Gender { get; set; }
        public string? Nationality { get; set; }
        public bool? IsCitizen { get; set; }
        public bool? IsEmployee { get; private set; }

        public Person(bool? isEmployee)
        {
            IsEmployee = isEmployee;
        }
    }

    class Employee : Person
    {
        public Employee(string? name, int? age, string? gender, string? nationality, bool? isCitizen) : base(true)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Nationality = nationality;
            IsCitizen = IsCitizen;
        }
    }

    class Stuff : Employee
    {
        public Stuff(string? name, int? age, string? gender, string? nationality, bool? IsCitizen) : base(name, age, gender, nationality, IsCitizen)
        {
        }
    }
    class Management : Employee
    {
        public Management(string? name, int? age, string? gender, string? nationality, bool? isemployee) : base(name, age, gender, nationality, isemployee)
        {
        }
    }
    class Owner : Employee
    {
        public Owner(Person person) : base(person.Name,person.Age,person.Gender, person.Nationality,person.IsCitizen)
        {

        }
        public Owner(string? name, int? age, string? gender, string? nationality, bool? isemployee) : base(name, age, gender, nationality, isemployee)
        {
        }
        public Owner(Employee employee) : base(employee.Name, employee.Age, employee.Gender, employee.Nationality, employee.IsCitizen)
        {

        }
    }
    class Client : Person
    {
        Client() : base(false)
        {
        }
    }
}
