using System.Net;

namespace UserValidate_ASP.NET.Models.Admin
{
    public class AdminRepository : IAdminRepository<User>
    {
        private UserContext _context;

        public AdminRepository(UserContext context)
        {
            this._context = context;
        }

        public IEnumerable<User> GetAll() => _context.Users;

        public User? GetUserByMail(string mail) => (User?)_context.Users.FirstOrDefault(x => x.Email == mail);

        public bool AddUser(User user)
        {
            UserContext context = new();
            var temp = context.Users.FirstOrDefault(x => x.Email == user.Email);
            if(temp == null)
            {
                context.Users.Add(user);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public HttpStatusCode ChengePassword(User user)
        {
            UserContext context = new();
            var temp = context.Users.FirstOrDefault(x => x.Email == user.Email);
            if (temp != null)
            {
                temp.Password = user.Password;
                context.SaveChanges();
                return HttpStatusCode.OK;
            }
            return HttpStatusCode.NotAcceptable;
        }
    }
}
