namespace UserValidate_ASP.NET.Models.Users
{
    public class UserRepository : IUserRepository<User>
    {
        private UserContext _context;

        public UserRepository(UserContext context)
        {
            this._context = context;
        }
    }
}
