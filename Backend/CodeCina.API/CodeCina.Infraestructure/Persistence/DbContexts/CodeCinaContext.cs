using CodeCina.Application.Interfaces;
using CodeCina.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeCina.Infraestructure.Persistence.DbContexts
{
    public partial class CodeCinaContext : DbContext, IApplicationDbContext
    {
        public CodeCinaContext() { }
        public CodeCinaContext(DbContextOptions<CodeCinaContext> options)
        : base(options)
        {

        }

        public virtual DbSet<Producto> Productos { get; set; } = null!;

        public virtual DbSet<TypeProduct> TypeProducts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            OnModelCreatingPartial(modelBuilder);
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }


}
