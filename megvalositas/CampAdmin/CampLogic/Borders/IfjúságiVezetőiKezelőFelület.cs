///////////////////////////////////////////////////////////
//  Ifj�s�giVezet�iKezel�Fel�let.cs
//  Implementation of the Class Ifj�s�giVezet�iKezel�Fel�let
//  Generated by Enterprise Architect
//  Created on:      26-�pr.-2013 19:57:22
//  Original author: lovi88
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using KorcsoportVezet�Funkci�k;
using Ifj�s�giVezet�Funkci�k;
using T�borvezet�Funkci�k;
using Borders;

namespace Borders {
	public class Ifj�s�giVezet�iKezel�Fel�let : IIfj�s�giVezet�iKezel� {

		public T�boroz�ImportKezel� m_T�boroz�ImportKezel�;
		public T�boroz�Kezel� m_T�boroz�Kezel�;

		public Ifj�s�giVezet�iKezel�Fel�let(){

		}

		/// 
		/// <param name="Taborozo"></param>
		/// <param name="csoport"></param>
		public bool CsoporthozRendeles(T�boroz� Taborozo, Csoport csoport){

			return false;
		}

		/// 
		/// <param name="path"></param>
		public bool ImportFilebol(string path){

			return false;
		}

		public List<T�boroz�> TaborozoListazas(){

			return null;
		}

		/// 
		/// <param name="t�boroz�"></param>
		public bool TaborozoModositasa(T�boroz� t�boroz�){

			return false;
		}

		/// 
		/// <param name="T�boroz�"></param>
		/// <param name="Szoba"></param>
		public void T�boroz�Szob�hozRendel�s(T�boroz� T�boroz�, Szoba Szoba){

		}

		/// 
		/// <param name="taborozo"></param>
		public bool TaborozoTorles(T�boroz� taborozo){

			return false;
		}

		/// 
		/// <param name="taborozo"></param>
		public bool UjTaborozo(T�boroz� taborozo){

			return false;
		}

    }//end Ifj�s�giVezet�iKezel�Fel�let

}//end namespace Borders