namespace IdentityDemo.Api.Common.Constants;

public static class FieldLengths
{
    public static class Project
    {
        public const int Name = 100;
        public const int Description = 500;
    }

    public static class User
    {
        // Identity defaults
        public const int Email = 256;
        public const int UserName = 256;
        public const int RoleName = 256;
    }
}