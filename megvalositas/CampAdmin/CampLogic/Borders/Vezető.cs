///////////////////////////////////////////////////////////
//  Vezet�.cs
//  Implementation of the Class Vezet�
//  Generated by Enterprise Architect
//  Created on:      26-�pr.-2013 19:57:23
//  Original author: lovi88
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using Borders;
namespace Borders {
	public class Vezet� : IVezet� {

		public Vezet�(){

		}

		~Vezet�(){

		}

		public string Jelszo{ get; set; }

		public string Nev{ get; set; }

		public Vezet�T�pus Tipus{
			get{
				return Tipus;
			}
			set{
				Tipus = value;
			}
		}

		public int Vezet�Id{ get; set; }

	}//end Vezet�

}//end namespace Borders