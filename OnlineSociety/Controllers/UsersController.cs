using System;
using System.Web.Http;
using AutoMapper;
using System.Collections.Generic;
using OnlineSociety.DataService.Tables;
using OnlineSociety.Models.ViewModels;
using System.Threading.Tasks;

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
        public async Task<IHttpActionResult> GetAsync()
        {
            try
            {
                var results = await _repo.GetUsersAsync();
                var mappedResults = _mapper.Map<IEnumerable<UserModel>>(results);
                return Ok(mappedResults);
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [Route("{Username}")]
        public async Task<IHttpActionResult> GetAsync(string Username)
        {
            try
            {
                var result = await _repo.GetUserByNameAsync(Username);
                var mappedResult = _mapper.Map<UserModel>(result);

                if (result == null) return NotFound();
                return Ok(mappedResult);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
