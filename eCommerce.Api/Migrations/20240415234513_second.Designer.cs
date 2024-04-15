﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace eCommerce.Api.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20240415234513_second")]
    partial class second
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("eCommerce.Api.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "blacktea.jpg",
                            Name = "Black Tea"
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "greentea.jpg",
                            Name = "Green Tea"
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "whitetea.jpg",
                            Name = "White Tea"
                        },
                        new
                        {
                            Id = 4,
                            ImageUrl = "oolongtea.jpg",
                            Name = "Oolong Tea"
                        },
                        new
                        {
                            Id = 5,
                            ImageUrl = "caffeinefreetea.jpg",
                            Name = "Caffeine Free "
                        });
                });

            modelBuilder.Entity("eCommerce.Api.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<double>("OrderTotal")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("eCommerce.Api.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("eCommerce.Api.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBestSelling")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTrending")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Detail = "A delectable medley with an enticing floral aroma. Rose Black combines loose leaf black tea with smooth notes of rose and a bright finish. Rose Black is delicious hot or cold brewed and poured over ice. The perfect sip for any time of day.",
                            ImageUrl = "roseblacktea.jpg",
                            IsBestSelling = true,
                            IsTrending = false,
                            Name = "Rose Black Tea",
                            Price = 25.0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Detail = "A customer favorite. Start your day in a bold way with our loose leaf organic Earl Grey Crème tea. This is a remarkable black tea blend that is hand blended with fragrant oil of bergamot for citrus notes followed by a touch of French vanilla for a rich and robust finish.",
                            ImageUrl = "earlgreycremetea.jpg",
                            IsBestSelling = false,
                            IsTrending = false,
                            Name = "Earl Grey Crème Tea",
                            Price = 28.0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Detail = "Packed with flavor, our traditional blend of organic loose leaf black tea is perfect for starting the day. This robust black tea brews smooth and malty, with a clean finish.",
                            ImageUrl = "englishbreakfasttea.jpg",
                            IsBestSelling = false,
                            IsTrending = false,
                            Name = "English Breakfast Tea",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Detail = "A unique twist on a traditional favorite. Our London tea blend elicits sweet, fragrant floral notes followed by a rich citrusy finish. This organic lavender earl grey tea is a morning or afternoon delight.",
                            ImageUrl = "londontea.jpg",
                            IsBestSelling = true,
                            IsTrending = true,
                            Name = "London Tea",
                            Price = 30.0
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Detail = "Start your day in a bold way with our Classic Black blended black tea. This organic loose leaf black tea is a hand-blended mix of whole leaf black tea that is certain to delight all of your senses.",
                            ImageUrl = "classicblacktea.jpg",
                            IsBestSelling = false,
                            IsTrending = true,
                            Name = "Classic Black Tea",
                            Price = 22.0
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Detail = "This proprietary blend of traditional organic tea and purifying herbs combine delicious flavor and a gentle yet effective way of regulating the body's natural cleansing process. With citrus, berry, and spicy notes, this ayurvedic tea is a perfect cup of bliss.",
                            ImageUrl = "cleansetea.jpg",
                            IsBestSelling = true,
                            IsTrending = false,
                            Name = "Cleanse Tea",
                            Price = 23.0
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Detail = "Our award-winning Meyer Lemon Tea blend combines a delightful medley of bright citrus flavors with our premium classic green tea for a vibrant cup. Enjoy the bright flavor notes of real Meyer lemons, complemented by the sweet grassiness of our ultra-premium green teas in one refreshing cup.",
                            ImageUrl = "meyerlemontea.jpg",
                            IsBestSelling = false,
                            IsTrending = false,
                            Name = "Meyer Lemon Tea",
                            Price = 26.0
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Detail = "An award-winning white and green tea blend with a touch of bergamot. Liquid Jade delivers a clean, fresh taste with light notes of honey and citrus.",
                            ImageUrl = "liquidjadetea.jpg",
                            IsBestSelling = false,
                            IsTrending = false,
                            Name = "Liquid Jade Tea",
                            Price = 32.0
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            Detail = "An elevated twist on the classic Gen Mai Cha, our Kyoto green tea is sourced and blended by master tea blenders in Kyoto, Japan. This Japanese green tea is a Matcha Iri Genmaicha made with premium Gyokuro green tea, roasty puffed rice, and Ceremonial Matcha.",
                            ImageUrl = "kyototea.jpg",
                            IsBestSelling = false,
                            IsTrending = true,
                            Name = "Kyoto Tea",
                            Price = 35.0
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Detail = "An organic green tea that has been repeatedly baked and scented with fresh and fragrant night-blooming jasmine blossoms. This jasmine green tea has beautiful floral and sweet notes.",
                            ImageUrl = "jasminereservetea.jpg",
                            IsBestSelling = false,
                            IsTrending = false,
                            Name = "Jasmine Reserve Tea",
                            Price = 30.0
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            Detail = "Organic peppermint and spearmint are hand-blended with organic gunpowder green tea to create this refreshing blend. This cool, soothing mint tea adds a refreshing touch to any meal.",
                            ImageUrl = "moroccanminttea.jpg",
                            IsBestSelling = true,
                            IsTrending = false,
                            Name = "Moroccan Mint Tea",
                            Price = 25.0
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            Detail = "Experience the fragrance and flavors of Japan's annual cherry blossom season with our Sakura white tea blend. With delicate floral and fruity notes, this Sakura blossom tea exudes a sweet cherry aroma in each cup.",
                            ImageUrl = "sakuratea.jpg",
                            IsBestSelling = false,
                            IsTrending = false,
                            Name = "Sakura Tea",
                            Price = 30.0
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            Detail = "The essence of fresh-picked peaches infuses the senses in this organic white tea infusion. Steeps a light and refreshing cup perfect for a mid-afternoon lift.",
                            ImageUrl = "whitepeachtea.jpg",
                            IsBestSelling = true,
                            IsTrending = false,
                            Name = "White Peach Tea",
                            Price = 27.0
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            Detail = "Organic Silver needle is the most sought after white tea and is only harvested for a few days each year in the northern district of Fujian, China. This Chinese Silver Needle tea has a light golden flush with a unique savory aroma and a woodsy body, perfect for any time of day.",
                            ImageUrl = "silverneedletea.jpg",
                            IsBestSelling = false,
                            IsTrending = false,
                            Name = "Silver Needle Tea",
                            Price = 35.0
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 3,
                            Detail = "Silver-tipped white tea harvested at the base of the Himalayas in Darjeeling. Rare and unique bud and leaf grades are hand harvested in small quantities during the first flush season of 2023. The high elevation, time of harvest, and minimal processing allow the buds and leaves to deliver a delicate flavor profile and smooth round finish.",
                            ImageUrl = "himalayanwhitetea.jpg",
                            IsBestSelling = false,
                            IsTrending = false,
                            Name = "Himalayan White Tea",
                            Price = 32.0
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 3,
                            Detail = "A dreamy, tropical coconut white tea. White Coconut Crème tea has a light body and smooth creamy texture. A customer favorite both hot and iced.",
                            ImageUrl = "whitecoconutcremetea.jpg",
                            IsBestSelling = false,
                            IsTrending = false,
                            Name = "White Coconut Crème Tea",
                            Price = 29.0
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 4,
                            Detail = "Our Mandarin Silk tea is a smooth, rich blend of Pouchong tea leaves blended with lemon myrtle and vanilla essence. With creamy and citrus notes, this oolong tea is certain to delight your senses.",
                            ImageUrl = "mandarinsilktea.jpg",
                            IsBestSelling = false,
                            IsTrending = false,
                            Name = "Mandarin Silk Tea",
                            Price = 22.0
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 4,
                            Detail = "Succulent schizandra berries and sweet amber oolong leaves are blended with the tender essence of plum to create our Plum Oolong tea. This tart and fruity plum tea lends a beautiful cup at any time of day.",
                            ImageUrl = "plumoolongtea.jpg",
                            IsBestSelling = false,
                            IsTrending = false,
                            Name = "Plum Oolong Tea",
                            Price = 26.0
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            Detail = "Long, beautiful leaves unwind and unfurl when steeped to release a smooth, rich flavor. Our Wuyi Oolong tea is 60-80% oxidized and steeps a deep golden hue with crisp and earthy tones and a slightly peppery finish.",
                            ImageUrl = "wuyioolongtea.jpg",
                            IsBestSelling = false,
                            IsTrending = false,
                            Name = "Wuyi Oolong Tea",
                            Price = 24.0
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            Detail = "Grown and harvested in Fujian, China at a garden elevation of 1500m and straight into your morning cup. This Chinese oolong tea is 90% oxidized and steeps dark amber in color with smooth, sweet flavor notes of honey and aged bourbon and a finish of orange blossom and spice.",
                            ImageUrl = "crimsonoolongtea.jpg",
                            IsBestSelling = false,
                            IsTrending = true,
                            Name = "Crimson Oolong Tea",
                            Price = 30.0
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 4,
                            Detail = "Formerly known as 12:00pm, our Peach Oolong Tea blend is a delightfully refreshing midday pick-me-up. This oolong tea blend has a rich woodsy flavor with notes of ripened peaches and a sweet honey finish. Take a moment to treat yourself to this stunning peach tea.",
                            ImageUrl = "peachoolongtea.jpg",
                            IsBestSelling = true,
                            IsTrending = false,
                            Name = "Peach Oolong Tea",
                            Price = 28.0
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 5,
                            Detail = "A calming sleepytime tea with smooth and minty flavor notes. Steep this tea for sleep either to accentuate a midday nap or head to your evening slumber.",
                            ImageUrl = "sleepblend.jpg",
                            IsBestSelling = false,
                            IsTrending = true,
                            Name = "Sleep Blend",
                            Price = 18.0
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 5,
                            Detail = "An invigorating blend of turmeric, ginger, cinnamon, and other fragrant spices, this loose leaf blend draws from Ayurvedic principles to energize and awaken your mind and body--all without caffeine! This autumnal tisane brews to a beautiful copper hue and can be enjoyed at any time of day.",
                            ImageUrl = "brighteyedblend.jpg",
                            IsBestSelling = true,
                            IsTrending = false,
                            Name = "Bright Eyed Blend",
                            Price = 23.0
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 5,
                            Detail = "Our Egyptian Chamomile elicits sweet, calming flavor notes. This tisane is round and soothing with each and every sip, perfect for any time of day.",
                            ImageUrl = "egyptianchamomiletea.jpg",
                            IsBestSelling = false,
                            IsTrending = false,
                            Name = "Egyptian Chamomile Tea",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 5,
                            Detail = "This vanilla rooibos tea is a delectable infusion of enticingly sweet and tangy flavors harmoniously complimented by the soothing smoothness of fresh cream. Our Vanilla Berry Truffle tea is an enjoyable dessert blend at any time of day.",
                            ImageUrl = "vanillaberrytruffletea.jpg",
                            IsBestSelling = false,
                            IsTrending = false,
                            Name = "Vanilla Berry Truffle Tea",
                            Price = 25.0
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 5,
                            Detail = "Our Lemon Meringue tea has a light, fluffy texture and a sweet, creamy finish. This rooibos based blend is a delight for any moments of sweet cravings throughout the day.",
                            ImageUrl = "lemonmeringuetea.jpg",
                            IsBestSelling = false,
                            IsTrending = true,
                            Name = "Lemon Meringue Tea",
                            Price = 21.0
                        });
                });

            modelBuilder.Entity("eCommerce.Api.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("eCommerce.Api.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("eCommerce.Api.Models.Order", b =>
                {
                    b.HasOne("eCommerce.Api.Models.User", null)
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eCommerce.Api.Models.OrderDetail", b =>
                {
                    b.HasOne("eCommerce.Api.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerce.Api.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("eCommerce.Api.Models.Product", b =>
                {
                    b.HasOne("eCommerce.Api.Models.Category", null)
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eCommerce.Api.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("eCommerce.Api.Models.Product", null)
                        .WithMany("ShoppingCartItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eCommerce.Api.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("eCommerce.Api.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("eCommerce.Api.Models.Product", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("ShoppingCartItems");
                });

            modelBuilder.Entity("eCommerce.Api.Models.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
