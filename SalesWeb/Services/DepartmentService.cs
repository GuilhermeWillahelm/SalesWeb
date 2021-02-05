using System;
using System.Collections.Generic;
using System.Linq;
using SalesWeb.Models;
using SalesWeb.Data;

namespace SalesWeb.Services
{
    public class DepartmentService
    {
        public readonly SalesWebContext _context;

        public DepartmentService(SalesWebContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
