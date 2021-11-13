﻿using ApiMySql.Data.Entities.Positions;
using ApiMySql.Data.Entities.Users;
using ApiMySql.Models;
using GladsAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiMySql.Controllers
{
    [Route("api")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("[controller]/List")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<User>>> GetList()
        {
            try
            {
                var result = await _repository.GetList();
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("[controller]/Filter")]
        [Authorize]
        public async Task<ActionResult<ResponseData<User>>> Filter(FilterData filter)
        {
            try
            {
                var result = await _repository.Filter(filter);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("[controller]/Positions")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Position>>> GetPositions()
        {
            try
            {
                var result = await _repository.GetPositions();
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("[controller]/{id}")]
        [Authorize]
        public async Task<ActionResult<User>> GetUser(Guid id)
        {
            try
            {
                var result = await _repository.GetUser(id);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("[controller]/Save")]
        public async Task<ActionResult<User>> Save([FromBody] User user)
        {
            try
            {
                var result = user.Id == Guid.Empty ?  await _repository.PostUser(user) : await _repository.PutUser(user);
                return Ok("Usuario salvo com sucesso");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("[controller]/{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            try
            {
                 await _repository.DeleteUser(id);
                return Ok("Usuario deletado com sucesso");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
