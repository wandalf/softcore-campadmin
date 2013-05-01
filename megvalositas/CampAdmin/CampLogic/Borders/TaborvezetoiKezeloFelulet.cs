///////////////////////////////////////////////////////////
//  TáborvezetőiKezelőFelület.cs
//  Implementation of the Class TáborvezetőiKezelőFelület
//  Generated by Enterprise Architect
//  Created on:      26-ápr.-2013 19:57:23
//  Original author: lovi88
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using CampLogic.TaborvezetoFunkciok;
using CampLogic.Borders;
namespace CampLogic.Borders
{
    public class TaborvezetoiKezeloFelulet : KorcsoportVezetoiKezeloFelulet, ITaborVezetoiKezelo
    {

        private SzobaKezelo _SzobaKezelo;
        private TurnusKezelo _TurnusKezelo;
        private HazKezelo _HazKezelo;
        private StatisztikaKezelo _StatisztikaKezelo;

        public TaborvezetoiKezeloFelulet()
        {
            _SzobaKezelo = new SzobaKezelo();
            _TurnusKezelo = new TurnusKezelo();
            _HazKezelo = new HazKezelo();
            _StatisztikaKezelo = new StatisztikaKezelo();
        }


        /// 
        /// <param name="haz"></param>
        public bool HazLetrehozas(Haz haz)
        {
            return _HazKezelo.HázLetrehozas(haz);
        }

        public List<Haz> HazListazas()
        {
            return _HazKezelo.HazListazas();
        }

        /// 
        /// <param name="haz"></param>
        public bool HazModositas(Haz haz)
        {
            return _HazKezelo.HazModositas(haz);
        }

        /// 
        /// <param name="haz"></param>
        public bool HazTorles(Haz haz)
        {
            return _HazKezelo.HazTorles(haz);
        }

        public Statisztika StatisztikaHanyOrszagPerTurnus()
        {
            return _StatisztikaKezelo.HanyOrszagPerTurnus();
        }

        public Statisztika StatisztikaHanyTaborozóPerTurnus()
        {
            return _StatisztikaKezelo.HanyTaborozóPerTurnus();
        }

        /// 
        /// <param name="haz"></param>
        /// <param name="szoba"></param>
        public bool SzobaLetrehozas(Haz haz, Szoba szoba)
        {
            return _SzobaKezelo.SzobaLetrehozas(haz, szoba);
        }

        /// 
        /// <param name="haz"></param>
        public List<Szoba> SzobaListazas(Haz haz)
        {
            return _SzobaKezelo.SzobaListazas(haz);
        }

        public List<Szoba> SzobaListazas()
        {
            return _SzobaKezelo.SzobaListazas();
        }

        /// 
        /// <param name="haz"></param>
        /// <param name="szoba"></param>
        public bool SzobaModositas(Haz haz, Szoba szoba)
        {
            return _SzobaKezelo.SzobaModositas(haz, szoba);

        }

        /// 
        /// <param name="haz"></param>
        /// <param name="szoba"></param>
        public bool SzobaTorol(Haz haz, Szoba szoba)
        {
            return _SzobaKezelo.SzobaTorles(szoba);
        }

        /// 
        /// <param name="turnus"></param>
        public bool TurnusLetrehozas(Turnus turnus)
        {
            return _TurnusKezelo.TurnusLetrehozas(turnus);
        }

        public List<Turnus> TurnusListazas()
        {
            return _TurnusKezelo.TurnusListazas();
        }

        /// 
        /// <param name="turnus"></param>
        public bool TurnusModositas(Turnus turnus)
        {
            return _TurnusKezelo.TurnusModositas(turnus);
        }

    }//end TáborvezetőiKezelőFelület

}//end namespace Borders