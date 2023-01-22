using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPI.Context;
using TestAPI.Models;

namespace TestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        public DataContext _dataContext;
        public HomeController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet("GetUsers")]
        public IEnumerable<UserModel> GetUsers()
        {
            return _dataContext.Users.ToList();
        }

        [HttpGet("GetUserById")]
        public IEnumerable<UserModel> GetUsersById(int id)
        {
            return _dataContext.Users.Where(opt => opt.id == id).ToList();
        }

        [HttpPut("Add")]
        public ActionResult Add(int id, string name, string email, string phone)
        {
            var data = new UserModel{
                id = id,
                Name = name,
                Email = email,
                Phone = phone
            };

            try
            {
                _dataContext.Add(data);
                _dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }

            return Ok();
        }

        [HttpPost("Update")]
        public ActionResult Update(int id, string name, string email, string phone)
        {
            var data = _dataContext.Users.Where(opt => opt.id == id).FirstOrDefault();

            data.Phone = phone;
            data.Email = email;
            data.Name = name;

            try
            {
                _dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }

            return Ok();
        }

        [HttpDelete("DeleteById")]
        public ActionResult DeleteById(int id)
        {
            var data = _dataContext.Users.Where(opt => opt.id == id).FirstOrDefault();
            

            try
            {
                _dataContext.Users.Remove(data);
                _dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }

            return Ok();
        }

    }
}
