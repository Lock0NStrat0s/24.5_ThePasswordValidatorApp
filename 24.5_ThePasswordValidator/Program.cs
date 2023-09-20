namespace _24._5_ThePasswordValidator;

public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter a password to validate: ");
            string password = Console.ReadLine();

            PasswordValidator passwordCheck = new PasswordValidator();
            if (passwordCheck.IsValid(password))
            {
                Console.WriteLine("Valid password.");
            }
            else
            {
                Console.WriteLine("INVALID.");
            }

        }
    }
}

public class PasswordValidator
{
    public bool IsValid(string password)
    {
        if (password.Length < 6) return false;
        if (password.Length > 13) return false;
        if (!HasLowercase(password)) return false;
        if (!HasUppercase(password)) return false;
        if (!HasDigits(password)) return false;
        if (HasSpecial(password)) return false;

        return true;
    }

    private bool HasLowercase(string password)
    {
        foreach (char c in password)
        {
            if (char.IsLower(c)) return true;
        }
        return false;
    }

    private bool HasUppercase(string password)
    {
        foreach (char c in password)
        {
            if (char.IsUpper(c)) return true;
        }
        return false;
    }

    private bool HasDigits(string password)
    {
        foreach (char c in password)
        {
            if (char.IsDigit(c)) return true;
        }
        return false;
    }

    private bool HasSpecial(string password)
    {
        foreach (char c in password)
        {
            if (c == 'T' || c == '&') return true;
        }
        return false;
    }
}