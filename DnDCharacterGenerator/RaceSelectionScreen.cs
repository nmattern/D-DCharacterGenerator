using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace DnDCharacterGenerator
{
    public partial class RaceSelectionScreen : Form
    {
        public RaceSelectionScreen()
        {
            InitializeComponent();
        }


        private void IntroductionScreenButton_Click(object sender, EventArgs e)
        {
            var introductionSelectionScreenForm = new IntroductionScreen();
            introductionSelectionScreenForm.Show();
            introductionSelectionScreenForm.Location = this.Location;
            this.Hide();
            introductionSelectionScreenForm.FormClosed += (s, args) => this.Close();
        }

        private void ClassSelectionScreenButton_Click(object sender, EventArgs e)
        {
            PlayerCharacter.RaceText = RaceDescriptionTextBox.Text;
            var backgroundSelectionScreenForm = new ClassSelectionScreencs();
            backgroundSelectionScreenForm.Show();
            backgroundSelectionScreenForm.Location = this.Location;
            this.Hide();
            backgroundSelectionScreenForm.FormClosed += (s, args) => this.Close();
        }

        private void ListOfRacesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RaceDescriptionTextBox.Clear();
            switch (ListOfRacesComboBox.SelectedIndex)
            {
                case 0:
                    {
                        RacePictureImageBox.ImageLocation = "https://media-waterdeep.cursecdn.com/avatars/thumbnails/17/468/150/150/636377891490355427.jpeg";
                        RestClient rClient = new RestClient();
                        rClient.endPoint = "http://dnd5eapi.co/api/races/1";

                        string strResponse = string.Empty;
                        string strCleanedResponse = string.Empty;

                        strResponse = rClient.makeRequest();
                        JSONDeserializer deserializer = new JSONDeserializer();

                        dynamic raceInfo = JsonConvert.DeserializeObject(strResponse);

                        Race race = new Race();
                        race.raceSpeed = raceInfo.speed;

                        int incrementer = 0; 
                        foreach (var num in raceInfo.ability_bonuses)
                        {

                            if (incrementer == 0) { race.StrengthRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 1) { race.DexterityRaceBonus= raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 2) { race.ConstitutionRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 3) { race.IntelligenceRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 4) { race.WisdomRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 5) { race.CharismaRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            incrementer++;
                        }
                        incrementer = 0;
                        race.raceAlignment = raceInfo.alignment;
                        race.raceAge = raceInfo.age;
                        race.raceSize = raceInfo.size;
                        race.raceSizeDescription = raceInfo.size_description;
                        race.raceLanguageDescription = raceInfo.language_desc;


                        RaceDescriptionTextBox.Text += "Speed: " + race.raceSpeed + "\r\n";
                        //RaceDescriptionTextBox.Text += "Ability Bonuses: " + race.ability_bonuses.Strength + "\r\n";
                        RaceDescriptionTextBox.Text += "Strength bonus: " + race.StrengthRaceBonus + ", Dexterity bonus: " + race.DexterityRaceBonus + ", Constitution bonus: " + race.ConstitutionRaceBonus + ", Intelligence bonus: " + race.IntelligenceRaceBonus + ", Wisdom bonus: " + race.WisdomRaceBonus + ", Charisma bonus: " + race.CharismaRaceBonus + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Alignment: " + race.raceAlignment + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Average Age: " + race.raceAge + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Size: " + race.raceSize + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Size Description: " + race.raceSizeDescription + "\r\n";
                        RaceDescriptionTextBox.Text += "Starting Proficiencies: ";
                        foreach (var num in raceInfo.starting_proficiencies)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nChoose (" + raceInfo.starting_proficiency_options.choose + ") Starting Proficiencies: ";
                        foreach (var num in raceInfo.starting_proficiency_options.from)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nLanguages Known: ";
                        foreach (var num in raceInfo.languages)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nLanguage Description: " + race.raceLanguageDescription + "\r\n";
                        RaceDescriptionTextBox.Text += "Traits: ";
                        foreach (var num in raceInfo.traits)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nSubraces: ";
                        foreach (var num in raceInfo.subraces)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\n";
                        break;
                    }
                case 1:
                    {
                        RacePictureImageBox.ImageLocation = "https://media-waterdeep.cursecdn.com/avatars/thumbnails/17/456/150/150/636377890325250045.jpeg";
                        RestClient rClient = new RestClient();
                        rClient.endPoint = "http://dnd5eapi.co/api/races/2";

                        string strResponse = string.Empty;
                        string strCleanedResponse = string.Empty;

                        strResponse = rClient.makeRequest();
                        JSONDeserializer deserializer = new JSONDeserializer();

                        dynamic raceInfo = JsonConvert.DeserializeObject(strResponse);

                        Race race = new Race();
                        race.raceSpeed = raceInfo.speed;

                        int incrementer = 0;
                        foreach (var num in raceInfo.ability_bonuses)
                        {
                            if (incrementer == 0) { race.StrengthRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 1) { race.DexterityRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 2) { race.ConstitutionRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 3) { race.IntelligenceRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 4) { race.WisdomRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 5) { race.CharismaRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            incrementer++;
                        }
                        incrementer = 0;
                        race.raceAlignment = raceInfo.alignment;
                        race.raceAge = raceInfo.age;
                        race.raceSize = raceInfo.size;
                        race.raceSizeDescription = raceInfo.size_description;
                        race.raceLanguageDescription = raceInfo.language_desc;


                        RaceDescriptionTextBox.Text += "Speed: " + race.raceSpeed + "\r\n";
                        //RaceDescriptionTextBox.Text += "Ability Bonuses: " + race.ability_bonuses.Strength + "\r\n";
                        RaceDescriptionTextBox.Text += "Strength bonus: " + race.StrengthRaceBonus + ", Dexterity bonus: " + race.DexterityRaceBonus + ", Constitution bonus: " + race.ConstitutionRaceBonus + ", Intelligence bonus: " + race.IntelligenceRaceBonus + ", Wisdom bonus: " + race.WisdomRaceBonus + ", Charisma bonus: " + race.CharismaRaceBonus + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Alignment: " + race.raceAlignment + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Average Age: " + race.raceAge + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Size: " + race.raceSize + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Size Description: " + race.raceSizeDescription + "\r\n";
                        RaceDescriptionTextBox.Text += "Starting Proficiencies: ";
                        foreach (var num in raceInfo.starting_proficiencies)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nStarting Proficiencies: ";
                        RaceDescriptionTextBox.Text += "\r\nLanguages Known: ";
                        foreach (var num in raceInfo.languages)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nLanguage Description: " + race.raceLanguageDescription + "\r\n";
                        RaceDescriptionTextBox.Text += "Traits: ";
                        foreach (var num in raceInfo.traits)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nSubraces: ";
                        foreach (var num in raceInfo.subraces)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\n";
                        break;
                    }
                case 2:
                    {
                        RacePictureImageBox.ImageLocation = "https://media-waterdeep.cursecdn.com/avatars/thumbnails/17/449/150/150/636377889693945829.jpeg";
                        RestClient rClient = new RestClient();
                        rClient.endPoint = "http://dnd5eapi.co/api/races/3";

                        string strResponse = string.Empty;
                        string strCleanedResponse = string.Empty;

                        strResponse = rClient.makeRequest();
                        JSONDeserializer deserializer = new JSONDeserializer();

                        dynamic raceInfo = JsonConvert.DeserializeObject(strResponse);

                        Race race = new Race();
                        race.raceSpeed = raceInfo.speed;

                        int incrementer = 0;
                        foreach (var num in raceInfo.ability_bonuses)
                        {
                            if (incrementer == 0) { race.StrengthRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 1) { race.DexterityRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 2) { race.ConstitutionRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 3) { race.IntelligenceRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 4) { race.WisdomRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 5) { race.CharismaRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            incrementer++;
                        }
                        incrementer = 0;
                        race.raceAlignment = raceInfo.alignment;
                        race.raceAge = raceInfo.age;
                        race.raceSize = raceInfo.size;
                        race.raceSizeDescription = raceInfo.size_description;
                        race.raceLanguageDescription = raceInfo.language_desc;


                        RaceDescriptionTextBox.Text += "Speed: " + race.raceSpeed + "\r\n";
                        //RaceDescriptionTextBox.Text += "Ability Bonuses: " + race.ability_bonuses.Strength + "\r\n";
                        RaceDescriptionTextBox.Text += "Strength bonus: " + race.StrengthRaceBonus + ", Dexterity bonus: " + race.DexterityRaceBonus + ", Constitution bonus: " + race.ConstitutionRaceBonus + ", Intelligence bonus: " + race.IntelligenceRaceBonus + ", Wisdom bonus: " + race.WisdomRaceBonus + ", Charisma bonus: " + race.CharismaRaceBonus + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Alignment: " + race.raceAlignment + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Average Age: " + race.raceAge + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Size: " + race.raceSize + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Size Description: " + race.raceSizeDescription + "\r\n";
                        RaceDescriptionTextBox.Text += "Starting Proficiencies: ";
                        foreach (var num in raceInfo.starting_proficiencies)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nStarting Proficiencies: ";
                        RaceDescriptionTextBox.Text += "\r\nLanguages Known: ";
                        foreach (var num in raceInfo.languages)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nLanguage Description: " + race.raceLanguageDescription + "\r\n";
                        RaceDescriptionTextBox.Text += "Traits: ";
                        foreach (var num in raceInfo.traits)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nSubraces: ";
                        foreach (var num in raceInfo.subraces)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\n";
                        break;
                    }
                case 3:
                    {
                        RacePictureImageBox.ImageLocation = "https://media-waterdeep.cursecdn.com/avatars/thumbnails/17/415/150/150/636377885173419481.jpeg";
                        RestClient rClient = new RestClient();
                        rClient.endPoint = "http://dnd5eapi.co/api/races/4";

                        string strResponse = string.Empty;
                        string strCleanedResponse = string.Empty;

                        strResponse = rClient.makeRequest();
                        JSONDeserializer deserializer = new JSONDeserializer();

                        dynamic raceInfo = JsonConvert.DeserializeObject(strResponse);

                        Race race = new Race();
                        race.raceSpeed = raceInfo.speed;

                        int incrementer = 0;
                        foreach (var num in raceInfo.ability_bonuses)
                        {
                            if (incrementer == 0) { race.StrengthRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 1) { race.DexterityRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 2) { race.ConstitutionRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 3) { race.IntelligenceRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 4) { race.WisdomRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 5) { race.CharismaRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            incrementer++;
                        }
                        incrementer = 0;
                        race.raceAlignment = raceInfo.alignment;
                        race.raceAge = raceInfo.age;
                        race.raceSize = raceInfo.size;
                        race.raceSizeDescription = raceInfo.size_description;
                        race.raceLanguageDescription = raceInfo.language_desc;


                        RaceDescriptionTextBox.Text += "Speed: " + race.raceSpeed + "\r\n";
                        //RaceDescriptionTextBox.Text += "Ability Bonuses: " + race.ability_bonuses.Strength + "\r\n";
                        RaceDescriptionTextBox.Text += "Strength bonus: " + race.StrengthRaceBonus + ", Dexterity bonus: " + race.DexterityRaceBonus + ", Constitution bonus: " + race.ConstitutionRaceBonus + ", Intelligence bonus: " + race.IntelligenceRaceBonus + ", Wisdom bonus: " + race.WisdomRaceBonus + ", Charisma bonus: " + race.CharismaRaceBonus + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Alignment: " + race.raceAlignment + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Average Age: " + race.raceAge + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Size: " + race.raceSize + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Size Description: " + race.raceSizeDescription + "\r\n";
                        RaceDescriptionTextBox.Text += "Starting Proficiencies: ";
                        foreach (var num in raceInfo.starting_proficiencies)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nStarting Proficiencies: ";
                        RaceDescriptionTextBox.Text += "\r\nLanguages Known: ";
                        foreach (var num in raceInfo.languages)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nLanguage Description: " + race.raceLanguageDescription + "\r\n";
                        RaceDescriptionTextBox.Text += "Traits: ";
                        foreach (var num in raceInfo.traits)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nSubraces: ";
                        foreach (var num in raceInfo.subraces)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\n";
                        break;
                    }
                case 4:
                    {
                        RacePictureImageBox.ImageLocation = "https://media-waterdeep.cursecdn.com/avatars/thumbnails/17/400/150/150/636377883039596116.jpeg";
                        RestClient rClient = new RestClient();
                        rClient.endPoint = "http://dnd5eapi.co/api/races/5";

                        string strResponse = string.Empty;
                        string strCleanedResponse = string.Empty;

                        strResponse = rClient.makeRequest();
                        JSONDeserializer deserializer = new JSONDeserializer();

                        dynamic raceInfo = JsonConvert.DeserializeObject(strResponse);

                        Race race = new Race();
                        race.raceSpeed = raceInfo.speed;

                        int incrementer = 0;
                        foreach (var num in raceInfo.ability_bonuses)
                        {
                            if (incrementer == 0) { race.StrengthRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 1) { race.DexterityRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 2) { race.ConstitutionRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 3) { race.IntelligenceRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 4) { race.WisdomRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 5) { race.CharismaRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            incrementer++;
                        }
                        incrementer = 0;
                        race.raceAlignment = raceInfo.alignment;
                        race.raceAge = raceInfo.age;
                        race.raceSize = raceInfo.size;
                        race.raceSizeDescription = raceInfo.size_description;
                        race.raceLanguageDescription = raceInfo.language_desc;


                        RaceDescriptionTextBox.Text += "Speed: " + race.raceSpeed + "\r\n";
                        //RaceDescriptionTextBox.Text += "Ability Bonuses: " + race.ability_bonuses.Strength + "\r\n";
                        RaceDescriptionTextBox.Text += "Strength bonus: " + race.StrengthRaceBonus + ", Dexterity bonus: " + race.DexterityRaceBonus + ", Constitution bonus: " + race.ConstitutionRaceBonus + ", Intelligence bonus: " + race.IntelligenceRaceBonus + ", Wisdom bonus: " + race.WisdomRaceBonus + ", Charisma bonus: " + race.CharismaRaceBonus + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Alignment: " + race.raceAlignment + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Average Age: " + race.raceAge + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Size: " + race.raceSize + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Size Description: " + race.raceSizeDescription + "\r\n";
                        RaceDescriptionTextBox.Text += "Starting Proficiencies: ";
                        foreach (var num in raceInfo.starting_proficiencies)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nStarting Proficiencies: ";
                        RaceDescriptionTextBox.Text += "\r\nLanguages Known: ";
                        foreach (var num in raceInfo.languages)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nLanguage Description: " + race.raceLanguageDescription + "\r\n";
                        RaceDescriptionTextBox.Text += "Traits: ";
                        foreach (var num in raceInfo.traits)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nSubraces: ";
                        foreach (var num in raceInfo.subraces)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\n";
                        break;
                    }
                case 5:
                    {
                        RacePictureImageBox.ImageLocation = "https://media-waterdeep.cursecdn.com/avatars/thumbnails/17/214/150/150/636377841114911601.jpeg";
                        RestClient rClient = new RestClient();
                        rClient.endPoint = "http://dnd5eapi.co/api/races/6";

                        string strResponse = string.Empty;
                        string strCleanedResponse = string.Empty;

                        strResponse = rClient.makeRequest();
                        JSONDeserializer deserializer = new JSONDeserializer();

                        dynamic raceInfo = JsonConvert.DeserializeObject(strResponse);

                        Race race = new Race();
                        race.raceSpeed = raceInfo.speed;

                        int incrementer = 0;
                        foreach (var num in raceInfo.ability_bonuses)
                        {
                            if (incrementer == 0) { race.StrengthRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 1) { race.DexterityRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 2) { race.ConstitutionRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 3) { race.IntelligenceRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 4) { race.WisdomRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 5) { race.CharismaRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            incrementer++;
                        }
                        incrementer = 0;
                        race.raceAlignment = raceInfo.alignment;
                        race.raceAge = raceInfo.age;
                        race.raceSize = raceInfo.size;
                        race.raceSizeDescription = raceInfo.size_description;
                        race.raceLanguageDescription = raceInfo.language_desc;


                        RaceDescriptionTextBox.Text += "Speed: " + race.raceSpeed + "\r\n";
                        //RaceDescriptionTextBox.Text += "Ability Bonuses: " + race.ability_bonuses.Strength + "\r\n";
                        RaceDescriptionTextBox.Text += "Strength bonus: " + race.StrengthRaceBonus + ", Dexterity bonus: " + race.DexterityRaceBonus + ", Constitution bonus: " + race.ConstitutionRaceBonus + ", Intelligence bonus: " + race.IntelligenceRaceBonus + ", Wisdom bonus: " + race.WisdomRaceBonus + ", Charisma bonus: " + race.CharismaRaceBonus + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Alignment: " + race.raceAlignment + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Average Age: " + race.raceAge + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Size: " + race.raceSize + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Size Description: " + race.raceSizeDescription + "\r\n";
                        RaceDescriptionTextBox.Text += "Starting Proficiencies: ";
                        foreach (var num in raceInfo.starting_proficiencies)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nStarting Proficiencies: ";
                        RaceDescriptionTextBox.Text += "\r\nLanguages Known: ";
                        foreach (var num in raceInfo.languages)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nLanguage Description: " + race.raceLanguageDescription + "\r\n";
                        RaceDescriptionTextBox.Text += "Traits: ";
                        foreach (var num in raceInfo.traits)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nSubraces: ";
                        foreach (var num in raceInfo.subraces)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\n";
                        break;
                    }
                case 6:
                    {
                        RacePictureImageBox.ImageLocation = "https://media-waterdeep.cursecdn.com/avatars/thumbnails/17/460/150/150/636377890745985870.jpeg";
                        RestClient rClient = new RestClient();
                        rClient.endPoint = "http://dnd5eapi.co/api/races/7";

                        string strResponse = string.Empty;
                        string strCleanedResponse = string.Empty;

                        strResponse = rClient.makeRequest();
                        JSONDeserializer deserializer = new JSONDeserializer();

                        dynamic raceInfo = JsonConvert.DeserializeObject(strResponse);

                        Race race = new Race();
                        race.raceSpeed = raceInfo.speed;

                        int incrementer = 0;
                        foreach (var num in raceInfo.ability_bonuses)
                        {
                            if (incrementer == 0) { race.StrengthRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 1) { race.DexterityRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 2) { race.ConstitutionRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 3) { race.IntelligenceRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 4) { race.WisdomRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 5) { race.CharismaRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            incrementer++;
                        }
                        incrementer = 0;
                        race.raceAlignment = raceInfo.alignment;
                        race.raceAge = raceInfo.age;
                        race.raceSize = raceInfo.size;
                        race.raceSizeDescription = raceInfo.size_description;
                        race.raceLanguageDescription = raceInfo.language_desc;


                        RaceDescriptionTextBox.Text += "Speed: " + race.raceSpeed + "\r\n";
                        //RaceDescriptionTextBox.Text += "Ability Bonuses: " + race.ability_bonuses.Strength + "\r\n";
                        RaceDescriptionTextBox.Text += "Strength bonus: " + race.StrengthRaceBonus + ", Dexterity bonus: " + race.DexterityRaceBonus + ", Constitution bonus: " + race.ConstitutionRaceBonus + ", Intelligence bonus: " + race.IntelligenceRaceBonus + ", Wisdom bonus: " + race.WisdomRaceBonus + ", Charisma bonus: " + race.CharismaRaceBonus + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Alignment: " + race.raceAlignment + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Average Age: " + race.raceAge + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Size: " + race.raceSize + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Size Description: " + race.raceSizeDescription + "\r\n";
                        RaceDescriptionTextBox.Text += "Starting Proficiencies: ";
                        foreach (var num in raceInfo.starting_proficiencies)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nStarting Proficiencies: ";
                        RaceDescriptionTextBox.Text += "\r\nLanguages Known: ";
                        foreach (var num in raceInfo.languages)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nLanguage Description: " + race.raceLanguageDescription + "\r\n";
                        RaceDescriptionTextBox.Text += "Traits: ";
                        foreach (var num in raceInfo.traits)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nSubraces: ";
                        foreach (var num in raceInfo.subraces)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\n";
                        break;
                    }
                case 7:
                    {
                        RacePictureImageBox.ImageLocation = "https://media-waterdeep.cursecdn.com/avatars/thumbnails/17/746/150/150/636378331319294770.jpeg";
                        RestClient rClient = new RestClient();
                        rClient.endPoint = "http://dnd5eapi.co/api/races/8";

                        string strResponse = string.Empty;
                        string strCleanedResponse = string.Empty;

                        strResponse = rClient.makeRequest();
                        JSONDeserializer deserializer = new JSONDeserializer();

                        dynamic raceInfo = JsonConvert.DeserializeObject(strResponse);

                        Race race = new Race();
                        race.raceSpeed = raceInfo.speed;

                        int incrementer = 0;
                        foreach (var num in raceInfo.ability_bonuses)
                        {
                            if (incrementer == 0) { race.StrengthRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 1) { race.DexterityRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 2) { race.ConstitutionRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 3) { race.IntelligenceRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 4) { race.WisdomRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 5) { race.CharismaRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            incrementer++;
                        }
                        incrementer = 0;
                        race.raceAlignment = raceInfo.alignment;
                        race.raceAge = raceInfo.age;
                        race.raceSize = raceInfo.size;
                        race.raceSizeDescription = raceInfo.size_description;
                        race.raceLanguageDescription = raceInfo.language_desc;


                        RaceDescriptionTextBox.Text += "Speed: " + race.raceSpeed + "\r\n";
                        //RaceDescriptionTextBox.Text += "Ability Bonuses: " + race.ability_bonuses.Strength + "\r\n";
                        RaceDescriptionTextBox.Text += "Strength bonus: " + race.StrengthRaceBonus + ", Dexterity bonus: " + race.DexterityRaceBonus + ", Constitution bonus: " + race.ConstitutionRaceBonus + ", Intelligence bonus: " + race.IntelligenceRaceBonus + ", Wisdom bonus: " + race.WisdomRaceBonus + ", Charisma bonus: " + race.CharismaRaceBonus + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Alignment: " + race.raceAlignment + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Average Age: " + race.raceAge + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Size: " + race.raceSize + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Size Description: " + race.raceSizeDescription + "\r\n";
                        RaceDescriptionTextBox.Text += "Starting Proficiencies: ";
                        foreach (var num in raceInfo.starting_proficiencies)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nStarting Proficiencies: ";
                        RaceDescriptionTextBox.Text += "\r\nLanguages Known: ";
                        foreach (var num in raceInfo.languages)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nLanguage Description: " + race.raceLanguageDescription + "\r\n";
                        RaceDescriptionTextBox.Text += "Traits: ";
                        foreach (var num in raceInfo.traits)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nSubraces: ";
                        foreach (var num in raceInfo.subraces)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\n";
                        break;
                    }
                case 8:
                    {
                        RacePictureImageBox.ImageLocation = "https://media-waterdeep.cursecdn.com/avatars/thumbnails/17/931/150/150/636378855466216266.png";
                        RestClient rClient = new RestClient();
                        rClient.endPoint = "http://dnd5eapi.co/api/races/9";

                        string strResponse = string.Empty;
                        string strCleanedResponse = string.Empty;

                        strResponse = rClient.makeRequest();
                        JSONDeserializer deserializer = new JSONDeserializer();

                        dynamic raceInfo = JsonConvert.DeserializeObject(strResponse);

                        Race race = new Race();
                        race.raceSpeed = raceInfo.speed;

                        int incrementer = 0;
                        foreach (var num in raceInfo.ability_bonuses)
                        {
                            if (incrementer == 0) { race.StrengthRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 1) { race.DexterityRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 2) { race.ConstitutionRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 3) { race.IntelligenceRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 4) { race.WisdomRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            else if (incrementer == 5) { race.CharismaRaceBonus = raceInfo.ability_bonuses[incrementer]; }
                            incrementer++;
                        }
                        incrementer = 0;
                        race.raceAlignment = raceInfo.alignment;
                        race.raceAge = raceInfo.age;
                        race.raceSize = raceInfo.size;
                        race.raceSizeDescription = raceInfo.size_description;
                        race.raceLanguageDescription = raceInfo.language_desc;


                        RaceDescriptionTextBox.Text += "Speed: " + race.raceSpeed + "\r\n";
                        //RaceDescriptionTextBox.Text += "Ability Bonuses: " + race.ability_bonuses.Strength + "\r\n";
                        RaceDescriptionTextBox.Text += "Strength bonus: " + race.StrengthRaceBonus + ", Dexterity bonus: " + race.DexterityRaceBonus + ", Constitution bonus: " + race.ConstitutionRaceBonus + ", Intelligence bonus: " + race.IntelligenceRaceBonus + ", Wisdom bonus: " + race.WisdomRaceBonus + ", Charisma bonus: " + race.CharismaRaceBonus + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Alignment: " + race.raceAlignment + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Average Age: " + race.raceAge + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Size: " + race.raceSize + "\r\n";
                        RaceDescriptionTextBox.Text += "Race Size Description: " + race.raceSizeDescription + "\r\n";
                        RaceDescriptionTextBox.Text += "Starting Proficiencies: ";
                        foreach (var num in raceInfo.starting_proficiencies)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nStarting Proficiencies: ";
                        RaceDescriptionTextBox.Text += "\r\nLanguages Known: ";
                        foreach (var num in raceInfo.languages)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nLanguage Description: " + race.raceLanguageDescription + "\r\n";
                        RaceDescriptionTextBox.Text += "Traits: ";
                        foreach (var num in raceInfo.traits)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\nSubraces: ";
                        foreach (var num in raceInfo.subraces)
                        {
                            RaceDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        RaceDescriptionTextBox.Text += "\r\n";
                        break;
                    }
            }
        }

        private void RaceSelectionScreen_Load(object sender, EventArgs e)
        {
            ListOfRacesComboBox.Items.Add("Dwarf");
            ListOfRacesComboBox.Items.Add("Elf");
            ListOfRacesComboBox.Items.Add("Halfling");
            ListOfRacesComboBox.Items.Add("Human");
            ListOfRacesComboBox.Items.Add("Dragonborn");
            ListOfRacesComboBox.Items.Add("Gnome");
            ListOfRacesComboBox.Items.Add("Half-Elf");
            ListOfRacesComboBox.Items.Add("Half-Orc");
            ListOfRacesComboBox.Items.Add("Tiefling");
        }

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        public string RaceText
        {
            get { return this.RaceDescriptionTextBox.Text; }
        }
    }
}
