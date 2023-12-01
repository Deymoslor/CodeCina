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
        DbSet<Product> Products { get; set; }

        DbSet<ProductType> ProductTypes { get; set; }

        DbSet<Dish> Dishes { get; set; }

        DbSet<DishProduct> DishProducts { get; set; }

        DbSet<Measure> Measures { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DatabaseFacade Database { get; }

    }
}
