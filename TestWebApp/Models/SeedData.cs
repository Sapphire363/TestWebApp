using Microsoft.EntityFrameworkCore;
using TestWebApp.Data;

namespace TestWebApp.Models
{
	public class SeedData
	{
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TestWebAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TestWebAppContext>>()))
            {
                if (context == null || context.Bed == null)
                {
                    throw new ArgumentNullException("Null TestWebAppContext");
                }

                // Look for any movies.
                if (context.Bed.Any())
                {
                    return;   // DB has been seeded
                }

                context.Bed.AddRange(
                    new Bed
                    {
                        BedNo = 1,
                        Status = false,

                        
                    },
                    new Bed
                    {
                        BedNo = 2,
                        Status = false,

                    },
                    new Bed
                    {
                        BedNo = 3,
                        Status = false,

                    },
                    new Bed
                    {
                        BedNo = 3,
                        Status = false,

                    },
                    new Bed
                    {
                        BedNo = 4,
                        Status = false,

                    },
                    new Bed
                    {
                        BedNo = 5,
                        Status = false,

                    },
                    new Bed
                    {
                        BedNo = 6,
                        Status = false,

                    },
                    new Bed
                    {
                        BedNo = 7,
                        Status = false,

                    },
                    new Bed
                    {
                        BedNo = 8,
                        Status = false,

                    },
                    new Bed
                    {
                        BedNo = 9,
                        Status = false,

                    },
                    new Bed
                    {
                        BedNo = 10,
                        Status = false,

                    }

                );
                context.SaveChanges();
            }
        }
    }
}
