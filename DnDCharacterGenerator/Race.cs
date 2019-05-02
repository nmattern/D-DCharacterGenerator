using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator
{
    public class Race
    {
        private string _raceSpeed = "test";
        public string raceSpeed
        {
            get { return _raceSpeed; }
            set { _raceSpeed = value; }
        }

        private string _raceAge = string.Empty;
        public string raceAge
        {
            get { return _raceAge; }
            set { _raceAge = value; }
        }


        private int _StrengthRaceBonus;
        public int StrengthRaceBonus
        {
            get { return _StrengthRaceBonus; }
            set { _StrengthRaceBonus = value; }
        }

        private int _DexterityRaceBonus;
        public int DexterityRaceBonus
        {
            get { return _DexterityRaceBonus; }
            set { _DexterityRaceBonus = value; }
        }

        private int _ConstitutionRaceBonus;
        public int ConstitutionRaceBonus
        {
            get { return _ConstitutionRaceBonus; }
            set { _ConstitutionRaceBonus = value; }
        }

        private int _IntelligenceRaceBonus;
        public int IntelligenceRaceBonus
        {
            get { return _IntelligenceRaceBonus; }
            set { _IntelligenceRaceBonus = value; }
        }

        private int _WisdomRaceBonus;
        public int WisdomRaceBonus
        {
            get { return _WisdomRaceBonus; }
            set { _WisdomRaceBonus = value; }
        }

        private int _CharismaRaceBonus;
        public int CharismaRaceBonus
        {
            get { return _CharismaRaceBonus; }
            set { _CharismaRaceBonus = value; }
        }

        private string _raceAlignment = string.Empty;
        public string raceAlignment
        {
            get { return _raceAlignment; }
            set { _raceAlignment = value; }
        }

        private string _raceSize = string.Empty;
        public string raceSize
        {
            get { return _raceSize; }
            set { _raceSize = value; }
        }

        private string _raceSizeDescription = string.Empty;
        public string raceSizeDescription
        {
            get { return _raceSizeDescription; }
            set { _raceSizeDescription = value; }
        }

        private string _raceLanguageDescription = string.Empty;
        public string raceLanguageDescription
        {
            get { return _raceLanguageDescription; }
            set { _raceLanguageDescription = value; }
        }

    }
}
