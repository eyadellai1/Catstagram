using Catstagram.Data;
using Catstagram.Models;
using Microsoft.EntityFrameworkCore;

namespace Catstagram
{
    public class Sample
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CatstagramContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CatstagramContext>>()))
            {


                // Look for any posts.
                if (context.Post.Any())
                {
                    return;   // DB has been seeded
                }

                context.Post.AddRange(

                    new Post
                    {
                        Image = "cat.jpeg",
                        Name = "Erman",
                        Email = "Erman@hotmail.com",
                        Comment = "#Cat My cat",
                        DateAdded = DateTime.Parse("12.10.2022")
                    },

                    new Post
                    {
                        Image = "cats.jpeg",
                        Name = "Erman",
                        Email = "Erman@hotmail.com",
                        Comment = "#MultipleCats My cats",
                        DateAdded = DateTime.Parse("08.02.2022")
                    },

                    new Post
                    {
                        Image = "bigcat.jpeg",
                        Name = "Erman",
                        Email = "Erman@hotmail.com",
                        Comment = "Big cat",
                        DateAdded = DateTime.Parse("04.07.2022")
                    }
                );
                context.SaveChanges();
            }
        }


    }
}
