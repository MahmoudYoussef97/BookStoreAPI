﻿// <auto-generated />
using System;
using BookStore.API.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookStore.API.Migrations
{
    [DbContext(typeof(BookStoreContext))]
    partial class BookStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookStore.API.Entities.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserRoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("UserRoleId");

                    b.ToTable("ApplicationUsers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6f48ae73-28bc-40f4-aadb-2cca2c7399e6"),
                            Address = "14th Hegazy St",
                            Email = "Mahmoud@gmail.com",
                            FirstName = "Mahmoud",
                            LastName = "Youssef",
                            Password = "Mm@123456",
                            PhoneNumber = "01229728943",
                            UserRoleId = new Guid("b4ad8066-9164-45f9-9653-44c2deaf7098")
                        },
                        new
                        {
                            Id = new Guid("d6d95f7b-4245-496f-b769-b7db0affa1e1"),
                            Address = "14th Hegazy St",
                            Email = "Ahmed@gmail.com",
                            FirstName = "Ahmed",
                            LastName = "Samy",
                            Password = "Aa@123456",
                            PhoneNumber = "01229728943",
                            UserRoleId = new Guid("78c2f354-a8bf-4554-ae9d-6b08d7b82bab")
                        });
                });

            modelBuilder.Entity("BookStore.API.Entities.ApplicationUserCategories", b =>
                {
                    b.Property<Guid>("ApplicationUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ApplicationUserId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ApplicationUserCategories");

                    b.HasData(
                        new
                        {
                            ApplicationUserId = new Guid("6f48ae73-28bc-40f4-aadb-2cca2c7399e6"),
                            CategoryId = new Guid("4106f579-7696-4613-bfc4-498a0f78e921"),
                            Id = new Guid("5fe22ac5-6151-4961-8fe1-2e76b40a70b6")
                        },
                        new
                        {
                            ApplicationUserId = new Guid("d6d95f7b-4245-496f-b769-b7db0affa1e1"),
                            CategoryId = new Guid("b044828c-5f73-437e-81c8-089b85d81f94"),
                            Id = new Guid("91486cb9-96e8-4ecb-af36-767ab431e4ac")
                        });
                });

            modelBuilder.Entity("BookStore.API.Entities.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("DateOfBirth")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DateOfDeath")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            City = "London",
                            DateOfBirth = new DateTimeOffset(new DateTime(1980, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            FirstName = "Berry",
                            LastName = "Griffin Beak Eldritch"
                        },
                        new
                        {
                            Id = new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                            City = "Canda",
                            DateOfBirth = new DateTimeOffset(new DateTime(1970, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            FirstName = "Nancy",
                            LastName = "Swashbuckler Rye"
                        },
                        new
                        {
                            Id = new Guid("2902b665-1190-4c70-9915-b9c2d7680450"),
                            City = "Singaphore",
                            DateOfBirth = new DateTimeOffset(new DateTime(1995, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            FirstName = "Eli",
                            LastName = "Ivory Bones Sweet"
                        },
                        new
                        {
                            Id = new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                            City = "Tottenham",
                            DateOfBirth = new DateTimeOffset(new DateTime(1978, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            FirstName = "Arnold",
                            LastName = "The Unseen Stafford"
                        },
                        new
                        {
                            Id = new Guid("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"),
                            City = "Paris",
                            DateOfBirth = new DateTimeOffset(new DateTime(1988, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            FirstName = "Seabury",
                            LastName = "Toxic Reyson"
                        },
                        new
                        {
                            Id = new Guid("2aadd2df-7caf-45ab-9355-7f6332985a87"),
                            City = "Madrid",
                            DateOfBirth = new DateTimeOffset(new DateTime(1966, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            FirstName = "Rutherford",
                            LastName = "Fearless Cloven"
                        },
                        new
                        {
                            Id = new Guid("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"),
                            City = "München",
                            DateOfBirth = new DateTimeOffset(new DateTime(1976, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            FirstName = "Atherton",
                            LastName = "Crow Ridley"
                        });
                });

            modelBuilder.Entity("BookStore.API.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<Guid>("PublisherId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int>("TotalNumberOfPages")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                            AuthorId = new Guid("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"),
                            Description = "JavaScript lies at the heart of almost every modern web application, from social apps to the newest browser-based.",
                            ISBN = "9781593275846",
                            PublisherId = new Guid("9571262f-094c-43ec-b1e6-4bd6201cfd0c"),
                            Title = "Eloquent JavaScript, Second Edition",
                            TotalNumberOfPages = 472
                        },
                        new
                        {
                            Id = new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                            AuthorId = new Guid("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"),
                            Description = "JavaScript lies at the heart of almost every modern web application, from social apps to the newest browser-based.",
                            ISBN = "9781449331818",
                            PublisherId = new Guid("1135cd78-f7dd-402d-948b-4da57348b2f9"),
                            Title = "Learning JavaScript Design Patterns",
                            TotalNumberOfPages = 254
                        },
                        new
                        {
                            Id = new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                            AuthorId = new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                            Description = "JavaScript lies at the heart of almost every modern web application, from social apps to the newest browser-based.",
                            ISBN = "9781449365035",
                            PublisherId = new Guid("1135cd78-f7dd-402d-948b-4da57348b2f9"),
                            Title = "Speaking JavaScript",
                            TotalNumberOfPages = 460
                        },
                        new
                        {
                            Id = new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                            AuthorId = new Guid("2902b665-1190-4c70-9915-b9c2d7680450"),
                            Description = "Robust Web Architecture with Node, HTML5, and Modern JS Libraries, from social apps to the newest browser-based.",
                            ISBN = "9781491950296",
                            PublisherId = new Guid("02906a11-0b84-47c6-a9f8-2db076fc9dae"),
                            Title = "Programming JavaScript Applications",
                            TotalNumberOfPages = 254
                        },
                        new
                        {
                            Id = new Guid("40ff5488-fdab-45b5-bc3a-14302d59869c"),
                            AuthorId = new Guid("2902b665-1190-4c70-9915-b9c2d7680450"),
                            Description = "Robust Web Architecture with Node, HTML5, and Modern JS Libraries, from social apps to the newest browser-based.",
                            ISBN = "9781491904244",
                            PublisherId = new Guid("02906a11-0b84-47c6-a9f8-2db076fc9dae"),
                            Title = "Programming Node.Js Applications",
                            TotalNumberOfPages = 180
                        });
                });

            modelBuilder.Entity("BookStore.API.Entities.BookCategories", b =>
                {
                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BookId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("BookCategories");

                    b.HasData(
                        new
                        {
                            BookId = new Guid("40ff5488-fdab-45b5-bc3a-14302d59869c"),
                            CategoryId = new Guid("20442e97-6f21-4d0e-8a1f-434351238ca2"),
                            Id = new Guid("b8814929-f9ec-4a88-9b69-5e1f62d53056")
                        },
                        new
                        {
                            BookId = new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                            CategoryId = new Guid("20442e97-6f21-4d0e-8a1f-434351238ca2"),
                            Id = new Guid("dbba41cb-4ac4-4587-b490-6186ab39a4ea")
                        },
                        new
                        {
                            BookId = new Guid("40ff5488-fdab-45b5-bc3a-14302d59869c"),
                            CategoryId = new Guid("4106f579-7696-4613-bfc4-498a0f78e921"),
                            Id = new Guid("91bd26e3-faf9-43eb-a4ad-1bd5dade738a")
                        },
                        new
                        {
                            BookId = new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                            CategoryId = new Guid("b044828c-5f73-437e-81c8-089b85d81f94"),
                            Id = new Guid("5ff09974-9d37-44b1-ba3e-4c6a89d0b07c")
                        });
                });

            modelBuilder.Entity("BookStore.API.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b044828c-5f73-437e-81c8-089b85d81f94"),
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = new Guid("4106f579-7696-4613-bfc4-498a0f78e921"),
                            Name = "Classics"
                        },
                        new
                        {
                            Id = new Guid("2688fe22-29c6-4372-bb88-3c1fe45a8f02"),
                            Name = "Self-Development"
                        },
                        new
                        {
                            Id = new Guid("69a4ddde-d290-42db-b035-96afa747396d"),
                            Name = "Romance"
                        },
                        new
                        {
                            Id = new Guid("20442e97-6f21-4d0e-8a1f-434351238ca2"),
                            Name = "Mystery"
                        });
                });

            modelBuilder.Entity("BookStore.API.Entities.OrderDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderHeaderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderHeaderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("BookStore.API.Entities.OrderHeader", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApplicationUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CouponCodeDiscount")
                        .HasColumnType("float");

                    b.Property<string>("CoupounCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("OrderDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("PaymentStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShippingName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<double>("TotalOrderPrice")
                        .HasColumnType("float");

                    b.Property<string>("TransactionId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("OrderHeaders");
                });

            modelBuilder.Entity("BookStore.API.Entities.Publisher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Publisher");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1135cd78-f7dd-402d-948b-4da57348b2f9"),
                            Name = "El-Rawaq"
                        },
                        new
                        {
                            Id = new Guid("9571262f-094c-43ec-b1e6-4bd6201cfd0c"),
                            Name = "Dawen"
                        },
                        new
                        {
                            Id = new Guid("02906a11-0b84-47c6-a9f8-2db076fc9dae"),
                            Name = "El-Shorouk"
                        });
                });

            modelBuilder.Entity("BookStore.API.Entities.ShoppingCart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApplicationUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("BookId");

                    b.ToTable("ShoppingCarts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("79404b3f-53bb-4687-b836-87b318e841fd"),
                            ApplicationUserId = new Guid("d6d95f7b-4245-496f-b769-b7db0affa1e1"),
                            BookId = new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                            Quantity = 3
                        },
                        new
                        {
                            Id = new Guid("ca909b9b-881e-4f77-9532-3c2c94b82700"),
                            ApplicationUserId = new Guid("d6d95f7b-4245-496f-b769-b7db0affa1e1"),
                            BookId = new Guid("40ff5488-fdab-45b5-bc3a-14302d59869c"),
                            Quantity = 2
                        },
                        new
                        {
                            Id = new Guid("cf816876-db46-4f9c-9962-c9a39493e8a7"),
                            ApplicationUserId = new Guid("6f48ae73-28bc-40f4-aadb-2cca2c7399e6"),
                            BookId = new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                            Quantity = 1
                        },
                        new
                        {
                            Id = new Guid("78f10e08-fa49-4ef0-9789-59c1e90eeea1"),
                            ApplicationUserId = new Guid("6f48ae73-28bc-40f4-aadb-2cca2c7399e6"),
                            BookId = new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("BookStore.API.Entities.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("78c2f354-a8bf-4554-ae9d-6b08d7b82bab"),
                            Name = "Admin"
                        },
                        new
                        {
                            Id = new Guid("b4ad8066-9164-45f9-9653-44c2deaf7098"),
                            Name = "Customer"
                        });
                });

            modelBuilder.Entity("BookStore.API.Entities.ApplicationUser", b =>
                {
                    b.HasOne("BookStore.API.Entities.UserRole", "UserRole")
                        .WithMany()
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.API.Entities.ApplicationUserCategories", b =>
                {
                    b.HasOne("BookStore.API.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("ApplicationUserCategories")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.API.Entities.Category", "Category")
                        .WithMany("ApplicationUserCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.API.Entities.Book", b =>
                {
                    b.HasOne("BookStore.API.Entities.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.API.Entities.Publisher", "Publisher")
                        .WithMany()
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.API.Entities.BookCategories", b =>
                {
                    b.HasOne("BookStore.API.Entities.Book", "Book")
                        .WithMany("BookCategories")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.API.Entities.Category", "Category")
                        .WithMany("BookCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.API.Entities.OrderDetails", b =>
                {
                    b.HasOne("BookStore.API.Entities.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.API.Entities.OrderHeader", "OrderHeader")
                        .WithMany()
                        .HasForeignKey("OrderHeaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.API.Entities.OrderHeader", b =>
                {
                    b.HasOne("BookStore.API.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.API.Entities.ShoppingCart", b =>
                {
                    b.HasOne("BookStore.API.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.API.Entities.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
