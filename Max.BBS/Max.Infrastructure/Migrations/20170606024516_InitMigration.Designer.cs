using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Max.Infrastructure;
using Max.ApplicationCore.Entities;

namespace Max.Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20170606024516_InitMigration")]
    partial class InitMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Max.ApplicationCore.Entities.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreateOn");

                    b.Property<string>("Email");

                    b.Property<DateTime>("LastReplyTime");

                    b.Property<string>("LastReplyUserId");

                    b.Property<int>("NodeId");

                    b.Property<int>("ReplyCount");

                    b.Property<string>("Title");

                    b.Property<int>("Top");

                    b.Property<int>("Type");

                    b.Property<string>("UserId");

                    b.Property<int>("ViewCount");

                    b.HasKey("Id");

                    b.HasIndex("LastReplyUserId");

                    b.HasIndex("NodeId");

                    b.HasIndex("UserId");

                    b.ToTable("Topic");
                });

            modelBuilder.Entity("Max.ApplicationCore.Entities.TopicNode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateOn");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("NodeName");

                    b.Property<int>("Order");

                    b.Property<int>("ParentId");

                    b.HasKey("Id");

                    b.ToTable("TopicNode");
                });

            modelBuilder.Entity("Max.ApplicationCore.Entities.TopicReply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateOn");

                    b.Property<string>("ReplyContent");

                    b.Property<string>("ReplyEmail");

                    b.Property<string>("ReplyUserId");

                    b.Property<int>("TopicId");

                    b.HasKey("Id");

                    b.HasIndex("ReplyUserId");

                    b.HasIndex("TopicId");

                    b.ToTable("TopicReply");
                });

            modelBuilder.Entity("Max.ApplicationCore.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Avatar");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreateOn");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("GitHub");

                    b.Property<DateTime>("LastTime");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Profile");

                    b.Property<int>("Score");

                    b.Property<string>("SecurityStamp");

                    b.Property<int>("TopicCount");

                    b.Property<int>("TopicReplyCount");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("Url");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Max.ApplicationCore.Entities.UserCollection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateOn");

                    b.Property<int>("State");

                    b.Property<int>("TopicId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("UserCollection");
                });

            modelBuilder.Entity("Max.ApplicationCore.Entities.UserMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreateOn");

                    b.Property<string>("ReceiveUserId");

                    b.Property<string>("SendUserId");

                    b.Property<int>("State");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("ReceiveUserId");

                    b.HasIndex("SendUserId");

                    b.ToTable("UserMessage");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Max.ApplicationCore.Entities.User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Max.ApplicationCore.Entities.User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Max.ApplicationCore.Entities.User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Max.ApplicationCore.Entities.Topic", b =>
                {
                    b.HasOne("Max.ApplicationCore.Entities.User", "LastReplyUser")
                        .WithMany()
                        .HasForeignKey("LastReplyUserId");

                    b.HasOne("Max.ApplicationCore.Entities.TopicNode", "Node")
                        .WithMany()
                        .HasForeignKey("NodeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Max.ApplicationCore.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Max.ApplicationCore.Entities.TopicReply", b =>
                {
                    b.HasOne("Max.ApplicationCore.Entities.User", "ReplyUser")
                        .WithMany()
                        .HasForeignKey("ReplyUserId");

                    b.HasOne("Max.ApplicationCore.Entities.Topic")
                        .WithMany("Replys")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Max.ApplicationCore.Entities.UserCollection", b =>
                {
                    b.HasOne("Max.ApplicationCore.Entities.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Max.ApplicationCore.Entities.UserMessage", b =>
                {
                    b.HasOne("Max.ApplicationCore.Entities.User", "ReceiveUser")
                        .WithMany()
                        .HasForeignKey("ReceiveUserId");

                    b.HasOne("Max.ApplicationCore.Entities.User", "SendUser")
                        .WithMany()
                        .HasForeignKey("SendUserId");
                });
        }
    }
}
