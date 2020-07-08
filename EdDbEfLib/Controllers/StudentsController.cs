using EdDbEfLib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace EdDbEfLib.Controllers
{
    public class StudentsController
    {
        private readonly EdDbContext _context = null;

        public async Task<List<Student>> GetAll()
        {
            return await _context.Student.ToListAsync();
        }

        public async Task<Student> GetByPk(int id)
        {
            return await _context.Student.FindAsync(id);
        }

        public async Task<bool> Insert(Student student)
        {
            if(student == null)
            {
                throw new Exception("Student cannot be null");
            }
            var result = await _context.Student.AddAsync(student);
            var entitiesAffected = await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Update(int id, Student student)
        {
            _context.Update(student);
            await _context.SaveChangesAsync();
            return true;
        }
        
        public StudentsController()
        {
            _context = new EdDbContext();
        }
    }
}
