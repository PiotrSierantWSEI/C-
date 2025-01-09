public class Person {

    /* Dane osobowe */
    private string _familyName;
    private string _firstName;
    private DateTime _birthday;
    public string FamilyName { 
        get => _familyName; 
        set {
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("Incorrect data for FamilyName");
            }
            string trimmedValue = value.Trim();
            if (trimmedValue.Length < 3) {
                throw new ArgumentException("Incorrect data for FamilyName");
            }

            if(trimmedValue.Split('-', StringSplitOptions.RemoveEmptyEntries).Length > 2) {
                throw new ArgumentException("Incorrect data for FamilyName");
            }

            foreach (char c in trimmedValue) {
                if (!char.IsLetter(c) && c != '-') {
                    throw new ArgumentException("Incorrect data for FamilyName");
                }
            }

            _familyName = trimmedValue;
        } 
    }
    public string FirstName { 
        get => _firstName; 
        set {
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("Incorrect data for FirstName");
            }
            string trimmedValue = value.Trim();
            if (trimmedValue.Length < 3) {
                throw new ArgumentException("Incorrect data for FirstName");
            }

            foreach (char c in trimmedValue) {
                if (!char.IsLetter(c)) {
                    throw new ArgumentException("Incorrect data for FirstName");
                }
            }

            _firstName = trimmedValue;
        }
    }
    public DateTime Birthday { 
        get => _birthday;
        set {
            if (value > DateTime.Now) {
                throw new ArgumentException("Incorrect data for Birthday");
            }
            _birthday = value;
        } 
    }

    /* Konstruktor */
    public Person(string familyName, string firstName, DateTime birthday) {
        FamilyName = familyName;
        FirstName = firstName;
        Birthday = birthday;
    }

    /* Metody */
    public override string ToString() {
        return $"{FirstName} {FamilyName} ({Birthday:yyyy-MM-dd})";
    }
}