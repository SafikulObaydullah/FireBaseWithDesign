using FirebaseAdmin;
using FirebaseAdmin.Auth;
using FireBaseTesting.Models;
using Google.Apis.Auth.OAuth2;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace FireBaseTesting.Controllers
{
   public class HomeController : Controller
   {
      private readonly ILogger<HomeController> _logger;

      public HomeController(ILogger<HomeController> logger)
      {
         _logger = logger;
      }

      public async Task<IActionResult> Index()
      {
         if (FirebaseApp.DefaultInstance == null)
         {
            FirebaseApp.Create(new AppOptions()
            {
               Credential = GoogleCredential.FromFile("C:/Project/Firebase/FireBaseTesting/FireBaseTesting/App_Data/sheiboi-9551f-firebase-adminsdk-f6smq-1e83b8bd4b.json"),
            });
         }
            string uid = "2AkGVFJeRoMxMl5EQdiTHN9W2yS2";
         UserRecord userRecord = await FirebaseAuth.DefaultInstance.GetUserAsync(uid);
         // See the UserRecord reference doc for the contents of userRecord.
         //Console.WriteLine($"Successfully fetched user data: {userRecord.Uid}");
         var userUid = userRecord.Uid;
         //string idToken = "eyJhbGciOiJSUzI1NiIsImtpZCI6ImI2NzE1ZTJmZjcxZDIyMjQ5ODk1MDAyMzY2ODMwNDc3Mjg2Nzg0ZTMiLCJ0eXAiOiJKV1QifQ.eyJpc3MiOiJodHRwczovL3NlY3VyZXRva2VuLmdvb2dsZS5jb20vc2hlaWJvaS05NTUxZiIsImF1ZCI6InNoZWlib2ktOTU1MWYiLCJhdXRoX3RpbWUiOjE2ODM2MjI2MDQsInVzZXJfaWQiOiJRZENaMzBFaDFLZjBpUk5aWmFCWG5xOW83WnAyIiwic3ViIjoiUWRDWjMwRWgxS2YwaVJOWlphQlhucTlvN1pwMiIsImlhdCI6MTY4MzYyMjY5NiwiZXhwIjoxNjgzNjI2Mjk2LCJwaG9uZV9udW1iZXIiOiIrODgwMTY0NzE2MTU1OSIsImZpcmViYXNlIjp7ImlkZW50aXRpZXMiOnsicGhvbmUiOlsiKzg4MDE2NDcxNjE1NTkiXX0sInNpZ25faW5fcHJvdmlkZXIiOiJwaG9uZSJ9fQ.iB2DyNXbDwK-1bIoJGOwpQWc79W9DOmzxV6FFFvGfQHM8OSaVMD1njcb3z48kz7QZQMAofLX1tsp8YhUUQjpqVqY4xfB-21Svj5n7ZGD2Ix_rvoR95ZEeJK-ZGqA6G2aNLFXlidCWfCy8JfSzUoiagp5ZQKfqBwLOatynVQwEZytJpMAXy8c3sxZ5cnB08yn8DtoEoKKOlyTvDkGk2aMtJCT050X-hBD0L6ivFSSJgje466SrrzLq_cO5qwd6oAfd0LAVeKsrWT5NcJYClm75gpJvmksdnXOqRVRwVsPztkamlo6Y2vYOOafSblG5JbdVy8f42qMBIXXgofqPVD_8Q";
         //string tok = "eyJhbGciOiJSUzI1NiIsImtpZCI6ImI2NzE1ZTJmZjcxZDIyMjQ5ODk1MDAyMzY2ODMwNDc3Mjg2Nzg0ZTMiLCJ0eXAiOiJKV1QifQ.eyJpc3MiOiJodHRwczovL3NlY3VyZXRva2VuLmdvb2dsZS5jb20vc2hlaWJvaS05NTUxZiIsImF1ZCI6InNoZWlib2ktOTU1MWYiLCJhdXRoX3RpbWUiOjE2ODM2MjE3NDgsInVzZXJfaWQiOiIyQWtHVkZKZVJvTXhNbDVFUWRpVEhOOVcyeVMyIiwic3ViIjoiMkFrR1ZGSmVSb014TWw1RVFkaVRITjlXMnlTMiIsImlhdCI6MTY4MzYyMTk2MiwiZXhwIjoxNjgzNjI1NTYyLCJwaG9uZV9udW1iZXIiOiIrODgwMTg0NDAxODEyMyIsImZpcmViYXNlIjp7ImlkZW50aXRpZXMiOnsicGhvbmUiOlsiKzg4MDE4NDQwMTgxMjMiXX0sInNpZ25faW5fcHJvdmlkZXIiOiJwaG9uZSJ9fQ.g9zm8eil8biLR_GDXR-r6a14s0egFLMrqGmnj70KL7bviVIeUcTF_zQr0hDgJU6GxI_yFEujN91wrZpuCB1gA9VkbxhxqWDUZguLyj1clsEnd544vjj_I0ftC29Na_vUVmF0Hu6S8-SJRlF3PjCyQ3pUyC-3TKziZ9ahpwW8yig-EAEKFg6-PIR8RKYajb9nvwObErzihX1ANC7zVOuTLrSGHn6istDfWqyNlcpFy390TF2Z4PYg_Nja2JRGOzfKButokuC_Sc6y7kUlQbgq96tnbE9bZDUtBsbUUBoLrdgEDhbeCe2VUoGZ68xgqwOg3m6dcph8owi0UtOvWWUjQw";
         //FirebaseToken decodedToken = await FirebaseAuth.DefaultInstance
         //                             .VerifyIdTokenAsync(tok);
         //string Tokenuid = decodedToken.Uid;
         return View();
      }

      public IActionResult Privacy()
      {
         //var firebase = require('firebase');
         //var firebaseui = require('firebaseui');
         return View();
      }

      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error()
      {
         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
      }
   }
}