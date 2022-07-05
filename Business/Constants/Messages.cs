using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarsListed = "Cars listed";
        public static string CarListed = "Car listed";
        public static string CarAdded = "Car added";
        public static string CarNameInvalid = "Car name invalid";
        public static string DailyPriceInvalid = "Daily price invalid";
        public static string ReturnInvalid = "In order for the car to be rented, the car must be delivered";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password error";
        public static string SuccessfulLogin = "Successful login";
        public static string UserAlreadyExists = "User already exists";
        public static string UserRegistered = "User registered";
        public static string AccessTokenCreated = "Access token created";
        public static string AuthorizationDenied = "You are not authorized";
        public static string CarUpdated = "Car updated";
    }
}
