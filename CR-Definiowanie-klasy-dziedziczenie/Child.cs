public class Child : Person
{
    public Person Mother { get; }
    public Person Father { get; }

    public new int Age
    {
        get => base.Age;
        private set
        {
            if (value > 15)
            {
                throw new ArgumentException("Child’s age must be less than 15!");
            }
            base.Age = value;
        }
    }

    public Child(string firstName, string familyName, int age, Person mother = null, Person father = null)
        : base(firstName, familyName, age)
    {
        if (age > 15)
            throw new ArgumentException("Child’s age must be less than 15!");

        Mother = mother;
        Father = father;
    }
    /* Przysłonięte metody */
    public override void ModifyAge(int age)
    {
        if (age > 15)
        {
            throw new ArgumentException("Child’s age must be less than 15!");
        }
        base.ModifyAge(age);
    }

    public override string ToString()
    {
        string result = $"{FirstName} {FamilyName} ({Age})\n";

        result += "mother: ";
        result += Mother != null ? Mother.ToString() : "No data";
        result += "\n";

        result += "father: ";
        result += Father != null ? Father.ToString() : "No data";

        return result;
    }
}