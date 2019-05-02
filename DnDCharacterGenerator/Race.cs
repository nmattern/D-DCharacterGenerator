using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator
{
    public class Race
    {
        private int _raceSpeed;
        public int raceSpeed
        {
            get { return _raceSpeed; }
            set { _raceSpeed = value; }
        }

        private List<int> _raceAbilityBonuses = new List<int>();
        public List<int> raceAbilityBonuses
        {
            get { return _raceAbilityBonuses; }
        }

        private string _raceAlignment;
        public string raceAlignment
        {
            get { return _raceAlignment; }
            set { _raceAlignment = value; }
        }

        private string _raceSize;
        public string raceSize
        {
            get { return _raceSize; }
            set { _raceSize = value; }
        }

        private string _raceSizeDescription;
        public string raceSizeDescription
        {
            get { return _raceSizeDescription; }
            set { _raceSizeDescription = value; }
        }

        private List<string> _raceStartingProficiencies;
        public List<string> raceStartingProficiencies
        {
            get { return _raceStartingProficiencies; }
        }
    }
}
