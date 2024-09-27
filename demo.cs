using System;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter your username: ");  
        string username = Console.ReadLine();

        Console.Write("Enter your secret: ");
        string secret = Console.ReadLine();

        // Hash the secret using SHA256
        string hashedSecret = HashSecret(secret);

        Console.WriteLine($"Username: {username}");
        Console.WriteLine($"Hashed Secret: {hashedSecret}");
    }

    static string HashSecret(string secret)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = Encoding.UTF8.GetBytes(secret);
            byte[] hash = sha256.ComputeHash(bytes);
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }

    }
}
