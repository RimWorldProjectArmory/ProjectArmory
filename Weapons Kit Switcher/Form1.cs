using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Weapons_Kit_Switcher
{
    public partial class Form1 : Form
    {
        public static bool loading;
        public static Dictionary<string, Button> Buttons = new Dictionary<string, Button>();
        public static string[] WeaponClasses = { "ModernWeapon", "ModernLauncher", "WorldWar1Weapon", "WorldWar2Weapon", "SciFi", "MedievalWeapon" };
        public static string RimWorldExecutablePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public static Dictionary<string, bool> Kits = new Dictionary<string, bool>();
        public Form1()
        {
            InitializeComponent();
            Buttons.Add("ModernWeapon", ModernWeapon);
            Buttons.Add("ModernLauncher", ModernLauncher);
            Buttons.Add("WorldWar1Weapon", WorldWar1Weapon);
            Buttons.Add("WorldWar2Weapon", WorldWar2Weapon);
            Buttons.Add("SciFi", SciFi);
            Buttons.Add("MedievalWeapon", MedievalWeapon);
            Buttons.Add("VanillaWeapon", VanillaWeapon);
            {
                foreach (string file in System.IO.Directory.GetFiles("" + RimWorldExecutablePath + "\\Defs\\ThingDefs"))
                {
                    string filename = System.IO.Path.GetFileName(file);
                    if (filename.StartsWith("PA_"))
                    {
                        filename = filename.Remove(0, 3);
                        foreach (string clas in WeaponClasses)
                        {
                            if (filename.StartsWith(clas))
                            {
                                if (!Kits.ContainsKey(clas))
                                {
                                    if (filename.EndsWith(".xml"))
                                    {
                                        Kits.Add(clas, true);
                                        Buttons[clas].Text = "Deactivate";
                                    }
                                    else
                                    {
                                        Kits.Add(clas, false);
                                        Buttons[clas].Text = "Activate";
                                    }
                                }
                                else
                                {
                                    Kits.Remove(clas);
                                    if (filename.EndsWith(".xml"))
                                    {
                                        Kits.Add(clas, true);
                                        Buttons[clas].Text = "Deactivate";
                                    }
                                    else
                                    {
                                        Kits.Add(clas, false);
                                        Buttons[clas].Text = "Activate";
                                    }
                                }
                            }
                        }
                    }
                    else if (filename.StartsWith("VanillaWeapon"))
                    {
                        if (!Kits.ContainsKey("VanillaWeapon"))
                        {
                            if (filename.EndsWith(".xml"))
                            {
                                Kits.Add("VanillaWeapon", true);
                                Buttons["VanillaWeapon"].Text = "Deactivate";
                            }
                            else
                            {
                                Kits.Add("VanillaWeapon", false);
                                Buttons["VanillaWeapon"].Text = "Activate";
                            }
                        }
                        else
                        {
                            Kits.Remove("VanillaWeapon");
                            if (filename.EndsWith(".xml"))
                            {
                                Kits.Add("VanillaWeapon", true);
                                Buttons["VanillaWeapon"].Text = "Deactivate";
                            }
                            else
                            {
                                Kits.Add("VanillaWeapon", false);
                                Buttons["VanillaWeapon"].Text = "Activate";
                            }
                        }
                    }
                }
            }
        }

        private void Switch(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name != "VanillaWeapon")
            {
                if (Kits[btn.Name] == true)
                {
                    foreach (string file in System.IO.Directory.GetFiles("" + RimWorldExecutablePath + "\\Defs\\ThingDefs"))
                    {
                        string filename = System.IO.Path.GetFileName(file);
                        filename = filename.Remove(0, 3);
                        if (filename.StartsWith(btn.Name) && filename.EndsWith(".xml"))
                        {
                            string newFile = file.Replace(".xml", ".xml.deAct");
                            System.IO.File.Move(file, newFile);
                            Kits[btn.Name] = false;
                            btn.Text = "Acitvate";
                        }
                    }
                }
                else
                {
                    foreach (string file in System.IO.Directory.GetFiles("" + RimWorldExecutablePath + "\\Defs\\ThingDefs"))
                    {
                        string filename = System.IO.Path.GetFileName(file);
                        filename = filename.Remove(0, 3);
                        if (filename.StartsWith(btn.Name) && filename.EndsWith(".xml.deAct"))
                        {
                            string newFile = file.Replace(".xml.deAct", ".xml");
                            System.IO.File.Move(file, newFile);
                            Kits[btn.Name] = true;
                            btn.Text = "Deactivate";
                        }
                    }
                }
            }
            else
            {
                if (Kits[btn.Name] == true)
                {
                    foreach (string file in System.IO.Directory.GetFiles("" + RimWorldExecutablePath + "\\Defs\\ThingDefs"))
                    {
                        string filename = System.IO.Path.GetFileName(file);
                        if (filename.StartsWith(btn.Name) && filename.EndsWith(".xml"))
                        {
                            string newFile = file.Replace(".xml", ".xml.deAct");
                            System.IO.File.Move(file, newFile);
                            Kits[btn.Name] = false;
                            btn.Text = "Acitvate";
                        }
                    }
                }
                else
                {
                    foreach (string file in System.IO.Directory.GetFiles("" + RimWorldExecutablePath + "\\Defs\\ThingDefs"))
                    {
                        string filename = System.IO.Path.GetFileName(file);
                        if (filename.StartsWith(btn.Name) && filename.EndsWith(".xml.deAct"))
                        {
                            string newFile = file.Replace(".xml.deAct", ".xml");
                            System.IO.File.Move(file, newFile);
                            Kits[btn.Name] = true;
                            btn.Text = "Deactivate";
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loading = true;
            listView1.Items.Clear();
            string aweapon;
            foreach (string file in System.IO.Directory.GetFiles("" + RimWorldExecutablePath + "\\Defs\\ThingDefs"))
            {
                string filename = System.IO.Path.GetFileName(file), name = System.IO.Path.GetFileNameWithoutExtension(file);
                aweapon = filename;
                aweapon = aweapon.Replace(".xml", "");
                aweapon = aweapon.Replace("PA_", "");
                aweapon = aweapon.Replace("SciFi-", "");
                aweapon = aweapon.Replace("ProjectArmory", "");
                aweapon = aweapon.Replace("_Weapon-", "");
                aweapon = aweapon.Replace("Warhammer40K", "");
                aweapon = aweapon.Replace("_Weapon_", "");
                aweapon = aweapon.Replace("WorldWar2Weapon-", "");
                aweapon = aweapon.Replace("Halo", "");
                aweapon = aweapon.Replace("VanillaWeapon-", "");
                aweapon = aweapon.Replace("ModernWeapon-", "");
                aweapon = aweapon.Replace("MedievalWeapon-", "");
                aweapon = aweapon.Replace("ModernLauncher-", "");
                aweapon = aweapon.Replace("Alien2", "");
                aweapon = aweapon.Replace("Firefly", "");
                aweapon = aweapon.Replace("StarshipTroopers", "");
                aweapon = aweapon.Replace("StarWars", "");
                aweapon = aweapon.Replace("WorldWar1Weapon-", "");
                aweapon = aweapon.Replace(".deAct", "");
                if (filename.EndsWith(".xml"))
                {
                    listView1.Items.Add(aweapon);
                    foreach (ListViewItem w in listView1.Items)
                    {
                        if (w.Text == aweapon)
                            w.Checked = true;
                    }
                }
                else if (filename.EndsWith(".xml.deAct"))
                {
                    listView1.Items.Add(aweapon);
                    foreach (ListViewItem w in listView1.Items)
                    {
                        if (w.Text == aweapon)
                            w.Checked = false;
                    }
                }
            }
            if (button1.Text == "Select single weapons")
            {
                panel1.Visible = true;
                button1.Text = "Select groups of weapons";
            }
            else
            {
                panel1.Visible = false;
                button1.Text = "Select single weapons";
            }
            loading = false;
        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (loading == false)
            {
                if (e.CurrentValue == CheckState.Checked)
                {
                    foreach (string file in System.IO.Directory.GetFiles("" + RimWorldExecutablePath + "\\Defs\\ThingDefs"))
                    {
                        string filename = System.IO.Path.GetFileName(file);
                        if (filename.Contains(listView1.Items[e.Index].Text))
                        {
                            string newFile = file.Replace(".xml", ".xml.deAct");
                            System.IO.File.Move(file, newFile);
                        }
                    }
                }
                else
                {
                    foreach (string file in System.IO.Directory.GetFiles("" + RimWorldExecutablePath + "\\Defs\\ThingDefs"))
                    {
                        string filename = System.IO.Path.GetFileName(file);
                        if (filename.Contains(listView1.Items[e.Index].Text))
                        {
                            string newFile = file.Replace(".xml.deAct", ".xml");
                            System.IO.File.Move(file, newFile);
                        }
                    }
                }
            }
        }
    }
}
