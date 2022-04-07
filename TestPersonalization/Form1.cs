using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace TestPersonalization
{
    public partial class TestPersonalization : Form
    {
        string Appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public TestPersonalization()
        {
            InitializeComponent();

            try
            {

                richTextBox1.Text = System.IO.File.ReadAllText(Appdata + @"\SVA\test.ini");
            }

            catch { }

            try
            {

                RegistryKey ReadKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\SVA\PersonalizationTest\");
                if(ReadKey != null)
                {
                    txtRegistry.Text = ReadKey.GetValue("Testvalue").ToString();
                }
                
            }

            catch
            {

            }
            
        }

        private async void btnSpeichern_Click(object sender, EventArgs e)
        {
            try
            {

                System.IO.FileInfo file = new System.IO.FileInfo(Appdata + @"\SVA\");
                file.Directory.Create(); // If the directory already exists, this method does nothing
                File.WriteAllText(Appdata + @"\SVA\test.ini", richTextBox1.Text);

                toolStripStatusLabel1.Text = "Erfolgreich gespeichert.";
                await Task.Delay(5000);
                toolStripStatusLabel1.Text = "";
            }

            catch
            {
                MessageBox.Show("Datei konnte nicht gespeichert werden");
            }


        }

        private async void btnSpeicherRegistry_Click(object sender, EventArgs e)
        {
            try {

                RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);

                key.CreateSubKey("SVA");
                key = key.OpenSubKey("SVA", true);


                key.CreateSubKey("PersonalizationTest");
                key = key.OpenSubKey("PersonalizationTest", true);

                key.SetValue("TestValue", txtRegistry.Text);

                toolStripStatusLabel1.Text = "Erfolgreich gespeichert.";
                await Task.Delay(5000);
                toolStripStatusLabel1.Text = "";
            }




            catch
            {
                MessageBox.Show("Registry konnte nicht gespeichert werden");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAnleitung_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Tool can be used to test the Ivanti Personalization.\n" +
                "\n" +
                "Includes:\n" +
                "\n" +
                "Appdata: {CSIDL_APPDATA}\\SVA\\test.ini\n\n" +
                "Registry: SOFTWARE\\SVA\\PersonalizationTest\\TestValue");
        }
    }
}
