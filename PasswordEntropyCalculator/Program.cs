

string password = "MySecureP@ssw0rd"; // Substitua pela senha que você deseja testar
double entropy = CalculateEntropy(password);
Console.WriteLine($"Entropia da senha: {entropy} bits");


double CalculateEntropy(string password)
{
    int characterSpace = 0;
    if (password.Any(char.IsLower)) characterSpace += 26; // Lowercase letters
    if (password.Any(char.IsUpper)) characterSpace += 26; // Uppercase letters
    if (password.Any(char.IsDigit)) characterSpace += 10; // Digits
    if (password.Any(IsSpecialCharacter)) characterSpace += 32; // Special characters

    return Math.Log(Math.Pow(characterSpace, password.Length), 2);
}

bool IsSpecialCharacter(char c)
{
    string specialCharacters = "!@#$%^&*()_+-=[]{}|;:,.<>?";
    return specialCharacters.Contains(c);
}