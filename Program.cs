namespace PasswordStrength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter a password: ");
            string userInputPassword = Console.ReadLine()!;

            int passWordStrenght = 0;


            if (userInputPassword.Length <= 8 ) 
            {
                Console.WriteLine("The password must have at least 8 characters.");
            }

            passWordStrenght += 20;

            bool containsUppercase = false;
            foreach (char characterInPass in userInputPassword) 
            {
                if (char.IsUpper(characterInPass))
                {
                    containsUppercase = true;

                }
                
            }

            if (containsUppercase) passWordStrenght += 20;

            bool containLowercase = false;
            foreach (char bokstav in userInputPassword)
            {
                if (!char.IsUpper(bokstav))
                {
                    containLowercase = true;

                }

            }

            if (containLowercase) passWordStrenght += 20;

            bool containsNumbers = false;
            foreach (char bokstav in userInputPassword)
            {
                if (char.IsDigit(bokstav))
                {
                    containsNumbers = true;
                }

            }

            if (containsNumbers) passWordStrenght += 20;

            bool containsSpecialchar = false;
            string specialCharacters = "!@#$%^&*()_-+=<>?/{}~|";
            foreach (char c in userInputPassword) 
            {
                if (specialCharacters.Contains(c)) 
                {
                    containsSpecialchar = true;
                }
            }

            if (containsSpecialchar) passWordStrenght += 20;

            Console.WriteLine($"Password strength {passWordStrenght}");

            switch (passWordStrenght) 
            {
                case <= 40: Console.WriteLine("Your password is weak.");
                    break;

                case <= 60:
                    Console.WriteLine("Your password is moderate.");
                    break;

                case <= 80:
                    Console.WriteLine("Your password is strong.");
                    break;

                default:
                    Console.WriteLine("Unknown result.");
                    break;

            }

        }
    }
}
