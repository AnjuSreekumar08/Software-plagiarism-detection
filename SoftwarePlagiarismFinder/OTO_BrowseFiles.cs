using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DifferenceEngine;
using System.Collections;
namespace SoftwarePlagiarismFinder
{
    public partial class OTO_BrowseFiles : Form
    {
      

        private DiffEngineLevel _level;

        public OTO_BrowseFiles()
        {
            InitializeComponent();
            _level = DiffEngineLevel.FastImperfect; 
        }

        private void cmdSource_Click(object sender, EventArgs e)
        {
            txtSource.Text = GetFileName();
        }

        private string GetFileName()
        {
            string fname = string.Empty;
            OpenFileDialog dlg = new OpenFileDialog();

            
            dlg.Filter = "All files (*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fname = dlg.FileName;
            }
            return fname;
        }

        private void cmdDestination_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdCompare_Click(object sender, EventArgs e)
        {

        }

        private void txtSource_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

       


       
       
    }
}
