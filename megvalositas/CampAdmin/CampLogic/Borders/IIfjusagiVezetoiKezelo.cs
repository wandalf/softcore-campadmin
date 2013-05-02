///////////////////////////////////////////////////////////
//  IIfj�s�giVezet�iKezel�.cs
//  Implementation of the Interface IIfj�s�giVezet�iKezel�
//  Generated by Enterprise Architect
//  Created on:      26-�pr.-2013 19:57:22
//  Original author: lovi88
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CampLogic.KorcsoportVezetoFunkciok;
using CampLogic.IfjusagiVezetoFunkciok;
using CampLogic.TaborvezetoFunkciok;
namespace CampLogic.Borders {
	public interface IIfjusagiVezetoiKezelo {

		/// 
		/// <param name="csoport"></param>
        bool CsoporthozRendeles(Taborozo Taborozo, Csoport csoport);

        bool SzobahozRendeles(Taborozo Taborozo, Szoba szoba);

		/// 
		/// <param name="path"></param>
		bool ImportFilebol(string path);

		List<Taborozo> TaborozoListazas();

		/// 
		/// <param name="t�boroz�"></param>
		bool TaborozoModositasa(Taborozo t�boroz�);

		/// 
		/// <param name="taborozo"></param>
		bool TaborozoTorles(Taborozo taborozo);

		/// 
		/// <param name="taborozo"></param>
		bool UjTaborozo(Taborozo taborozo);
	}//end IIfj�s�giVezet�iKezel�

}//end namespace Borders