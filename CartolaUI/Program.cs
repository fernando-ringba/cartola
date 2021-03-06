﻿using System.IO;
using CartolaUI.Data;
using CartolaUI.Services;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CartolaUI
{
	public class Program
	{

		public static IConfiguration Configuration { get; set; }

		public static void Main(string[] args)
		{
			BuildWebHost(args).Run();
		
		}

		public static IWebHost BuildWebHost(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>()
				.Build();
	}
}
