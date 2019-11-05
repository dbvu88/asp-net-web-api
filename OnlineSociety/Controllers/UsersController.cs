using System;
using System.Web.Http;
using AutoMapper;
using System.Collections.Generic;
using OnlineSociety.DataService.Tables;
using OnlineSociety.Models.ViewModels;

namespace OnlineSociety.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        public UsersController(IUsersTable users, IMapper mapper)
        {
            _repo = users;
            _mapper = mapper;
        }

        public IUsersTable _repo { get; }
        public IMapper _mapper { get; }

        [Route()]
        public IHttpActionResult Get()
        {
            try
            {
                var results = _repo.GetUsers();
                var mappedResults = _mapper.Map<IEnumerable<UserModel>>(results);
                return Ok(mappedResults);
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [Route("{Username}")]
        public IHttpActionResult Get(string Username)
        {
            try
            {
                var result = _repo.GetUserByName(Username);
                if (result == null) return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
