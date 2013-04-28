///////////////////////////////////////////////////////////
//  ICsoportKezel�.cs
//  Implementation of the Interface ICsoportKezel�
//  Generated by Enterprise Architect
//  Created on:      26-�pr.-2013 20:01:00
//  Original author: lovi88
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace CampLogic.KorcsoportVezet�Funkci�k {
	public interface ICsoportKezel�<T> {

		/// 
		/// <param name="csoport"></param>
		bool Letrehoz(T csoport);

		List<T> Listaz();

		/// 
		/// <param name="csoport"></param>
		bool Modosit(T csoport);

		/// 
		/// <param name="csoport"></param>
		bool Torol(T csoport);
	}//end ICsoportKezel�

}//end namespace KorcsoportVezet�Funkci�k