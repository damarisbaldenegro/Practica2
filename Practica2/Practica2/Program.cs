
using System;

namespace Practica2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Dame la cantidad del Producto 1:");
			int cantiproducto1 = int.Parse( Console.ReadLine());
			Console.WriteLine("Dame la Descripcion 1:");
			string descripcion1 = Console.ReadLine();
			Console.WriteLine("Dame el Precio Unitario 1:");
			int  precioUnita1 = int.Parse( Console.ReadLine());
			
			Console.WriteLine("Dame la cantidad del Producto 2:");
			int cantiproducto2 = int.Parse( Console.ReadLine());
			Console.WriteLine("Dame la Descripcion 2:");
			string descripcion2 = Console.ReadLine();
			Console.WriteLine("Dame el Precio Unitario 2:");
			int  precioUnita2 = int.Parse( Console.ReadLine());
			
			Console.WriteLine("Dame la cantidad del Producto 3:");
			int cantiproducto3 = int.Parse( Console.ReadLine());
			Console.WriteLine("Dame la Descripcion 3:");
			string descripcion3 = Console.ReadLine();
			Console.WriteLine("Dame el Precio Unitario 3:");
			int  precioUnita3 = int.Parse( Console.ReadLine());
			
			double resultado1 = cantiproducto1 * precioUnita1;
			double resultado2 = cantiproducto2 * precioUnita2;
			double resultado3 = cantiproducto3 * precioUnita3;
			
			
			Console.WriteLine(" " +cantiproducto1+ "  " + descripcion1 + "  " + resultado1);
			Console.WriteLine(" " +cantiproducto2+ "  " + descripcion2 + "  " + resultado2);
			Console.WriteLine(" " +cantiproducto3+ "  " + descripcion3 + "  " + resultado3);
			
			
			double subtotal = resultado1+resultado2+resultado3;
			double iva = 0.16 * subtotal;
			double total = subtotal + iva;
			
			Console.WriteLine(" Subtotal =" +subtotal);
			Console.WriteLine(" Iva =" + iva);
			Console.WriteLine(" Total =" + total);
			Console.ReadKey(true);
		}
	}
}