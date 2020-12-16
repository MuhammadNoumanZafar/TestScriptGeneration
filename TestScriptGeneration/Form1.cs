using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestScriptGeneration
{
    public partial class Form1 : Form
    {
        string gendetail;
        public Form1()
        {
            InitializeComponent();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            //Opening window for selecting Json or GraphML model file

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\GW";
            openFileDialog1.Filter = "Json Access files (*.json)|*.json|GraphML Access files (*.graphml)|*.graphml";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //showing File Name in textbox
                filepath.Text = openFileDialog1.SafeFileName;
            }
            else
            {
                // This prevents a crash when you close out of the window with nothing
            }
        }

        private void btSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            // This is what will execute if the user selects a folder and hits OK (File if you change to FileBrowserDialog)
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtDestFolder.Text = dlg.SelectedPath;
            }
            else
            {
                // This prevents a crash when you close out of the window with nothing
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                gendetail = "-m ";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                gendetail = "-o -m ";
            }
        }

        private void btGenerateTC_Click(object sender, EventArgs e)
        {
            if (txtDestFolder.Text.Trim() != "" && filepath.Text.Trim() != "" && pathgenerator.SelectedIndex > -1 && comboBox1.SelectedIndex > -1 && stoppingCondition.SelectedIndex > -1)
            {
                try
                {
                    //running GWCLI for test generation
                    string path = "C:\\GW"; //add this directory to C drive and copy paster GW CLI
                    Process process = new Process();
                    process.EnableRaisingEvents = false;
                    process.StartInfo.WorkingDirectory = path;
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/C java -jar graphwalker-cli-4.2.0.jar offline " + gendetail + filepath.Text.Trim() + " \"" + pathgenerator.SelectedItem.ToString() + "(" + stoppingCondition.SelectedItem.ToString() + ")\" " + " >> " + txtDestFolder.Text + "\\" + filepath.Text;
                    process.Start();

                    //clearing the fields
                    txtDestFolder.Text = "";
                    filepath.Text = "";
                    pathgenerator.SelectedIndex = -1;
                    comboBox1.SelectedIndex = -1;
                    stoppingCondition.SelectedIndex = -1;
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
            else {
                MessageBox.Show("Incomplete Necessary Fields");
            }
        }

        private void btTestScriptGen_Click(object sender, EventArgs e)
        {
            if (txtMappingFile.Text.Trim() != "" &&  txtDestFolder.Text.Trim() != "" && filepath.Text.Trim() != "" && txtDestTS.Text.Trim() != "")
            {
                try
                {
                    //reading Json to extract data
                    JsonReading JsRead = new JsonReading();
                    List<Rootobject> testcases = JsRead.ReadFile(txtDestFolder.Text + "\\" + filepath.Text);
                    //reading Xml to extract signals Technical Names
                    xmlReader xmlReader = new xmlReader();
                    List<Signal> signals = new List<Signal>();
                    signals = xmlReader.ReadFile(txtMappingFile.Text.Trim());
                    //Generating Test script
                    TestGenerator Tsc = new TestGenerator();
                    string[] arsplit = filepath.Text.Split('.');
                    string TSName = arsplit[0];
                    string TSpath = txtDestTS.Text.Trim() + "\\" + TSName + ".cs";
                    Tsc.GenerateTestScripts(testcases, signals, TSpath);
                    txtMappingFile.Text = "";
                    txtDestFolder.Text = "";
                    filepath.Text = "";
                    txtDestTS.Text = "";
                    MessageBox.Show("Test Scripts Generated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Incomplete Necessary Fields");
            }
        }

        private void bt_MappingFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\GW"; //add this directory to C drive and copy paster GW CLI
            openFileDialog1.Filter = "xml files (*.xml)|*.xml";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //showing File Name in textbox
                txtMappingFile.Text = openFileDialog1.FileName;
            }
            else
            {
                // This prevents a crash when you close out of the window with nothing
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            // This is what will execute if the user selects a folder and hits OK (File if you change to FileBrowserDialog)
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtDestTS.Text = dlg.SelectedPath;
            }
            else
            {
                // This prevents a crash when you close out of the window with nothing
            }
        }
    }
}
