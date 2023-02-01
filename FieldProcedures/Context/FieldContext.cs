using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FieldProcedures.Models;
using Microsoft.EntityFrameworkCore;

namespace FieldProcedures.Context
{
    public class FieldContext : DbContext
    {
        public FieldContext(DbContextOptions<FieldContext> options) : base(options) {}

        public DbSet<Usuario> usuarios { get; set; }
    }
}