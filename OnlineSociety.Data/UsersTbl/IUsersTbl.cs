using System.Collections.Generic;
using OnlineSociety.Models.Datamodel;

namespace OnlineSociety.Model.UsersTbl
{
    public interface IUsersTbl
    {
        IEnumerable<User> GetUsers();
        User GetUserByName(string username);
    }
}
