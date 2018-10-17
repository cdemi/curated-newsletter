﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewsletterCurator.Data;

namespace NewsletterCurator.Data.Migrations
{
    [DbContext(typeof(NewsletterCuratorContext))]
    [Migration("20181017142917_Added Category Colors")]
    partial class AddedCategoryColors
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NewsletterCurator.Data.Category", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<float>("Priority");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new { ID = new Guid("bbf3205e-578b-4568-9d86-7c15fceb6a4f"), Color = "#2C8693", Name = "DevOps", Priority = 3f },
                        new { ID = new Guid("3f9acf3f-bf48-455d-9a3f-f660cd3a13b3"), Color = "#2C8693", Name = "Front End", Priority = 2f },
                        new { ID = new Guid("57e0baf7-3b80-4866-b9ae-3a2e77ad88fb"), Color = "#2C8693", Name = "AI", Priority = 7f },
                        new { ID = new Guid("12e0baf7-3b80-4866-b9ae-3a2e77ad88fb"), Color = "#2C8693", Name = "Space", Priority = 10f },
                        new { ID = new Guid("40e0baf7-3b80-4866-b9ae-3a2e77ad88fb"), Color = "#2C8693", Name = "Security", Priority = 5f },
                        new { ID = new Guid("b3e0baf7-3b80-4866-b9ae-3a2e77ad88fb"), Color = "#2C8693", Name = "Hardware", Priority = 5.5f },
                        new { ID = new Guid("a1e0baf7-3b80-4866-b9ae-3a2e77ad88fb"), Color = "#2C8693", Name = "Quality Assurance", Priority = 5.8f },
                        new { ID = new Guid("84754987-6f3f-4b5e-a79d-a61b13a61647"), Color = "#2C8693", Name = "eSports", Priority = 8.5f },
                        new { ID = new Guid("44754987-6f3f-4b5e-a79d-a61b13a61647"), Color = "#2C8693", Name = "iGaming", Priority = 9f },
                        new { ID = new Guid("497ff497-33d2-434c-a1db-5a722d94078f"), Color = "#2C8693", Name = "General Tech", Priority = 8f },
                        new { ID = new Guid("527ff497-33d2-434c-a1db-5a722d94078f"), Color = "#2C8693", Name = "Infrastructure", Priority = 4f },
                        new { ID = new Guid("317ff497-33d2-434c-a1db-5a722d94078f"), Color = "#2C8693", Name = "Software Development", Priority = 0f },
                        new { ID = new Guid("847ff497-33a2-424c-a1db-5a722d94078f"), Color = "#2C8693", Name = "Design", Priority = 6f },
                        new { ID = new Guid("e17226a6-bed1-44f5-863f-3970bb634fce"), Color = "#2C869", Name = ".NET", Priority = 1f }
                    );
                });

            modelBuilder.Entity("NewsletterCurator.Data.Newsitem", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CategoryID");

                    b.Property<DateTimeOffset>("DateTime");

                    b.Property<string>("ImageURL");

                    b.Property<bool>("IsAlreadySent");

                    b.Property<string>("Summary")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("URL")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasAlternateKey("URL");

                    b.HasIndex("CategoryID");

                    b.ToTable("Newsitems");

                    b.HasData(
                        new { ID = new Guid("d68f05e8-94f8-4e99-9b03-08d6329b2519"), CategoryID = new Guid("e17226a6-bed1-44f5-863f-3970bb634fce"), DateTime = new DateTimeOffset(new DateTime(2018, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), IsAlreadySent = false, Summary = "For the past couple of years, Microsoft has been developing two forms of the SignalR – the original ASP.NET SignalR library and the newer ASP.NET Core SignalR.  This fall will see the last major update to the legacy ASP.NET SignalR library.", Title = "ASP.NET SignalR 2.4 to Add Azure Support", URL = "https://www.infoq.com/news/2018/10/aspnet-signalr" },
                        new { ID = new Guid("0a8a1ca1-29e9-473e-1b07-08d632b276cb"), CategoryID = new Guid("40e0baf7-3b80-4866-b9ae-3a2e77ad88fb"), DateTime = new DateTimeOffset(new DateTime(2018, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), ImageURL = "https://regmedia.co.uk/2018/01/23/mr_freeze.jpg", IsAlreadySent = false, Summary = "Hardware hackers bring cold boot attacks out of the deep freeze", Title = "You'll never guess what you can do once you steal a laptop, reflash the BIOS, and reboot it", URL = "https://www.theregister.co.uk/2018/09/14/cold_boot_attack_reloaded/" },
                        new { ID = new Guid("d501a11e-26a3-423b-1b06-08d632b276cb"), CategoryID = new Guid("40e0baf7-3b80-4866-b9ae-3a2e77ad88fb"), DateTime = new DateTimeOffset(new DateTime(2018, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), ImageURL = "https://cdn.wccftech.com/wp-content/uploads/2018/09/apple-a12-bionic-header-wccftech.com_-740x418.jpg", IsAlreadySent = false, Summary = "Apple's A12 and S4 processor upgrade boot-level security. Take a look here for all of the changes and more.", Title = "4 New Security Features For Apple A12 And S4 That Weren't Mentioned Onstage", URL = "https://wccftech.com/4-new-security-features-for-apple-a12-and-s4-that-werent-mentioned-onstage/" },
                        new { ID = new Guid("6df0545e-0b4b-4162-f391-08d632ced619"), CategoryID = new Guid("317ff497-33d2-434c-a1db-5a722d94078f"), DateTime = new DateTimeOffset(new DateTime(2018, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), ImageURL = "https://www.confluent.io/wp-content/uploads/Event-Driven-2.0-–-Data-as-a-Service.png", IsAlreadySent = false, Summary = "Streaming systems have led to far richer approaches than the event-driven architectures of old. In the future, data will be as automated and self-service as infrastructure is today, in the form of data as a service.", Title = "Event Driven 2.0: Data as a Service | Confluent", URL = "https://www.confluent.io/blog/event-driven-2-0-data-service" }
                    );
                });

            modelBuilder.Entity("NewsletterCurator.Data.Subscriber", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset?>("DateSubscribed");

                    b.Property<DateTimeOffset?>("DateUnsubscribed");

                    b.Property<DateTimeOffset?>("DateValidated");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Subscribers");
                });

            modelBuilder.Entity("NewsletterCurator.Data.Newsitem", b =>
                {
                    b.HasOne("NewsletterCurator.Data.Category", "Category")
                        .WithMany("Newsitems")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
