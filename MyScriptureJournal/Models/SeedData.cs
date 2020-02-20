using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScriptureJournal.Data;
using System;
using System.Linq;

namespace MyScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any Scriptures.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "1 Nephi",
                        Chapter = 3,
                        Verse = 7,
                        Notes = "I will go and do",
                        DateAdded = DateTime.Parse("2020-2-10")
                    },
                    new Scripture
                    {
                        Book = "2 Nephi",
                        Chapter = 2,
                        Verse = 27,
                        Notes = "Men are to have joy",
                        DateAdded = DateTime.Parse("2020-2-12")
                    },
                       new Scripture
                       {
                           Book = "Enos",
                           Chapter = 1,
                           Verse = 12,
                           Notes = "Sins are forgiven",
                           DateAdded = DateTime.Parse("2020-2-17")
                       },
                         new Scripture
                         {
                             Book = "Alma",
                             Chapter = 5,
                             Verse = 12,
                             Notes = "Spiritual to do list",
                             DateAdded = DateTime.Parse("2020-2-14")
                         }

                );
                context.SaveChanges();
            }
        }
    }
}