namespace PasswordHasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of PasswordHasher
            var passwordHasher = new Services.Concrete.PasswordHasher();

            // Enter a password to hash
            Console.Write("Enter a password to hash: ");
            string password = Console.ReadLine()!;

            // Hash the password
            string hashedPassword = passwordHasher.Hash(password);
            Console.WriteLine($"Hashed password: {hashedPassword}");

            // Verify the password
            Console.Write("Enter a password to verify: ");
            string passwordToVerify = Console.ReadLine()!;

            bool isMatch = passwordHasher.Verify(passwordToVerify, hashedPassword);
            if (isMatch)
            {
                Console.WriteLine("Password matches!");
            }
            else
            {
                Console.WriteLine("Password does not match!");
            }
        }
    }
}
