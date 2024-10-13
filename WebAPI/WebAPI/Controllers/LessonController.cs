using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Concrete;
using WebAPI.Entity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class LessonController : Controller
    {
        private readonly Context _context;
        public LessonController(Context context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetListAllLesson()
        {
            var values = _context.Lessons.ToList();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateLesson(Lesson p)
        {
            _context.Add(p);
            _context.SaveChanges();
            return Ok("Başarılı Bir Şekilde Eklendi...");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateLesson(Lesson p)
        {
            _context.Update(p);
            _context.SaveChanges();
            return Ok("Başarılı Bir Şekilde Güncellendi...");
        }
    }
}

