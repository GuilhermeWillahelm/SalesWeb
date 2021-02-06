using System;
using System.Collections.Generic;
using System.Linq;
using SalesWeb.Models;
using SalesWeb.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWeb.Services
{
    public class DepartmentService
    {
        public readonly SalesWebContext _context;

        public DepartmentService(SalesWebContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
