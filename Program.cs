using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.API.Services;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;
using Org.BouncyCastle.Crypto.Engines;
using System;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace InstagramApiProject
{
    class Program
    {   
        static async Task Main(string[] args)
        {
            // Use RegistrationService
            // var registrationService = API
            IInstaApi api = InstaApiBuilder.CreateBuilder()
                // .SetUser(new UserSessionData
                // {
                //     UserName = "USERNAME",
                //     Password = "PASSWORD"
                // })
                .SetUser(new UserSessionData{})
                .UseLogger(new DebugLogger(LogLevel.Exceptions))
                .Build();

            var encryptedPassword = "%23PWD_INSTAGRAM_BROWSER%3A10%3A1720024086%3AAZdQALwuz8Iq15uNj5vYAAitTXVb6Q3RCftXU5g55LGXMd06Jz3VIu6v2%2FgExD3OfY79MKm0ryoLyHuqYftQBKRewFaUQrDFgeIQAEvcsCzGMihu9YHGxkGczzZ7QfbyVumKlm3RLnLYiIuI";
                
            api.RegistrationService.CreateNewAccountWithEmailAsync(
                "brafrossappacro-7714@yopmail.com",
                "brafrossappacro7714",
                "BRfro$$@CPR",
                "brafross appacro",
                "s3da2d",
                new DateTime(2000, 1, 1)
                ).Wait();
        }
    }
}
