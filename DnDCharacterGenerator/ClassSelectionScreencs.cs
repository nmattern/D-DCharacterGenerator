using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DnDCharacterGenerator
{
    public partial class ClassSelectionScreencs : Form
    {
        public ClassSelectionScreencs()
        {
            InitializeComponent();
        }

        private void RaceSelectionScreenButton_Click(object sender, EventArgs e)
        {
            var alignmentSelectionScreenForm = new RaceSelectionScreen();
            alignmentSelectionScreenForm.Show();
            alignmentSelectionScreenForm.Location = this.Location;
            this.Hide();
            alignmentSelectionScreenForm.FormClosed += (s, args) => this.Close();
        }

        private void Form1Button_Click(object sender, EventArgs e)
        {
            PlayerCharacter.ClassText = ClassDescriptionTextBox.Text;
            var form1 = new Form1();
            form1.Show();
            form1.Location = this.Location;
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
        }

        private void ClassSelectionScreencs_Load(object sender, EventArgs e)
        {
            ListOfClassesComboBox.Items.Add("Barbarian");
            ListOfClassesComboBox.Items.Add("Bard");
            ListOfClassesComboBox.Items.Add("Cleric");
            ListOfClassesComboBox.Items.Add("Druid");
            ListOfClassesComboBox.Items.Add("Fighter");
            ListOfClassesComboBox.Items.Add("Monk");
            ListOfClassesComboBox.Items.Add("Paladin");
            ListOfClassesComboBox.Items.Add("Ranger");
            ListOfClassesComboBox.Items.Add("Rogue");
            ListOfClassesComboBox.Items.Add("Sorcerer");
            ListOfClassesComboBox.Items.Add("Warlock");
            ListOfClassesComboBox.Items.Add("Wizard");
        }

        private void ListOfClassesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassDescriptionTextBox.Clear();
            switch (ListOfClassesComboBox.SelectedIndex)
            {
                case 0:
                    {
                        RestClient rClient = new RestClient();
                        rClient.endPoint = "http://dnd5eapi.co/api/classes/1";
                        RestClient rClientEquipment = new RestClient();
                        rClientEquipment.endPoint = "http://www.dnd5eapi.co/api/startingequipment/1";
                        RestClient rClientLevels = new RestClient();
                        rClientLevels.endPoint = "http://www.dnd5eapi.co/api/classes/Barbarian/levels";
                        string strResponse = string.Empty;
                        string strEquipmentResponse = string.Empty;
                        string strLevelsResponse = string.Empty;

                        strResponse = rClient.makeRequest();
                        strEquipmentResponse = rClientEquipment.makeRequest();
                        strLevelsResponse = rClientLevels.makeRequest();
                        JSONDeserializer deserializer = new JSONDeserializer();

                        dynamic classInfo = JsonConvert.DeserializeObject(strResponse);
                        dynamic equipmentInfo = JsonConvert.DeserializeObject(strEquipmentResponse);
                        dynamic levelInfo = JsonConvert.DeserializeObject(strLevelsResponse);


                        Classes classes = new Classes();

                        classes.classHitDie = classInfo.hit_die;

                        ClassDescriptionTextBox.Text += "Hit Die Per Level: " + classes.classHitDie + "\r\n";
                        ClassDescriptionTextBox.Text += "Choose (" + classInfo.proficiency_choices[0].choice + ") proficiencies: ";
                        foreach (var num in classInfo.proficiency_choices)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nProficiencies: ";
                        foreach (var num in classInfo.proficiencies)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nSaving Throws: ";
                        foreach (var num in classInfo.saving_throws)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nStarting Equipment: ";
                        foreach (var num in equipmentInfo.starting_equipment)
                        {
                            ClassDescriptionTextBox.Text += num.quantity + " " + num.item.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nChoose two more items: ";
                        foreach (var num in equipmentInfo.choice_1)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].item.name.ToString() + ", ";
                        }

                        ClassDescriptionTextBox.Text += "\r\nSubclasses: ";
                        foreach (var num in classInfo.subclasses)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        break;
                    }
                case 1:
                    {
                        RestClient rClient = new RestClient();
                        rClient.endPoint = "http://dnd5eapi.co/api/classes/2";
                        RestClient rClientEquipment = new RestClient();
                        rClientEquipment.endPoint = "http://www.dnd5eapi.co/api/startingequipment/2";
                        RestClient rClientLevels = new RestClient();
                        rClientLevels.endPoint = "http://www.dnd5eapi.co/api/classes/Bard/levels";
                        string strResponse = string.Empty;
                        string strEquipmentResponse = string.Empty;
                        string strLevelsResponse = string.Empty;

                        strResponse = rClient.makeRequest();
                        strEquipmentResponse = rClientEquipment.makeRequest();
                        strLevelsResponse = rClientLevels.makeRequest();
                        JSONDeserializer deserializer = new JSONDeserializer();

                        dynamic classInfo = JsonConvert.DeserializeObject(strResponse);
                        dynamic equipmentInfo = JsonConvert.DeserializeObject(strEquipmentResponse);
                        dynamic levelInfo = JsonConvert.DeserializeObject(strLevelsResponse);


                        Classes classes = new Classes();

                        classes.classHitDie = classInfo.hit_die;

                        ClassDescriptionTextBox.Text += "Hit Die Per Level: " + classes.classHitDie + "\r\n";
                        ClassDescriptionTextBox.Text += "Choose (" + classInfo.proficiency_choices[0].choice + ") proficiencies: ";
                        foreach (var num in classInfo.proficiency_choices)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nProficiencies: ";
                        foreach (var num in classInfo.proficiencies)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nSaving Throws: ";
                        foreach (var num in classInfo.saving_throws)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nStarting Equipment: ";
                        foreach (var num in equipmentInfo.starting_equipment)
                        {
                            ClassDescriptionTextBox.Text += num.quantity + " " + num.item.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nChoose two more items: ";
                        foreach (var num in equipmentInfo.choice_1)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].item.name.ToString() + ", ";
                        }

                        ClassDescriptionTextBox.Text += "\r\nSubclasses: ";
                        foreach (var num in classInfo.subclasses)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        break;
                    }
                case 2:
                    {
                        RestClient rClient = new RestClient();
                        rClient.endPoint = "http://dnd5eapi.co/api/classes/3";
                        RestClient rClientEquipment = new RestClient();
                        rClientEquipment.endPoint = "http://www.dnd5eapi.co/api/startingequipment/3";
                        RestClient rClientLevels = new RestClient();
                        rClientLevels.endPoint = "http://www.dnd5eapi.co/api/classes/Barbarian/levels";
                        string strResponse = string.Empty;
                        string strEquipmentResponse = string.Empty;
                        string strLevelsResponse = string.Empty;

                        strResponse = rClient.makeRequest();
                        strEquipmentResponse = rClientEquipment.makeRequest();
                        strLevelsResponse = rClientLevels.makeRequest();
                        JSONDeserializer deserializer = new JSONDeserializer();

                        dynamic classInfo = JsonConvert.DeserializeObject(strResponse);
                        dynamic equipmentInfo = JsonConvert.DeserializeObject(strEquipmentResponse);
                        dynamic levelInfo = JsonConvert.DeserializeObject(strLevelsResponse);


                        Classes classes = new Classes();

                        classes.classHitDie = classInfo.hit_die;

                        ClassDescriptionTextBox.Text += "Hit Die Per Level: " + classes.classHitDie + "\r\n";
                        ClassDescriptionTextBox.Text += "Choose (" + classInfo.proficiency_choices[0].choice + ") proficiencies: ";
                        foreach (var num in classInfo.proficiency_choices)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nProficiencies: ";
                        foreach (var num in classInfo.proficiencies)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nSaving Throws: ";
                        foreach (var num in classInfo.saving_throws)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nStarting Equipment: ";
                        foreach (var num in equipmentInfo.starting_equipment)
                        {
                            ClassDescriptionTextBox.Text += num.quantity + " " + num.item.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nChoose two more items: ";
                        foreach (var num in equipmentInfo.choice_1)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].item.name.ToString() + ", ";
                        }

                        ClassDescriptionTextBox.Text += "\r\nSubclasses: ";
                        foreach (var num in classInfo.subclasses)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        break;
                    }
                case 3:
                    {
                        RestClient rClient = new RestClient();
                        rClient.endPoint = "http://dnd5eapi.co/api/classes/4";
                        RestClient rClientEquipment = new RestClient();
                        rClientEquipment.endPoint = "http://www.dnd5eapi.co/api/startingequipment/4";
                        RestClient rClientLevels = new RestClient();
                        rClientLevels.endPoint = "http://www.dnd5eapi.co/api/classes/Barbarian/levels";
                        string strResponse = string.Empty;
                        string strEquipmentResponse = string.Empty;
                        string strLevelsResponse = string.Empty;

                        strResponse = rClient.makeRequest();
                        strEquipmentResponse = rClientEquipment.makeRequest();
                        strLevelsResponse = rClientLevels.makeRequest();
                        JSONDeserializer deserializer = new JSONDeserializer();

                        dynamic classInfo = JsonConvert.DeserializeObject(strResponse);
                        dynamic equipmentInfo = JsonConvert.DeserializeObject(strEquipmentResponse);
                        dynamic levelInfo = JsonConvert.DeserializeObject(strLevelsResponse);


                        Classes classes = new Classes();

                        classes.classHitDie = classInfo.hit_die;

                        ClassDescriptionTextBox.Text += "Hit Die Per Level: " + classes.classHitDie + "\r\n";
                        ClassDescriptionTextBox.Text += "Choose (" + classInfo.proficiency_choices[0].choice + ") proficiencies: ";
                        foreach (var num in classInfo.proficiency_choices)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nProficiencies: ";
                        foreach (var num in classInfo.proficiencies)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nSaving Throws: ";
                        foreach (var num in classInfo.saving_throws)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nStarting Equipment: ";
                        foreach (var num in equipmentInfo.starting_equipment)
                        {
                            ClassDescriptionTextBox.Text += num.quantity + " " + num.item.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nChoose two more items: ";
                        foreach (var num in equipmentInfo.choice_1)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].item.name.ToString() + ", ";
                        }

                        ClassDescriptionTextBox.Text += "\r\nSubclasses: ";
                        foreach (var num in classInfo.subclasses)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        break;
                    }
                case 4:
                    {
                        RestClient rClient = new RestClient();
                        rClient.endPoint = "http://dnd5eapi.co/api/classes/5";
                        RestClient rClientEquipment = new RestClient();
                        rClientEquipment.endPoint = "http://www.dnd5eapi.co/api/startingequipment/5";
                        RestClient rClientLevels = new RestClient();
                        rClientLevels.endPoint = "http://www.dnd5eapi.co/api/classes/Barbarian/levels";
                        string strResponse = string.Empty;
                        string strEquipmentResponse = string.Empty;
                        string strLevelsResponse = string.Empty;

                        strResponse = rClient.makeRequest();
                        strEquipmentResponse = rClientEquipment.makeRequest();
                        strLevelsResponse = rClientLevels.makeRequest();
                        JSONDeserializer deserializer = new JSONDeserializer();

                        dynamic classInfo = JsonConvert.DeserializeObject(strResponse);
                        dynamic equipmentInfo = JsonConvert.DeserializeObject(strEquipmentResponse);
                        dynamic levelInfo = JsonConvert.DeserializeObject(strLevelsResponse);


                        Classes classes = new Classes();

                        classes.classHitDie = classInfo.hit_die;

                        ClassDescriptionTextBox.Text += "Hit Die Per Level: " + classes.classHitDie + "\r\n";
                        ClassDescriptionTextBox.Text += "Choose (" + classInfo.proficiency_choices[0].choice + ") proficiencies: ";
                        foreach (var num in classInfo.proficiency_choices)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nProficiencies: ";
                        foreach (var num in classInfo.proficiencies)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nSaving Throws: ";
                        foreach (var num in classInfo.saving_throws)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nStarting Equipment: ";
                        foreach (var num in equipmentInfo.starting_equipment)
                        {
                            ClassDescriptionTextBox.Text += num.quantity + " " + num.item.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nChoose two more items: ";
                        foreach (var num in equipmentInfo.choice_1)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].item.name.ToString() + ", ";
                        }

                        ClassDescriptionTextBox.Text += "\r\nSubclasses: ";
                        foreach (var num in classInfo.subclasses)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        break;
                    }
                case 5:
                    {
                        RestClient rClient = new RestClient();
                        rClient.endPoint = "http://dnd5eapi.co/api/classes/6";
                        RestClient rClientEquipment = new RestClient();
                        rClientEquipment.endPoint = "http://www.dnd5eapi.co/api/startingequipment/6";
                        RestClient rClientLevels = new RestClient();
                        rClientLevels.endPoint = "http://www.dnd5eapi.co/api/classes/Barbarian/levels";
                        string strResponse = string.Empty;
                        string strEquipmentResponse = string.Empty;
                        string strLevelsResponse = string.Empty;

                        strResponse = rClient.makeRequest();
                        strEquipmentResponse = rClientEquipment.makeRequest();
                        strLevelsResponse = rClientLevels.makeRequest();
                        JSONDeserializer deserializer = new JSONDeserializer();

                        dynamic classInfo = JsonConvert.DeserializeObject(strResponse);
                        dynamic equipmentInfo = JsonConvert.DeserializeObject(strEquipmentResponse);
                        dynamic levelInfo = JsonConvert.DeserializeObject(strLevelsResponse);


                        Classes classes = new Classes();

                        classes.classHitDie = classInfo.hit_die;

                        ClassDescriptionTextBox.Text += "Hit Die Per Level: " + classes.classHitDie + "\r\n";
                        ClassDescriptionTextBox.Text += "Choose (" + classInfo.proficiency_choices[0].choice + ") proficiencies: ";
                        foreach (var num in classInfo.proficiency_choices)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nProficiencies: ";
                        foreach (var num in classInfo.proficiencies)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nSaving Throws: ";
                        foreach (var num in classInfo.saving_throws)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nStarting Equipment: ";
                        foreach (var num in equipmentInfo.starting_equipment)
                        {
                            ClassDescriptionTextBox.Text += num.quantity + " " + num.item.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nChoose two more items: ";
                        foreach (var num in equipmentInfo.choice_1)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].item.name.ToString() + ", ";
                        }

                        ClassDescriptionTextBox.Text += "\r\nSubclasses: ";
                        foreach (var num in classInfo.subclasses)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        break;
                    }
                case 6:
                    {
                        RestClient rClient = new RestClient();
                        rClient.endPoint = "http://dnd5eapi.co/api/classes/7";
                        RestClient rClientEquipment = new RestClient();
                        rClientEquipment.endPoint = "http://www.dnd5eapi.co/api/startingequipment/7";
                        RestClient rClientLevels = new RestClient();
                        rClientLevels.endPoint = "http://www.dnd5eapi.co/api/classes/Barbarian/levels";
                        string strResponse = string.Empty;
                        string strEquipmentResponse = string.Empty;
                        string strLevelsResponse = string.Empty;

                        strResponse = rClient.makeRequest();
                        strEquipmentResponse = rClientEquipment.makeRequest();
                        strLevelsResponse = rClientLevels.makeRequest();
                        JSONDeserializer deserializer = new JSONDeserializer();

                        dynamic classInfo = JsonConvert.DeserializeObject(strResponse);
                        dynamic equipmentInfo = JsonConvert.DeserializeObject(strEquipmentResponse);
                        dynamic levelInfo = JsonConvert.DeserializeObject(strLevelsResponse);


                        Classes classes = new Classes();

                        classes.classHitDie = classInfo.hit_die;

                        ClassDescriptionTextBox.Text += "Hit Die Per Level: " + classes.classHitDie + "\r\n";
                        ClassDescriptionTextBox.Text += "Choose (" + classInfo.proficiency_choices[0].choice + ") proficiencies: ";
                        foreach (var num in classInfo.proficiency_choices)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nProficiencies: ";
                        foreach (var num in classInfo.proficiencies)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nSaving Throws: ";
                        foreach (var num in classInfo.saving_throws)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nStarting Equipment: ";
                        foreach (var num in equipmentInfo.starting_equipment)
                        {
                            ClassDescriptionTextBox.Text += num.quantity + " " + num.item.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nChoose two more items: ";
                        foreach (var num in equipmentInfo.choice_1)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].item.name.ToString() + ", ";
                        }

                        ClassDescriptionTextBox.Text += "\r\nSubclasses: ";
                        foreach (var num in classInfo.subclasses)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        break;
                    }
                case 7:
                    {
                        RestClient rClient = new RestClient();
                        rClient.endPoint = "http://dnd5eapi.co/api/classes/8";
                        RestClient rClientEquipment = new RestClient();
                        rClientEquipment.endPoint = "http://www.dnd5eapi.co/api/startingequipment/8";
                        RestClient rClientLevels = new RestClient();
                        rClientLevels.endPoint = "http://www.dnd5eapi.co/api/classes/Barbarian/levels";
                        string strResponse = string.Empty;
                        string strEquipmentResponse = string.Empty;
                        string strLevelsResponse = string.Empty;

                        strResponse = rClient.makeRequest();
                        strEquipmentResponse = rClientEquipment.makeRequest();
                        strLevelsResponse = rClientLevels.makeRequest();
                        JSONDeserializer deserializer = new JSONDeserializer();

                        dynamic classInfo = JsonConvert.DeserializeObject(strResponse);
                        dynamic equipmentInfo = JsonConvert.DeserializeObject(strEquipmentResponse);
                        dynamic levelInfo = JsonConvert.DeserializeObject(strLevelsResponse);


                        Classes classes = new Classes();

                        classes.classHitDie = classInfo.hit_die;

                        ClassDescriptionTextBox.Text += "Hit Die Per Level: " + classes.classHitDie + "\r\n";
                        ClassDescriptionTextBox.Text += "Choose (" + classInfo.proficiency_choices[0].choice + ") proficiencies: ";
                        foreach (var num in classInfo.proficiency_choices)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nProficiencies: ";
                        foreach (var num in classInfo.proficiencies)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nSaving Throws: ";
                        foreach (var num in classInfo.saving_throws)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nStarting Equipment: ";
                        foreach (var num in equipmentInfo.starting_equipment)
                        {
                            ClassDescriptionTextBox.Text += num.quantity + " " + num.item.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nChoose two more items: ";
                        foreach (var num in equipmentInfo.choice_1)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].item.name.ToString() + ", ";
                        }

                        ClassDescriptionTextBox.Text += "\r\nSubclasses: ";
                        foreach (var num in classInfo.subclasses)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        break;
                    }
                case 8:
                    {
                        RestClient rClient = new RestClient();
                        rClient.endPoint = "http://dnd5eapi.co/api/classes/9";
                        RestClient rClientEquipment = new RestClient();
                        rClientEquipment.endPoint = "http://www.dnd5eapi.co/api/startingequipment/9";
                        RestClient rClientLevels = new RestClient();
                        rClientLevels.endPoint = "http://www.dnd5eapi.co/api/classes/Barbarian/levels";
                        string strResponse = string.Empty;
                        string strEquipmentResponse = string.Empty;
                        string strLevelsResponse = string.Empty;

                        strResponse = rClient.makeRequest();
                        strEquipmentResponse = rClientEquipment.makeRequest();
                        strLevelsResponse = rClientLevels.makeRequest();
                        JSONDeserializer deserializer = new JSONDeserializer();

                        dynamic classInfo = JsonConvert.DeserializeObject(strResponse);
                        dynamic equipmentInfo = JsonConvert.DeserializeObject(strEquipmentResponse);
                        dynamic levelInfo = JsonConvert.DeserializeObject(strLevelsResponse);


                        Classes classes = new Classes();

                        classes.classHitDie = classInfo.hit_die;

                        ClassDescriptionTextBox.Text += "Hit Die Per Level: " + classes.classHitDie + "\r\n";
                        ClassDescriptionTextBox.Text += "Choose (" + classInfo.proficiency_choices[0].choice + ") proficiencies: ";
                        foreach (var num in classInfo.proficiency_choices)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nProficiencies: ";
                        foreach (var num in classInfo.proficiencies)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nSaving Throws: ";
                        foreach (var num in classInfo.saving_throws)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nStarting Equipment: ";
                        foreach (var num in equipmentInfo.starting_equipment)
                        {
                            ClassDescriptionTextBox.Text += num.quantity + " " + num.item.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nChoose two more items: ";
                        foreach (var num in equipmentInfo.choice_1)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].item.name.ToString() + ", ";
                        }

                        ClassDescriptionTextBox.Text += "\r\nSubclasses: ";
                        foreach (var num in classInfo.subclasses)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        break;
                    }
                case 9:
                    {
                        RestClient rClient = new RestClient();
                        rClient.endPoint = "http://dnd5eapi.co/api/classes/10";
                        RestClient rClientEquipment = new RestClient();
                        rClientEquipment.endPoint = "http://www.dnd5eapi.co/api/startingequipment/10";
                        RestClient rClientLevels = new RestClient();
                        rClientLevels.endPoint = "http://www.dnd5eapi.co/api/classes/Barbarian/levels";
                        string strResponse = string.Empty;
                        string strEquipmentResponse = string.Empty;
                        string strLevelsResponse = string.Empty;

                        strResponse = rClient.makeRequest();
                        strEquipmentResponse = rClientEquipment.makeRequest();
                        strLevelsResponse = rClientLevels.makeRequest();
                        JSONDeserializer deserializer = new JSONDeserializer();

                        dynamic classInfo = JsonConvert.DeserializeObject(strResponse);
                        dynamic equipmentInfo = JsonConvert.DeserializeObject(strEquipmentResponse);
                        dynamic levelInfo = JsonConvert.DeserializeObject(strLevelsResponse);


                        Classes classes = new Classes();

                        classes.classHitDie = classInfo.hit_die;

                        ClassDescriptionTextBox.Text += "Hit Die Per Level: " + classes.classHitDie + "\r\n";
                        ClassDescriptionTextBox.Text += "Choose (" + classInfo.proficiency_choices[0].choice + ") proficiencies: ";
                        foreach (var num in classInfo.proficiency_choices)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nProficiencies: ";
                        foreach (var num in classInfo.proficiencies)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nSaving Throws: ";
                        foreach (var num in classInfo.saving_throws)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nStarting Equipment: ";
                        foreach (var num in equipmentInfo.starting_equipment)
                        {
                            ClassDescriptionTextBox.Text += num.quantity + " " + num.item.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nChoose two more items: ";
                        foreach (var num in equipmentInfo.choice_1)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].item.name.ToString() + ", ";
                        }

                        ClassDescriptionTextBox.Text += "\r\nSubclasses: ";
                        foreach (var num in classInfo.subclasses)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        break;
                    }
                case 10:
                    {
                        RestClient rClient = new RestClient();
                        rClient.endPoint = "http://dnd5eapi.co/api/classes/11";
                        RestClient rClientEquipment = new RestClient();
                        rClientEquipment.endPoint = "http://www.dnd5eapi.co/api/startingequipment/11";
                        RestClient rClientLevels = new RestClient();
                        rClientLevels.endPoint = "http://www.dnd5eapi.co/api/classes/Barbarian/levels";
                        string strResponse = string.Empty;
                        string strEquipmentResponse = string.Empty;
                        string strLevelsResponse = string.Empty;

                        strResponse = rClient.makeRequest();
                        strEquipmentResponse = rClientEquipment.makeRequest();
                        strLevelsResponse = rClientLevels.makeRequest();
                        JSONDeserializer deserializer = new JSONDeserializer();

                        dynamic classInfo = JsonConvert.DeserializeObject(strResponse);
                        dynamic equipmentInfo = JsonConvert.DeserializeObject(strEquipmentResponse);
                        dynamic levelInfo = JsonConvert.DeserializeObject(strLevelsResponse);


                        Classes classes = new Classes();

                        classes.classHitDie = classInfo.hit_die;

                        ClassDescriptionTextBox.Text += "Hit Die Per Level: " + classes.classHitDie + "\r\n";
                        ClassDescriptionTextBox.Text += "Choose (" + classInfo.proficiency_choices[0].choice + ") proficiencies: ";
                        foreach (var num in classInfo.proficiency_choices)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nProficiencies: ";
                        foreach (var num in classInfo.proficiencies)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nSaving Throws: ";
                        foreach (var num in classInfo.saving_throws)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nStarting Equipment: ";
                        foreach (var num in equipmentInfo.starting_equipment)
                        {
                            ClassDescriptionTextBox.Text += num.quantity + " " + num.item.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nChoose two more items: ";
                        foreach (var num in equipmentInfo.choice_1)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].item.name.ToString() + ", ";
                        }

                        ClassDescriptionTextBox.Text += "\r\nSubclasses: ";
                        foreach (var num in classInfo.subclasses)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        break;
                    }
                case 11:
                    {
                        RestClient rClient = new RestClient();
                        rClient.endPoint = "http://dnd5eapi.co/api/classes/12";
                        RestClient rClientEquipment = new RestClient();
                        rClientEquipment.endPoint = "http://www.dnd5eapi.co/api/startingequipment/12";
                        RestClient rClientLevels = new RestClient();
                        rClientLevels.endPoint = "http://www.dnd5eapi.co/api/classes/Barbarian/levels";
                        string strResponse = string.Empty;
                        string strEquipmentResponse = string.Empty;
                        string strLevelsResponse = string.Empty;

                        strResponse = rClient.makeRequest();
                        strEquipmentResponse = rClientEquipment.makeRequest();
                        strLevelsResponse = rClientLevels.makeRequest();
                        JSONDeserializer deserializer = new JSONDeserializer();

                        dynamic classInfo = JsonConvert.DeserializeObject(strResponse);
                        dynamic equipmentInfo = JsonConvert.DeserializeObject(strEquipmentResponse);
                        dynamic levelInfo = JsonConvert.DeserializeObject(strLevelsResponse);


                        Classes classes = new Classes();

                        classes.classHitDie = classInfo.hit_die;

                        ClassDescriptionTextBox.Text += "Hit Die Per Level: " + classes.classHitDie + "\r\n";
                        ClassDescriptionTextBox.Text += "Choose (" + classInfo.proficiency_choices[0].choice + ") proficiencies: ";
                        foreach (var num in classInfo.proficiency_choices)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nProficiencies: ";
                        foreach (var num in classInfo.proficiencies)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nSaving Throws: ";
                        foreach (var num in classInfo.saving_throws)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nStarting Equipment: ";
                        foreach (var num in equipmentInfo.starting_equipment)
                        {
                            ClassDescriptionTextBox.Text += num.quantity + " " + num.item.name.ToString() + ", ";
                        }
                        ClassDescriptionTextBox.Text += "\r\nChoose two more items: ";
                        foreach (var num in equipmentInfo.choice_1)
                        {
                            ClassDescriptionTextBox.Text += num.from[0].item.name.ToString() + ", ";
                        }

                        ClassDescriptionTextBox.Text += "\r\nSubclasses: ";
                        foreach (var num in classInfo.subclasses)
                        {
                            ClassDescriptionTextBox.Text += num.name.ToString() + ", ";
                        }
                        break;
                    }
            }
        }
        public string ClassText
        {
            get { return this.ClassDescriptionTextBox.Text; }
        }
    }
}
