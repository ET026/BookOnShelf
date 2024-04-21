﻿// <auto-generated />
using System;
using BookOnShelf.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookOnShelf.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookOnShelf.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("BookOnShelf.Data.Models.Addresses", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("NumberAddition")
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AddressId");

                    b.HasIndex("PostalCode", "NumberAddition", "Number", "Street", "City")
                        .IsUnique()
                        .HasFilter("[NumberAddition] IS NOT NULL");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("BookOnShelf.Data.Models.Authors", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<int>("FkNationalityId")
                        .HasColumnType("int");

                    b.HasKey("AuthorId");

                    b.HasIndex("FkNationalityId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("BookOnShelf.Data.Models.Books", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<int>("BookPages")
                        .HasColumnType("int");

                    b.Property<int>("BookQuantity")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("FkGenreId")
                        .HasColumnType("int");

                    b.Property<int>("FkLanguageId")
                        .HasColumnType("int");

                    b.Property<byte[]>("FrontCover")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ISBNNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("BookId");

                    b.HasIndex("FkGenreId");

                    b.HasIndex("FkLanguageId");

                    b.HasIndex("ISBNNumber")
                        .IsUnique();

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookOnShelf.Data.Models.BooksWriters", b =>
                {
                    b.Property<int>("BookWriterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookWriterId"));

                    b.Property<int>("FkAuthorId")
                        .HasColumnType("int");

                    b.Property<int>("FkBookId")
                        .HasColumnType("int");

                    b.HasKey("BookWriterId");

                    b.HasIndex("FkAuthorId");

                    b.HasIndex("FkBookId");

                    b.ToTable("BooksWriters");
                });

            modelBuilder.Entity("BookOnShelf.Data.Models.BorrowedBooks", b =>
                {
                    b.Property<int>("BorrowedBookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BorrowedBookId"));

                    b.Property<DateTime>("BorrowDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FkBookId")
                        .HasColumnType("int");

                    b.Property<string>("FkUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BorrowedBookId");

                    b.HasIndex("FkBookId");

                    b.HasIndex("FkUserId");

                    b.ToTable("BorrowedBooks");
                });

            modelBuilder.Entity("BookOnShelf.Data.Models.Fines", b =>
                {
                    b.Property<int>("FineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FineId"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("FkBorrowId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("IsPayed")
                        .HasColumnType("datetime2");

                    b.HasKey("FineId");

                    b.HasIndex("FkBorrowId");

                    b.ToTable("Fines");
                });

            modelBuilder.Entity("BookOnShelf.Data.Models.Genres", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"));

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("GenreId");

                    b.HasIndex("GenreName")
                        .IsUnique();

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("BookOnShelf.Data.Models.Languages", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LanguageId"));

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LanguageId");

                    b.HasIndex("LanguageName")
                        .IsUnique();

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("BookOnShelf.Data.Models.Reserved", b =>
                {
                    b.Property<int>("ReservedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservedId"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("IsCanceled")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReservedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ReservedId");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Reserved");
                });

            modelBuilder.Entity("BookOnShelf.Models.BorrowingBooks", b =>
                {
                    b.Property<int>("BorrowingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BorrowingId"));

                    b.Property<int>("FkBookId")
                        .HasColumnType("int");

                    b.Property<string>("FkUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BorrowingId");

                    b.HasIndex("FkBookId");

                    b.HasIndex("FkUserId");

                    b.ToTable("BorrowingBooks");
                });

            modelBuilder.Entity("BookOnShelf.Models.Nationality", b =>
                {
                    b.Property<int>("NationalityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NationalityId"));

                    b.Property<string>("NationalityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("NationalityId");

                    b.ToTable("Nationality");
                });

            modelBuilder.Entity("BookOnShelf.Models.ReservedBooks", b =>
                {
                    b.Property<int>("ReservedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservedId"));

                    b.Property<int>("FkBookId")
                        .HasColumnType("int");

                    b.Property<string>("FkUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ReservedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReservedUntil")
                        .HasColumnType("datetime2");

                    b.HasKey("ReservedId");

                    b.HasIndex("FkBookId");

                    b.HasIndex("FkUserId");

                    b.ToTable("ReservedBooks");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BookOnShelf.Data.Models.Authors", b =>
                {
                    b.HasOne("BookOnShelf.Models.Nationality", "nationalityId")
                        .WithMany()
                        .HasForeignKey("FkNationalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("nationalityId");
                });

            modelBuilder.Entity("BookOnShelf.Data.Models.Books", b =>
                {
                    b.HasOne("BookOnShelf.Data.Models.Genres", "Genre")
                        .WithMany()
                        .HasForeignKey("FkGenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookOnShelf.Data.Models.Languages", "Language")
                        .WithMany()
                        .HasForeignKey("FkLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("BookOnShelf.Data.Models.BooksWriters", b =>
                {
                    b.HasOne("BookOnShelf.Data.Models.Authors", "Author")
                        .WithMany()
                        .HasForeignKey("FkAuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookOnShelf.Data.Models.Books", "Book")
                        .WithMany()
                        .HasForeignKey("FkBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("BookOnShelf.Data.Models.BorrowedBooks", b =>
                {
                    b.HasOne("BookOnShelf.Data.Models.Books", "Book")
                        .WithMany()
                        .HasForeignKey("FkBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookOnShelf.Data.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("FkUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookOnShelf.Data.Models.Fines", b =>
                {
                    b.HasOne("BookOnShelf.Data.Models.BorrowedBooks", "Borrow")
                        .WithMany()
                        .HasForeignKey("FkBorrowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Borrow");
                });

            modelBuilder.Entity("BookOnShelf.Data.Models.Reserved", b =>
                {
                    b.HasOne("BookOnShelf.Data.Models.Books", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookOnShelf.Data.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookOnShelf.Models.BorrowingBooks", b =>
                {
                    b.HasOne("BookOnShelf.Data.Models.Books", "books")
                        .WithMany()
                        .HasForeignKey("FkBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookOnShelf.Data.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("FkUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("books");
                });

            modelBuilder.Entity("BookOnShelf.Models.ReservedBooks", b =>
                {
                    b.HasOne("BookOnShelf.Data.Models.Books", "Book")
                        .WithMany()
                        .HasForeignKey("FkBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookOnShelf.Data.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("FkUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BookOnShelf.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BookOnShelf.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookOnShelf.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BookOnShelf.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
