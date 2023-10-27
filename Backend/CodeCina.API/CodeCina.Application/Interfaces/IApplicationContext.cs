using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CodeCina.Domain.Entities;

namespace CodeCina.Application.Interfaces
{

    public interface IApplicationDbContext
    {
        DbSet<Products> Productos { get; set; }

        DbSet<TypeProduct> TypeProducts { get; set; }

        DbSet<Menu> Menus { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DatabaseFacade Database { get; }

    }
}
