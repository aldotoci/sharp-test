using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.API.Services;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;
using System;
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
                .UseLogger(new DebugLogger(LogLevel.Exceptions))
                .Build();
        
            api.RegistrationService.CreateNewAccountWithEmailAsync(
                "brafrossappacro-7714@yopmail.com",
                "brafrossappacro7714",
                "BRfro$$@CPR",
                "brafross appacro").Wait();
        }
    }
}
