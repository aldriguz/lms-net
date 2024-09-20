using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IStudentService
    {
        public Task<IReadOnlyList<Student>> GetAll();

        public Task Create(Student student);

        public Task<Student> GetById(int studentId);

        public Task Update(Student student);

        public Task Delete(int studentId);
    }
}
