using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Currs8__lab6_Autentificare.Controllers
{
	public class PasswordHasherController : Controller
	{
		// GET: PasswordHasher
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult getSHAString(string unecryptedString)
		{
			var sha256Result = sha256(unecryptedString);
			return Json(
				new
				{
					sha256 = sha256Result
				},
		JsonRequestBehavior.AllowGet);
		}

	public ActionResult getSaltedString(string unecryptedString)
	{
		var saltedResult = sha256(saltFunction(unecryptedString));
		return Json(
			new
			{
				salted = saltedResult
			},
	JsonRequestBehavior.AllowGet);
}


	//public ActionResult getEncryptedStrings(string unecryptedString)
	//	{
	//		//return Json(new { sha256 = "sha256string", slated = "salted" },
	//		//JsonRequestBehavior.AllowGet);

	//		var sha256Result = sha256(unecryptedString);
	//		var saltedResult = sha256(saltFunction(unecryptedString));

	//		return Json(
	//			new
	//			{
	//				sha256 = sha256Result,
	//				salted = saltedResult
	//			},
	//			JsonRequestBehavior.AllowGet);
	//		}

			private string saltFunction(string input)
			{
			string resultSalt = "";
			 for(int i = 0; i< input.Length; i++)
			{
				if(i !=0 && i % 2 == 0)
				{
					resultSalt += "12";
				}
				resultSalt += input.ElementAt(i);
			}
				return resultSalt;
			
			}


			[NonAction]
			private string sha256(string input)
			{
				var crypt = new SHA256Managed();
				string hash = String.Empty;
				byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(input));
				foreach (byte theByte in crypto)
				{
					hash += theByte.ToString("x2");
				}
				return hash;
			}

	}
}