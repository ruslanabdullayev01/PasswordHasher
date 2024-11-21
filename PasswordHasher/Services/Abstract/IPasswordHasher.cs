namespace PasswordHasher.Services.Abstract
{
    internal interface IPasswordHasher
    {
        string Hash(string password);
        bool Verify(string password, string passwordhash);
    }
}