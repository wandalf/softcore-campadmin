///////////////////////////////////////////////////////////
//  Statisztika.cs
//  Implementation of the Class Statisztika
//  Generated by Enterprise Architect
//  Created on:      26-�pr.-2013 20:01:56
//  Original author: lovi88
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace CampLogic.T�borvezet�Funkci�k
{
    public class Statisztika
    {

        public Statisztika()
        {

        }


        public Statisztika(List<string> oszlopnevek, List<List<string>> sorok)
        {
            Oszlopnevek = oszlopnevek;
            Sorok = sorok;
        }

        public List<string> Oszlopnevek { get; set; }

        public List<List<string>> Sorok { get; set; }

    }//end Statisztika

}//end namespace T�borvezet�Funkci�k