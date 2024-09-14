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
            await _context.Students.AddAsync(entity);
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            return await _context.Students.AsNoTracking().ToListAsync();
        }

        public async Task<Student> GetById(int id)
        {
            return await _context.Students.AsNoTracking().FirstAsync(x => x.Id == id);
        }

        public void Remove(Student entity)
        {
            _context.Students.Remove(entity);
        }

        public async Task<bool> Save()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update(Student entity)
        {
            _context.Update(entity);
        }
    }
}
