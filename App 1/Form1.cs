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

namespace App_1
{
    

    public partial class Hauptfenster : Form
    {
        int checkfile;


        public Hauptfenster()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                    //Author: Matthias Jung 
                    //Created: May 2016

            button1.Enabled = false;         
            //button3.Enabled = false;


           
        }

    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                button1.Enabled = false;
            }

            else if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

           listBox1.Items.Add(textBox1.Text);
           toolStripStatusLabel1.Text = Convert.ToString(listBox1.Items.Count);
           textBox1.Clear();
           textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            

            listBox1.Items.Clear();
            toolStripStatusLabel1.Text = Convert.ToString(listBox1.Items.Count);
            textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (button1.Enabled == true)
                {
                    listBox1.Items.Add(textBox1.Text);
                    toolStripStatusLabel1.Text = Convert.ToString(listBox1.Items.Count);
                    textBox1.Clear();
                    //button1.Location = new Point(367, 29);

                }
                else
                {
                    
                }
            }
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void listBox1_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_ClientSizeChanged(object sender, EventArgs e)
        {
            
        }

        private void troll_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

          
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

            Random position1 = new Random();

             if (textBox1.Text.ToLower() == "hau ab")
            {
                
                //button1.Location = new Point(position1.Next(10, 380), position1.Next(10, 60));

            }

             else
             {
                 //button1.Location = new Point(367, 29);
             }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            


            SaveFileDialog sfd = new SaveFileDialog();

           sfd.InitialDirectory = "c:\\";
           sfd.Filter = "Todo Files (*.todo)|*.todo";
           sfd.FilterIndex = 1;
           sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                
                StreamWriter savefile = new StreamWriter(sfd.FileName);

                foreach (var item in listBox1.Items)
                {


                    savefile.WriteLine(item.ToString());
                }

                

                savefile.Close();

                
            }

            checkfile = listBox1.Items.Count;
                  
                       
    
        }

        private void listBox1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_DisplayMemberChanged(object sender, EventArgs e)
        {
          

        }

        private void listBox1_FormatStringChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Remove(listBox1.SelectedItem);



            for (int x = listBox1.SelectedIndices.Count - 1; x >= 0; x--)
            {
                int idx = listBox1.SelectedIndices[x];
                listBox1.Items.RemoveAt(idx);
                
            }

            toolStripStatusLabel1.Text = Convert.ToString(listBox1.Items.Count);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

            


            OpenFileDialog ofd = new OpenFileDialog();

                 ofd.InitialDirectory = "c:\\" ;
                 ofd.Filter = "Todo Files (*.todo)|*.todo" ;
                 ofd.FilterIndex = 1 ;
                 ofd.RestoreDirectory = true ;

                 
                 

                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Clear();
                    StreamReader DateiLesen = new StreamReader(ofd.FileName);

                    while (!DateiLesen.EndOfStream)
                    {

                        string zeile = DateiLesen.ReadLine();
                        listBox1.Items.Add(zeile);
                    }

                    DateiLesen.Close();

                 }



                toolStripStatusLabel1.Text = Convert.ToString(listBox1.Items.Count);
                checkfile = listBox1.Items.Count;
            
          
        }

        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            
            if (e.KeyChar == 8)
            {
                for (int x = listBox1.SelectedIndices.Count - 1; x >= 0; x--)
                {
                    int idx = listBox1.SelectedIndices[x];
                    listBox1.Items.RemoveAt(idx);
                }

                toolStripStatusLabel1.Text = Convert.ToString(listBox1.Items.Count);
                
            }
                else
                {

                }
            
        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);

            }
            else
            {
                contextMenuStrip1.Hide();
            }
        }

        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();

            //ofd.InitialDirectory = "c:\\" ;
            ofd.Filter = "Todo Files (*.todo)|*.todo";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;




            if (ofd.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                StreamReader DateiLesen = new StreamReader(ofd.FileName);

                while (!DateiLesen.EndOfStream)
                {

                    string zeile = DateiLesen.ReadLine();
                    listBox1.Items.Add(zeile);
                }

                DateiLesen.Close();

            }



            toolStripStatusLabel1.Text = Convert.ToString(listBox1.Items.Count);
            checkfile = listBox1.Items.Count;

        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            //sfd.InitialDirectory = "c:\\";
            sfd.Filter = "Todo Files (*.todo)|*.todo";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {


                StreamWriter savefile = new StreamWriter(sfd.FileName);


                foreach (var item in listBox1.Items)
                {


                    savefile.WriteLine(item.ToString());
                }

                savefile.Close();


            }

            checkfile = listBox1.Items.Count;

        }

        private void listeLeerenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            toolStripStatusLabel1.Text = Convert.ToString(listBox1.Items.Count);
            textBox1.Focus();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click_2(object sender, EventArgs e)
        {

        }

        private void Hauptfenster_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listBox1.Items.Count != checkfile)
            {

                var confirm = MessageBox.Show("Möchten sie speichern?", "Schließen", MessageBoxButtons.YesNoCancel);

                if (confirm == DialogResult.Cancel)
                {
                    e.Cancel = true;

                }

                if (confirm == DialogResult.Yes)
                {
                    SaveFileDialog sfd = new SaveFileDialog();

                    //sfd.InitialDirectory = "c:\\";
                    sfd.Filter = "Todo Files (*.todo)|*.todo";
                    sfd.FilterIndex = 1;
                    sfd.RestoreDirectory = true;

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {


                        StreamWriter savefile = new StreamWriter(sfd.FileName);


                        foreach (var item in listBox1.Items)
                        {


                            savefile.WriteLine(item.ToString());
                        }

                        savefile.Close();


                    }

                }

                if (confirm == DialogResult.No)
                {

                }
            }

           
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

   
    }
}
