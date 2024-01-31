namespace BusinessLogicLayer
{
    public abstract class User
    {
        public User()
        { 
        }

        public virtual string Login(string UserName, string Password)
        {
            return string.Empty;
        }

        public static string UserName
        {
            get;
            set;
        }

        public static string UserID
        {
            get;
            set;
        }
    }
}
