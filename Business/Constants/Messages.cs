﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Car Added";
        public static string CarDeleted = "Car deleted";
        public static string CarUpdated = "Car updated";
        public static string CarListed = "Car listed";
        public static string CarCouldNotAdd = "Car could not add";
        public static string CarCouldNotUpdated = "Car could not update";
        public static string BrandAdded = "Brand added";
        public static string BrandUpdated = "Brand updated";
        public static string BrandDeleted = "Brand deleted";
        public static string BrandListed = "Brand listed";
        public static string ColorAdded = "Color added";
        public static string ColorUpdated = "Color updated";
        public static string ColorDeleted = "Color deleted";
        public static string ColorListed= "Color Listed";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarDailyPriceInvalid = "Araba günlük fiyatı 0'dan büyük olmalıdır.";

        public static string MaintenanceTime = "Sistem bakımda";

        public static string UserAdded = "User added";
        public static string UserUpdated = "User updated";
        public static string UserDeleted = "User deleted";
        public static string UserListed = "User listed";
        public static string CustomerAdded = "Customer added";
        public static string CustomerUpdated = "Customer updated";
        public static string CustomerDeleted = "Customer deleted";
        public static string CustomerListed = "Customer listed";

        public static string Failed="Error";
        public static string RentalAdded="Araç kiralandı.";
        public static string RentalNotAdded = "Araç kiralandı.";
    }
}
