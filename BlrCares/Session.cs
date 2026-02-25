namespace BengaluruCares
{
    public static class Session
    {
        public static Image? ProfileImage { get; set; }
        public static string? UserName { get; set; }
        public static string? UserRole { get; set; }
        public static string? UserEmail { get; set; } // Add this to track the logged-in NGO
    }
}