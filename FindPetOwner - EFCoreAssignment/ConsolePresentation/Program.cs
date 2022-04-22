using Application;
using Application.FoundPetPosts.Commands.CreateFoundPetPost;
using Application.FoundPetPosts.Queries;
using Application.Users.Commands.CreateUser;
using Application.Users.Queries;
using Domain;
using FindPetOwner;
using Infrastructure;
using Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ConsolePresentation
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {

            await using var context = new FindPetOwnerContext();
            /*var user1 = new User
            {
                FirstName = "Cristian",
                LastName = "Pop",
                Email = "example@mail.com",
                Phone = "07500563",
                Address = "Oradea"
            };

            var user2 = new User
            {
                FirstName = "Ioana",
                LastName = "Sabau",
                Email = "example@mail.com",
                Phone = "0750400400",
                Address = "Oradea"
            };

            var user3 = new User
            {
                FirstName = "Ana",
                LastName = "Duma",
                Email = "example@mail.com",
                Phone = "0750400400",
                Address = "Oradea"
            };

            var user4 = new User
            {
                FirstName = "Carmen",
                LastName = "Duma",
                Email = "example@mail.com",
                Phone = "0750400400",
                Address = "Oradea"
            };

            context.Users.Add(user1);
            context.Users.Add(user2);
            context.Users.Add(user3);
            await context.SaveChangesAsync();*/


            //var user2 = context.Users.First(x => x.FirstName == "Ioana");
            // var user3 = context.Users.First(x => x.FirstName == "Ana");
            //var user4 = context.Users.First(x => x.FirstName == "Carmen");

            /*var post1 = new FoundPetPost
            {
                CreatedBy = context.Users.First(x => x.FirstName == "Cristian"),
                Comment = "post1",
                AvailabilityStart = DateTime.Now,
                AvailabilityEnd = DateTime.Now,
                Address = "Oradea",
                Phone = "0700500500"
            };


            var post2 = new FoundPetPost
            {
                CreatedBy = context.Users.First(x => x.FirstName == "Cristian"),
                Comment = "post2",
                AvailabilityStart = DateTime.Now,
                AvailabilityEnd = DateTime.Now,
                Address = "Oradea",
                Phone = "0700500500"
            };

            var post3 = new FoundPetPost
            {
                CreatedBy = context.Users.First(x => x.FirstName == "Ioana"),
                Comment = "post3",
                AvailabilityStart = DateTime.Now,
                AvailabilityEnd = DateTime.Now,
                Address = "Oradea",
                Phone = "0700500500"
            };

            context.FoundPetPosts.Add(post1);
            context.FoundPetPosts.Add(post2);
            context.FoundPetPosts.Add(post3);
            await context.SaveChangesAsync();*/


            /*var assignment1 = new AssignedVolunteer
            {
                AssignedTo = new User
                {
                    FirstName = "Cristian",
                    LastName = "Popa",
                    Email = "example@mail.com",
                    Phone = "07500563",
                    Address = "Oradea"
                },

                Post = new FoundPetPost
                {
                    CreatedBy = context.Users.First(x => x.FirstName == "Ana"),
                    Comment = "post5",
                    AvailabilityStart = DateTime.Now,
                    AvailabilityEnd = DateTime.Now,
                    Address = "Oradea",
                    Phone = "0700500500"
                },
                CreatedOn = DateTime.Now,
                ScheduledTime = DateTime.Now.AddDays(1),
            };


            var assignment2 = new AssignedVolunteer
            {
                AssignedTo = new User
                {
                    FirstName = "Cristian",
                    LastName = "Popa",
                    Email = "example@mail.com",
                    Phone = "07500563",
                    Address = "Oradea"
                },
                Post = new FoundPetPost
                {
                    CreatedBy = context.Users.First(x => x.FirstName == "Ana"),
                    Comment = "post6",
                    AvailabilityStart = DateTime.Now,
                    AvailabilityEnd = DateTime.Now,
                    Address = "Oradea",
                    Phone = "0700600600"

                },
                CreatedOn = DateTime.Now,
                ScheduledTime = DateTime.Now.AddDays(1),
            };

            var assignment3 = new AssignedVolunteer
            {
                AssignedTo = new User
                {
                    FirstName = "Carmen",
                    LastName = "Popa",
                    Email = "example@mail.com",
                    Phone = "07500563",
                    Address = "Oradea"
                },
                Post = new FoundPetPost
                {
                    CreatedBy = context.Users.First(x => x.LastName == "Popa"),
                    Comment = "post7",
                    AvailabilityStart = DateTime.Now,
                    AvailabilityEnd = DateTime.Now,
                    Address = "Oradea",
                    Phone = "0700500500"
                },
                CreatedOn = DateTime.Now,
                ScheduledTime = DateTime.Now.AddDays(1),
            };

            context.AssignedVolunteers.Add(assignment1);
            context.AssignedVolunteers.Add(assignment2);
            context.AssignedVolunteers.Add(assignment3);
            await context.SaveChangesAsync();*/


            //1.useri cu postarile aferente
            var users = context.Users
                .Include(x => x.FoundPetPosts)
                .ToListAsync();

            Console.WriteLine("1");
            foreach (var user in await users)
            {
                Console.WriteLine(user);
                foreach (var post in user.FoundPetPosts)
                    Console.WriteLine(post.Id);
            }

            //2 selecteaza comentarii si adresa din tabelul FoundPetPosts
            var selectproperties = await context.FoundPetPosts.Select(x => new
            {
                Comment = x.Comment,
                Address = x.Address

            }).ToListAsync();

            foreach (var property in selectproperties)
            { Console.WriteLine($"comment: {property.Comment} adress:{property.Address}");
            }


            //3. grupeaza dupa adresa
            //doar cu client side am reusit sa fac
            var groups = context.FoundPetPosts.ToList().GroupBy(x => x.Address);

            foreach (var group in groups)
            {
                Console.WriteLine($"adress {group.Key}");
                foreach (var item in group)
                    Console.WriteLine($"post id {item.Id}");
            }

            //4. grupeaza dupa comentariu, afiseaza comentariu si numar de aparitii
            //nu se face dupa guid!
            var groupByUser = context.FoundPetPosts.GroupBy(x => x.Comment)
                .Select(x => new 
                { 
                    CreatedBy = x.Key,
                    Count = x.Count()
                }
                ).ToListAsync();

            foreach (var user in await groupByUser)
            {
                Console.WriteLine($"{user.CreatedBy}{user.Count}");
            }

            //5. selecteaza coloane din tabele diferite
            var usersPosts = context.Users.SelectMany(x => x.FoundPetPosts, (u, f) => new
            { 
            Firstname = u.FirstName,
            Lastname = u.LastName,
            Comment = f.Comment
            }).OrderBy(x=>x.Comment);

            foreach (var user in usersPosts)
            {
                Console.WriteLine($"{user.Firstname} {user.Lastname} {user.Comment}");
            }

            //6. returneaza rezultatele de afisat pentru pagina 2
            var pagesize = 4;
            var page = 2;

            var paginare = context.Users.OrderByDescending(x => x.Address)
                .Skip((page-1)*pagesize)
                .Take(pagesize);

            foreach (var user in paginare)
            {
                Console.WriteLine(user);
            }

            //7 comparat tipul rezultatului dintre select si selectmany, primul returneaza
            //nume + o colectie de postari, al 2lea combinatii nume + fiecare postare
            var usersPosts1 = context.Users
            .Select(x => new
            {
                Firstname = x.FirstName,
                Post = x.FoundPetPosts
            }).ToListAsync();


            var usersPostsFlattened = context.Users
                .SelectMany(x => x.FoundPetPosts, (u,f) => new
                {
                    Firstname = u.FirstName,
                    Post = f
                }).ToListAsync();

            foreach (var user in await usersPostsFlattened)
            {
                Console.WriteLine(user);
            }

            //cel mai devreme programat assignment

            var soonestAssignment = context.AssignedVolunteers.Min(x => x.ScheduledTime);
            Console.WriteLine(soonestAssignment);

            //9 cel mai tarziu programat assignment
            var latestAssignment = context.AssignedVolunteers.Where(x => x.AssignedToId == Guid.Parse("1FBC5445-7A9B-4C4B-8EBA-2CDFEFDAC3D4")).Max(x => x.ScheduledTime);
            Console.WriteLine(latestAssignment);

            //10 nr de useri

            var firstnameCount = context.Users.Where(x => x.LastName == "Popa")
                .GroupBy(x=>x.FirstName).Select(x => new
            {
                Firstname = x.Key,
                CountedNames = x.Count()
            }).ToListAsync();

            foreach (var name in await firstnameCount)
            {
                Console.WriteLine($"{name.Firstname} {name.CountedNames}");
            }
        }
    }
}
