using Microsoft.AspNetCore.Mvc;
using ReadApi.Data;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore;
using System;

namespace ReadApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ReadController(AppDbContext context)
        {
            _context = context;
        }


   
    }
}
