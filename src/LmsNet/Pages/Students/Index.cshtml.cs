using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Core.Entity;
using LmsNet.Data;
using Core.Interfaces;

namespace LmsNet.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly IStudentService _studentService;

        public IndexModel(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Student = await _studentService.GetAll();
        }
    }
}
