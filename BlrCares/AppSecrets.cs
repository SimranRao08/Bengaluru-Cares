namespace BlrCares
{
    public static class AppSecrets
    {
        // 1. Database Connection (Centralized here)
        public static string ConnString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BengaluruCaresDB;Integrated Security=True";

        // 2. Email Credentials
        public static string EmailAccount = "cineflix.corp.in@gmail.com";
        public static string EmailPassword = "jtfdunaobrmfehnt";

        // 3. Encryption Key
        public static string EncryptionKey = "BengaluruCaresSecretKey2026!!";
    }
}