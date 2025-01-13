public class Person
{
    /* Dane osobowe */
    private string _familyName;
    private string _firstName;
    private int _age;

    /* Konstruktor */
    public Person(string firstName, string familyName, int age)
    {
        FirstName = firstName;
        FamilyName = familyName;
        Age = age;
    }

    public string FirstName
    {
        get => _firstName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Wrong name! 1");
                throw new ArgumentException("Wrong name!");
            }
            string trimmedValue = value.Trim();

            foreach (var c in trimmedValue) 
            {
                if (c == ' ') 
                {
                    trimmedValue = trimmedValue.Replace(" ", string.Empty);
                }
            }

            foreach (char c in trimmedValue) {
                if (!char.IsLetter(c) && c != '-') {
                    throw new ArgumentException("Wrong name!");
                }
            }

            _firstName = char.ToUpper(trimmedValue[0]) + trimmedValue.Substring(1).ToLower();
        }
    }

    public string FamilyName
    {
        get => _familyName;
        set
        {
           if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Wrong name!");
            }
            string trimmedValue = value.Trim().Replace(" ", string.Empty);

            foreach (char c in trimmedValue) {
                if (!char.IsLetter(c) && c != '-') {
                    throw new ArgumentException("Wrong name!");
                }
            }

            _familyName = char.ToUpper(trimmedValue[0]) + trimmedValue.Substring(1).ToLower();
        }
    }

    public int Age
    {
        get => _age;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age must be positive!");
            }

            _age = value;
        }
    }

    /* Metody */
    public override string ToString()
    {
        return $"{FirstName} {FamilyName} ({Age})";
    }

    /* Metody do modyfikacji */
    public void ModifyFirstName(string firstName)
    {
        FirstName = firstName;
    }

    public void ModifyFamilyName(string familyName)
    {
        FamilyName = familyName;
    }

    public virtual void ModifyAge(int age)
    {
        Age = age;
    }
}
