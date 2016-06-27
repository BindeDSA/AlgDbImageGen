using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Mega.Painter
{
	class ColorScheme
	{
		public static string[] faces = { "u", "f", "fl", "bl", "br", "br" };
		public string[] Scheme = { "grey", "lime", "#FB8C00", "lightblue", "palegoldenrod", "deeppink" };

		public ColorScheme()
		{
		}

		public ColorScheme(string[] scheme)
		{
			Scheme = scheme;
		}
		public string GetFace(string face)
		{
			switch (face)
			{
				case "u": return Scheme[0];
				case "f": return Scheme[1];
				case "fl": return Scheme[2];
				case "bl": return Scheme[3];
				case "br": return Scheme[4];
				case "fr": return Scheme[5];
			}
			return "white";
		}
	}
}
