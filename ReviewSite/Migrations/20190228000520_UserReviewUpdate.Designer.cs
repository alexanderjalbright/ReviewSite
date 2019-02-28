﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewSite;

namespace ReviewSite.Migrations
{
    [DbContext(typeof(ReviewContext))]
    [Migration("20190228000520_UserReviewUpdate")]
    partial class UserReviewUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewSite.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new { CategoryId = 1, Name = "C#" },
                        new { CategoryId = 2, Name = "Python" }
                    );
                });

            modelBuilder.Entity("ReviewSite.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvgRating");

                    b.Property<int>("CategoryId");

                    b.Property<string>("ImageURL");

                    b.Property<string>("Overview");

                    b.Property<string>("Summary");

                    b.Property<string>("Title");

                    b.HasKey("ReviewId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new { ReviewId = 1, CategoryId = 1, ImageURL = "/Images/machinelearning.jpg", Overview = "Learn to use machine learning to your advantage.", Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", Title = "Machine Learning" },
                        new { ReviewId = 2, CategoryId = 2, ImageURL = "/Images/pythonforeveryone.jpg", Overview = "It really is for everybody!", Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", Title = "Python For Everybody" },
                        new { ReviewId = 3, CategoryId = 1, ImageURL = "/Images/wwkd.jpg", Overview = "What would Kyle do?", Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", Title = "WWKD?" }
                    );
                });

            modelBuilder.Entity("ReviewSite.Models.UserReview", b =>
                {
                    b.Property<int>("UserReviewId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment");

                    b.Property<decimal>("Rating");

                    b.Property<int>("ReviewId");

                    b.Property<string>("UserName");

                    b.HasKey("UserReviewId");

                    b.HasIndex("ReviewId");

                    b.ToTable("UserReviews");

                    b.HasData(
                        new { UserReviewId = 1, Comment = "Its free!", Rating = 3.3m, ReviewId = 1, UserName = "MoocJunkie" },
                        new { UserReviewId = 2, Comment = "You get what you pay for and it's free.", Rating = 4.1m, ReviewId = 1, UserName = "SwagYoloFleekDabs" },
                        new { UserReviewId = 3, Comment = "The instructors are racist.", Rating = 3.9m, ReviewId = 1, UserName = "xXx_DragonSlayer_xXx" },
                        new { UserReviewId = 4, Comment = "The instructors love you like their own family!", Rating = 4.9m, ReviewId = 2, UserName = "JoeLovesFishing_USA" },
                        new { UserReviewId = 5, Comment = "If I could experience Groundhog Day here, I'd still never get enough.", Rating = 5.0m, ReviewId = 2, UserName = "elDiablo1992" },
                        new { UserReviewId = 6, Comment = "This place attracts weirdos.", Rating = 4.1m, ReviewId = 2, UserName = "W3CanC0d31T" },
                        new { UserReviewId = 7, Comment = "I'd rather pay for college than this.", Rating = 2.2m, ReviewId = 3, UserName = "anegronjr" },
                        new { UserReviewId = 8, Comment = "The carpets smell like urine.", Rating = 1.7m, ReviewId = 3, UserName = "alexanderjalbright" },
                        new { UserReviewId = 9, Comment = "The coffee has a peculiar taste.", Rating = 2.2m, ReviewId = 3, UserName = "khanishvili" },
                        new { UserReviewId = 10, Comment = "PICK UP YOUR STARBUCKS CUPS!", Rating = 2.3m, ReviewId = 3, UserName = "jen3ten" },
                        new { UserReviewId = 11, Comment = "I've learned more from 6th graders.", Rating = 2.0m, ReviewId = 3, UserName = "MaryMcGeary" },
                        new { UserReviewId = 12, Comment = "I can't see the board.", Rating = 1.5m, ReviewId = 3, UserName = "mroyski" },
                        new { UserReviewId = 13, Comment = "(╯°□°）╯︵ ┻━┻", Rating = 3.0m, ReviewId = 3, UserName = "aldenmolina" },
                        new { UserReviewId = 14, Comment = "I think we can all agree that what Kyle would do and what Kyle will do are two different things.", Rating = 3.0m, ReviewId = 3, UserName = "JoeScheiman" }
                    );
                });

            modelBuilder.Entity("ReviewSite.Models.Review", b =>
                {
                    b.HasOne("ReviewSite.Models.Category", "Category")
                        .WithMany("Reviews")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ReviewSite.Models.UserReview", b =>
                {
                    b.HasOne("ReviewSite.Models.Review", "Review")
                        .WithMany("UserReview")
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
