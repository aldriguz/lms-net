using Core.Entity;
using Core.Repositories;
using LmsNet.Data;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Student entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Remove(Student entity)
        {
            throw new NotImplementedException();
        }

        public async Task Save(Student entity)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
