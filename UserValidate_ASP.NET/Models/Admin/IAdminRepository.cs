using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace UserValidate_ASP.NET.Models.Admin
{
    public interface IAdminRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        public T? GetUserByMail(string T);
        public HttpStatusCode ChengePassword(T T);
        bool AddUser(T T);
    }
}
