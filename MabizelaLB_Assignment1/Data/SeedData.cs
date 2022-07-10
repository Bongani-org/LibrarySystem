using MabizelaLB_Assignment1.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MabizelaLB_Assignment1.Data
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder applicationBuilder)
        {
            AppDbContext appDbContext = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<AppDbContext>();

            if (appDbContext.Database.GetPendingMigrations().Any())
            {
                appDbContext.Database.Migrate();
            }

            if(!appDbContext.Books.Any())
            {
                appDbContext.Books.AddRange(
                    new Book
                    {
                        BookTitle = "Winter Garden", 
                        BookAuthor = "Kristin Hannah", 
                        BookISBN = "978-1-46923573-8", 
                        BookIsRead = false 
                    },
                    new Book
                    {
                        BookTitle = "Troubled Blood",
                        BookAuthor = "Robert Galbraith",
                        BookISBN = "0316498989",
                        BookIsRead = false
                    },
                    new Book
                    {
                        BookTitle = "The Night Fire",
                        BookAuthor = "Michael Connelly",
                        BookISBN = "978-1-4091-8606-9",
                        BookIsRead = false
                    },
                    new Book
                    {
                        BookTitle = "The Eighth Sister",
                        BookAuthor = "Robert Dugoni",
                        BookISBN = "978-1-64358-214-6",
                        BookIsRead = true
                    }
                );
                appDbContext.SaveChanges();
            }
            
        }
    }
}
