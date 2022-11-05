using UserValidate_ASP.NET.Models.Admin;

namespace UserValidate_ASP.NET.Models.Users
{
    public class UserWork : IDisposable
    {
        private UserContext _userContext;
        private UserRepository _userRepository;

        public UserRepository AdminRepository
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_userContext);
                return _userRepository;
            }
            set { _userRepository = value; }
        }

        public UserWork()
        {
            _userContext = new();
        }
        public void Dispose() => GC.SuppressFinalize(this);
    }
}
