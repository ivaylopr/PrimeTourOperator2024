using Microsoft.AspNetCore.Identity;
using PrimeTourOperator.Infrastructure.Data.Models;
using System.Globalization;
using static PrimeTourOperator.Infrastructure.Constants.DataConstants;

namespace PrimeTourOperator.Infrastructure.Data.DataSeed
{
    internal class SeedData
    {
        public IdentityUser AgentUser { get; set; }
        public IdentityUser GuestUser { get; set; }
        public Agent Agent { get; set; }
        public Hotel BlackSeaStar { get; set; }
        public Hotel BanskoResort { get; set; }
        public Hotel PortoBelloHotel { get; set; }

        public RoomCategory TwoBedRoom { get; set; }
        public RoomCategory StudioRoom { get; set; }
        public RoomCategory PresidentApartment { get; set; }
        public Room BlackSeaTwoBed { get; set; }
        public Room BlackSeaStudio { get; set; }
        public Room BlackSeaPresidentApart { get; set; }
        public Room BanskoResortTwoBed { get; set; }
        public Room BanskoResortStudio { get; set; }
        public Room BanskoResortPresidentApart { get; set; }
        public Room PortoBelloTwoBed { get; set; }
        public Room PortoBelloStudio { get; set; }
        public Room PortoBelloPresidentApart { get; set; }
        public SeasonalEmployment KitchenHelper { get; set; }
        public SeasonalEmployment HouseKeeper { get; set; }
        public SeasonalEmployment RoomService { get; set; }
        public SeasonalEmployment Receptionist { get; set; }
        public SeasonalEmployment Piccolo { get; set; }
        public SeasonalEmployment ParkingAssistance { get; set; }
        public SeasonalEmployment PoolLifeGuard { get; set; }
        public SeasonalEmployment Waiter { get; set; }
        public SeasonalEmployment Barman { get; set; }
        public SeasonalEmployment DishWasher { get; set; }
        public VacationCategory SeaCategory { get; set; }
        public VacationCategory MountainCategory { get; set; }
        public VacationCategory SpaCategory { get; set; }
        public Vacation BlackSeaStarAllInclusive { get; set; }
        public Vacation BanskoResortAllInclusive { get; set; }
        public Vacation PortoBelloAllInclusive { get; set; }
        public SeedData()
        {
            SeedUsers();
            SeedAgent();
            SeedRoomCategory();
            SeedHotel();
            SeedVacationCategory();
            SeedRoom();
            SeedSeasonEmploymentOffers();
            SeedVacation();
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();
            AgentUser = new IdentityUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "agent@mail.com",
                NormalizedUserName = "agent@mail.com",
                Email = "agent@mail.com",
                NormalizedEmail = "agent@mail.com"
            };
            AgentUser.PasswordHash = hasher.HashPassword(AgentUser, "agent123");
            GuestUser = new IdentityUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com"
            };
            GuestUser.PasswordHash = hasher.HashPassword(AgentUser, "guest123");
        }
        private void SeedAgent()
        {
            Agent = new Agent()

            { Id = 1, PhoneNumber = "+359888888888", UserId = AgentUser.Id };
        }
        private void SeedHotel() 
        {
            BlackSeaStar = new Hotel()
            {
                Id= 1,
                Name = "Black Sea Star",
                Spa = true,
                Pool = true,
                AllInclusivePrice = 100,
                ChildrenAnimators = true,
                Location = "Sozopol, Bulgaria",
                Capacity = 200,
                CategoryStars = 3
            };
            BanskoResort = new Hotel() 
            {
                Id = 2,
                Name = "Bansko Resort",
                Spa = true,
                Pool = true,
                AllInclusivePrice = 200,
                ChildrenAnimators = true,
                Location = "Bansko, Bulgaria",
                Capacity = 300,
                CategoryStars = 4
            };
            PortoBelloHotel = new Hotel()
            {
                Id = 3,
                Name = "Porto Bello",
                Spa = true,
                Pool = true,
                AllInclusivePrice=150,
                ChildrenAnimators = true,
                Location = "Kos iceland, Greece",
                Capacity = 400,
                CategoryStars = 5
            };
        }
        private void SeedRoomCategory()
        {
            TwoBedRoom = new RoomCategory()
            {
                Id = 1,
                Name = "Two bed room",
                Description = "Room appropriate for two person, included: bathroom, balcony, refrigerator, air conditioning, room service."
            };
            StudioRoom = new RoomCategory()
            {
                Id = 2,
                Name = "Studio",
                Description = "Room appropriate for family, " +
                "included: bathroom, balcony, refrigerator, air conditioning, room service, two single beds, kitchen."
            }; 
            PresidentApartment = new RoomCategory()
            {
                Id = 3,
                Name = "President apartment",
                Description = "Room appropriate for people who loves the lux. All extras and services of the hotel is available."
            };
        }
        private void SeedRoom()
        {
            BlackSeaTwoBed = new Room()
            {
                Id = 1,
                Title = "Two person room",
                Price = 70.00M,
                RoomCategoryId = 1,
                Count = 10
            };
            BlackSeaStudio = new Room()
            {
                Id = 2,
                Title="Studio room",
                Price = 90.00M,
                RoomCategoryId=2,
                Count = 5
            };
            BlackSeaPresidentApart = new Room()
            {
                Id = 3,
                Title = "President apartment",
                Price = 300.00M,
                RoomCategoryId=3,
                Count = 1
            };
            BanskoResortTwoBed = new Room()
            {
                Id = 4,
                Title = "Bansko Resort two bed room",
                Price = 100.00m,
                RoomCategoryId=1,
                Count = 30
            };
            BanskoResortStudio = new Room()
            {
                Id = 5,
                Title = "Bansko Resort studio",
                Price = 150.00M,
                RoomCategoryId=2,
                Count = 10
            };
            BanskoResortPresidentApart = new Room()
            {
                Id = 6,
                Title = "Bansko Resort president apartment",
                Price = 800.00M,
                RoomCategoryId=3,
                Count = 2
            };
            PortoBelloTwoBed = new Room()
            {
                Id = 7,
                Title = "Porto Bello two bed room",
                Price = 120,
                RoomCategoryId=1,
                Count = 35
            };
            PortoBelloStudio = new Room()
            {
                Id = 8,
                Title = "Porto bello studio",
                Price = 180,
                RoomCategoryId=2,
                Count = 15
            };
            PortoBelloPresidentApart = new Room()
            {
                Id = 9,
                Title = "Porto Bello president apartment",
                Price = 500.00M,
                RoomCategoryId=3,
                Count = 1
            };

        }
        private void SeedVacationCategory()
        {
            SeaCategory = new VacationCategory()
            {
                Id = 1,
                VacationType = "Sea holiday",
                Description = "Holiday next to the sea."
            };

            MountainCategory = new VacationCategory()
            {
                Id = 2,
                VacationType = "Mountain holiday",
                Description = "Holiday in the mountain"
            };
            SpaCategory = new VacationCategory()
            {
                Id = 3,
                VacationType = "Spa holiday",
                Description = "Vacation in SPA resort"
            };
        }
        private void SeedSeasonEmploymentOffers()
        {
            KitchenHelper = new SeasonalEmployment()
            {
                Id = 1,
                Title = "Kitchen helper",
                Description = "Person who help to the shefs and performs the given tasks",
                HourlyWage = 5.5M,
                StartDate = DateTime.ParseExact("06/03/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("06/09/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                AgentId = 1,
                HotelId = 1
            };
            HouseKeeper = new SeasonalEmployment()
            {
                Id = 2,
                Title = "House keeper",
                Description = "Cleaning rooms and common areas and preparing the hotel for the customers",
                HourlyWage = 5.5M,
                StartDate = DateTime.ParseExact("06/03/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("06/09/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                AgentId = 1,
                HotelId = 1
            };
            RoomService = new SeasonalEmployment()
            {
                Id = 3,
                Title = "Room service",
                Description = "Delivering and service to the hotel customers' room",
                HourlyWage = 6.5M,
                StartDate = DateTime.ParseExact("03/03/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("16/10/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                AgentId = 1,
                HotelId = 3
            };
            Receptionist = new SeasonalEmployment()
            {
                Id = 4,
                Title = "Receptionist",
                Description = "Working to the reception, assistance to the customers problems and questions",
                HourlyWage = 7.5M,
                StartDate = DateTime.ParseExact("06/10/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("06/04/2025 10:00", DateFormat, CultureInfo.InvariantCulture),
                AgentId = 1,
                HotelId = 2
            };
            Piccolo = new SeasonalEmployment()
            {
                Id = 5,
                Title = "Piccolo",
                Description = "Welcoming and full assistance with customers' luggage",
                HourlyWage = 3.5M,
                StartDate = DateTime.ParseExact("03/03/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("06/10/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                AgentId = 1,
                HotelId = 3
            };
            ParkingAssistance = new SeasonalEmployment()
            {
                Id = 6,
                Title = "Parking assistance",
                Description = "Welcoming and parking the cusstomers cars on the hotel parking",
                HourlyWage = 3.5M,
                StartDate = DateTime.ParseExact("06/10/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("09/04/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                AgentId = 1,
                HotelId = 2
            };
            PoolLifeGuard = new SeasonalEmployment()
            {
                Id = 7,
                Title = "Lifeguard",
                Description = "Lifeguard on the hotel pool",
                HourlyWage = 8.00M,
                StartDate = DateTime.ParseExact("06/03/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("06/10/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                AgentId = 1,
                HotelId = 3
            };
            Waiter = new SeasonalEmployment()
            {
                Id = 8,
                Title = "Waiter",
                Description = "Waiter at the hotel restorant",
                HourlyWage = 3.00M,
                StartDate = DateTime.ParseExact("06/04/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("06/10/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                AgentId = 1,
                HotelId = 1
            };
            Barman = new SeasonalEmployment()
            {
                Id = 9,
                Title = "Barman",
                Description = "Bartendering and enterteiment",
                HourlyWage = 6.00M,
                StartDate = DateTime.ParseExact("06/02/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("18/10/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                AgentId = 1,
                HotelId = 3
            };
            DishWasher = new SeasonalEmployment()
            {
                Id = 10,
                Title = "Dishwasher",
                Description = "Washing the dishes in the kitchen",
                HourlyWage = 4.50M,
                StartDate = DateTime.ParseExact("06/04/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("06/10/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                AgentId = 1,
                HotelId = 1
            };
        }
        private void SeedVacation()
        {
            BlackSeaStarAllInclusive = new Vacation()
            {
                Id = 1,
                Title = "Black Sea Star Sozopol-AllInclusive offer",
                Price = 800.00M,
                VacationCategoryId = 1,
                EnrollmentDeadline = DateTime.ParseExact("06/04/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                StartDate = DateTime.ParseExact("06/06/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("15/06/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                Description = "Ten days all inclusive holiday next to Black sea in one of the oldest towns in Europe." +
                "Two bed room plus",
                Location = "Sozopol, Bulgaria",
                AgentId = 1,
                HotelId = 1,
                RoomId = 1,
                AllInclusive = true
            };
            BanskoResortAllInclusive = new Vacation()
            {
                Id = 2,
                Title = "Bansko Resort-AllInclusive offer",
                Price = 2000.00M,
                VacationCategoryId = 1,
                EnrollmentDeadline = DateTime.ParseExact("06/04/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                StartDate = DateTime.ParseExact("06/06/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("15/06/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                Description = "Ten days all inclusive holiday next to Black sea in one of the oldest towns in Europe." +
                "Studio room plus",
                Location = "Sozopol, Bulgaria",
                AgentId = 1,
                HotelId = 2,
                RoomId=2,
                AllInclusive = true
            };
            PortoBelloAllInclusive = new Vacation()
            {
                Id = 3,
                Title = "Bansko Resort-AllInclusive offer",
                Price = 2000.00M,
                VacationCategoryId = 1,
                EnrollmentDeadline = DateTime.ParseExact("06/04/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                StartDate = DateTime.ParseExact("06/07/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("15/07/2024 10:00", DateFormat, CultureInfo.InvariantCulture),
                Description = "Ten days all inclusive holiday next to Agean sea in born place of Hipocrates." +
                "Studio room plus",
                Location = "Sozopol, Bulgaria",
                AgentId = 1,
                HotelId = 3,
                RoomId=3,
                AllInclusive = true
            };
        }
    }
}
