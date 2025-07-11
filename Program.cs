﻿

using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Quizyy.Model;
using Quizyy.Controller;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{

	private static void Main(string[] args)
	{
		
		using (var context = new MyBaseContext())
		{
			/*
			string path = "E:\\Studia\\kck\\danefiszki2.txt";
			string[] lines = File.ReadAllLines(path);
			foreach (var line in lines)
			{
				string[] elements = line.Split(';');
				if (elements.Length == 3)
				{

					int id = Convert.ToInt32(elements[0]);
					string concept = elements[1];
					string definition = elements[2];

					var neww = new FlashCardsModel
					{
						id = id,
						concept = concept,
						definition = definition
					};
					context.FlashCards.Add(neww);
				}
			}
			context.SaveChanges();
			*/
			/*
			string path = "E:\\Studia\\kck\\danepytanie2.txt";
			string[] lines = File.ReadAllLines(path);
			foreach (var line in lines)
			{
				string[] elements = line.Split(';');
				if (elements.Length == 6)
				{

					int id = Convert.ToInt32(elements[0]);
					string question = elements[1];
					string answer = elements[2];
					string incorrectans1 = elements[3];
					string incorrectans2 = elements[4];
					string incorrectans3 = elements[5];


					var neww = new WriteModel
					{
						id = id,
						question = question,
						answer = answer,
						incorrectans1=incorrectans1,
						incorrectans2=incorrectans2,
						incorrectans3=incorrectans3
					};
					context.Writes.Add(neww);
				}
			}
			context.SaveChanges();
			*/
			context.Dispose();
		}





		MainController builder=new MainController();


	}
	[DllImport("Kernel32")]
	public static extern void AllocConsole();
	[DllImport("kernel32.dll")]
	public static extern IntPtr GetConsoleWindow();
	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
	static bool isConsoleOpen = false;
	public static void OpenConsole()
	{
		if (isConsoleOpen) {
			AllocConsole();
			isConsoleOpen = true;
		}
		else
		{
			IntPtr consoleWindow=GetConsoleWindow();
			ShowWindow(consoleWindow, 5);
		}
	}
	public static void CloseConsole()
	{
		IntPtr consoleWindow = GetConsoleWindow();
		ShowWindow(consoleWindow, 0);
	}

}
