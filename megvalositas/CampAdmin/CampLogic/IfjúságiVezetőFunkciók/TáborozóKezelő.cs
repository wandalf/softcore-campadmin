///////////////////////////////////////////////////////////
//  T�boroz�Kezel�.cs
//  Implementation of the Class T�boroz�Kezel�
//  Generated by Enterprise Architect
//  Created on:      26-�pr.-2013 20:00:05
//  Original author: lovi88
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using KorcsoportVezet�Funkci�k;
using T�borvezet�Funkci�k;
using Ifj�s�giVezet�Funkci�k;
using Db;
namespace Ifj�s�giVezet�Funkci�k {
	public class T�boroz�Kezel� {

		public DbConnection conn = new DbConnection();

		public T�boroz�Kezel�(){

		}

		~T�boroz�Kezel�(){

		}

		/// 
		/// <param name="Taborozo"></param>
		/// <param name="csoport"></param>
		public bool CsoporthozRendeles(T�boroz� Taborozo, Csoport csoport){

			return false;
		}

		public List<T�boroz�> TaborozoListazas(){

			return null;
		}

		/// 
		/// <param name="taborozo"></param>
		public bool TaborozoModositasa(T�boroz� taborozo){

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
		/// <param name="ujTaborozo"></param>
		public bool UjTaborozo(T�boroz� ujTaborozo){

			return false;
		}

	}//end T�boroz�Kezel�

}//end namespace Ifj�s�giVezet�Funkci�k