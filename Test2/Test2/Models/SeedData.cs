using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Test2.Data;
using System;
using System.Linq;
using Test2.Models;

namespace Test2.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new Test2Context(
            serviceProvider.GetRequiredService<
                DbContextOptions<Test2Context>>()))
        {
            // Look for any movies.
            if (context.Class.Any())
            {
                return;   // DB has been seeded
            }
            context.Class.AddRange(
                new Class
                {
                    Name = "かずき",
                    Time = 88,
                    SurName="佐藤"
                },
                new Class
                {
                    Name = "くぼのぶ",
                    Time = 9934,
                    SurName="森"
                }
            );
            context.SaveChanges();
        }
    }
}
