using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Entity
{
	public class Lesson
	{
		[Key]
		public int Id { get; set; }
		public string Adi { get; set; }
		public int Kredisi { get; set; }
		public string Ogretmen_Adi { get; set; }
		public bool Durum { get; set; }
    }
}

