using Microsoft.AspNetCore.Routing;

namespace UserValidate_ASP.NET.Models.Admin
{
    public class AdminWork : IDisposable
    {
        private UserContext _userContext;
        private AdminRepository _adminRepository;

        public AdminRepository AdminRepository
        {
            get
            {
                if (_adminRepository == null)
                    _adminRepository = new AdminRepository(_userContext);
                return _adminRepository;
            }
            set { _adminRepository = value; }
        }

        public AdminWork()
        {
            _userContext = new();
        }
        public void Dispose() => GC.SuppressFinalize(this);
    }
}
