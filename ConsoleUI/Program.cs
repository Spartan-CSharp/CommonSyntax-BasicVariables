using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string firstname = "Pierre";
			string lastname = "Plourde";

			string fullname = $"{firstname} {lastname}";

			int age = 47;

			bool isalive = true;

			string phonenumber = "905-439-7645";

			Console.WriteLine($"Hi, {fullname}, you are {age} years old, your phone number is {phonenumber}, and you are alive? {isalive}.");

			_ = Console.ReadLine();
		}
	}
}
