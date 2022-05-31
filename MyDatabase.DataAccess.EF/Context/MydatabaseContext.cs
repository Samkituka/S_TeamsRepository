using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MyDatabase.DataAccess.EF.Models;

#nullable disable

namespace MyDatabase.DataAccess.EF.Context
{
    public partial class MydatabaseContext : DbContext
    {
        public MydatabaseContext()
        {
        }

        public MydatabaseContext(DbContextOptions<MydatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Contacts1> Contacts1s { get; set; }
        public virtual DbSet<DemoTable> DemoTables { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<FilesTable> FilesTables { get; set; }
        public virtual DbSet<FinancialInformation> FinancialInformations { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Library> Libraries { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<MoviesWatched> MoviesWatcheds { get; set; }
        public virtual DbSet<MyMovie> MyMovies { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Pet> Pets { get; set; }
        public virtual DbSet<RaceResult> RaceResults { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<RecordTeam> RecordTeams { get; set; }
        public virtual DbSet<Soccer> Soccers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.BookTitle)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.HaveReadbook)
                    .IsRequired()
                    .HasMaxLength(225);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.ContactsId);

                entity.Property(e => e.ContactsId).HasColumnName("ContactsID");

                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StreetAddress1)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.StreetAddress2)
                    .IsRequired()
                    .HasMaxLength(225);
            });

            modelBuilder.Entity<Contacts1>(entity =>
            {
                entity.HasKey(e => e.ContactsId);

                entity.ToTable("Contacts1");

                entity.Property(e => e.ContactsId).HasColumnName("ContactsID");

                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StreetAddress1)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.StreetAddress2)
                    .IsRequired()
                    .HasMaxLength(225);
            });

            modelBuilder.Entity<DemoTable>(entity =>
            {
                entity.HasKey(e => e.DemoId);

                entity.ToTable("DemoTable");

                entity.Property(e => e.DemoId).HasColumnName("DemoID");

                entity.Property(e => e.DemoName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DemoTitle)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasKey(e => e.DocumentsId);

                entity.ToTable("Document");

                entity.Property(e => e.DocumentsId).HasColumnName("DocumentsID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.LastDateUpdated).HasColumnType("date");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(225);
            });

            modelBuilder.Entity<FilesTable>(entity =>
            {
                entity.HasKey(e => e.FilesId);

                entity.ToTable("FilesTable");

                entity.Property(e => e.FilesId).HasColumnName("filesID");

                entity.Property(e => e.Customerfiles)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("customerfiles");

                entity.Property(e => e.Myfiles)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("myfiles");
            });

            modelBuilder.Entity<FinancialInformation>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PK_Banking");

                entity.ToTable("FinancialInformation ");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountBalance).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.DateUpdated).HasColumnType("date");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.ToTable("Inventory");

                entity.Property(e => e.InventoryId).HasColumnName("InventoryID");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.Cost).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(225);
            });

            modelBuilder.Entity<Library>(entity =>
            {
                entity.HasKey(e => e.BookId);

                entity.ToTable("Library");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.BookTitle)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.HaveRead)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnType("date");
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasKey(e => e.MoviesId);

                entity.Property(e => e.MoviesId).HasColumnName("MoviesID");

                entity.Property(e => e.DateAdded).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");

                entity.Property(e => e.Director)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.LeadActor)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.MovieTitle)
                    .IsRequired()
                    .HasMaxLength(225);
            });

            modelBuilder.Entity<MoviesWatched>(entity =>
            {
                entity.HasKey(e => e.MovieTitle);

                entity.ToTable("Movies Watched");

                entity.Property(e => e.MovieTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Movie Title");

                entity.Property(e => e.Director)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LeadActor)
                    .HasMaxLength(50)
                    .HasColumnName("Lead Actor");

                entity.Property(e => e.PersonalRating)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Personal Rating");
            });

            modelBuilder.Entity<MyMovie>(entity =>
            {
                entity.HasKey(e => e.MovieId);

                entity.Property(e => e.MovieId).HasColumnName("MovieID");

                entity.Property(e => e.Director)
                    .IsRequired()
                    .HasMaxLength(225)
                    .HasColumnName("director");

                entity.Property(e => e.LeadActor)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.MovieTitle)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("person");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("age")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("name")
                    .IsFixedLength(true);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("surname")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Pet>(entity =>
            {
                entity.Property(e => e.PetId).HasColumnName("PetID");

                entity.Property(e => e.BirthYear).HasColumnName("birthYear");

                entity.Property(e => e.DateAdministered).HasColumnType("date");

                entity.Property(e => e.Diet)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.PetName)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.Species)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.Vaccine)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.Veterinarian)
                    .IsRequired()
                    .HasMaxLength(225);
            });

            modelBuilder.Entity<RaceResult>(entity =>
            {
                entity.HasKey(e => e.RaceId);

                entity.Property(e => e.RaceId).HasColumnName("RaceID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(225)
                    .HasColumnName("state");
            });

            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.HasKey(e => e.RecipesId);

                entity.ToTable("Recipe");

                entity.Property(e => e.RecipesId).HasColumnName("RecipesID");

                entity.Property(e => e.CostPerServing).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MainIngredient).HasMaxLength(50);

                entity.Property(e => e.PrepTime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RecipeName)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.TypeofMeal)
                    .IsRequired()
                    .HasMaxLength(225);
            });

            modelBuilder.Entity<RecordTeam>(entity =>
            {
                entity.HasKey(e => e.TeamId);

                entity.ToTable("Record Teams");

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.TeamName)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e._2017season)
                    .IsRequired()
                    .HasMaxLength(225)
                    .HasColumnName("2017Season");

                entity.Property(e => e._2018season)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("2018Season");

                entity.Property(e => e._2019season)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("2019Season");

                entity.Property(e => e._2020season)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("2020Season");

                entity.Property(e => e._2021season)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("2021Season");
            });

            modelBuilder.Entity<Soccer>(entity =>
            {
                entity.ToTable("Soccer");

                entity.Property(e => e.BestTeamPlayer)
                    .HasMaxLength(225)
                    .HasColumnName("Best Team Player");

                entity.Property(e => e.DatePlayed)
                    .HasColumnType("date")
                    .HasColumnName("Date Played");

                entity.Property(e => e.GamesLost).HasColumnName("Games Lost");

                entity.Property(e => e.GamesPlayed).HasColumnName("Games Played");

                entity.Property(e => e.GamesWon).HasColumnName("Games Won");

                entity.Property(e => e.SoccerTeams)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
