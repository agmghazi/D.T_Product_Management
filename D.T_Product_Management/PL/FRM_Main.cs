﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D.T_Product_Management.PL
{
    public partial class FRM_Main : Form
    {
        #region TO control from FRM LOGIN
        private static FRM_Main frm;
        static void frm_formClosed (object sender,FormClosedEventArgs e)
        {
            frm = null;
        }
        
        public static FRM_Main getMainForm
        {
            get
            {
                if(frm==null)
                {
                    frm.FormClosed += new FormClosedEventHandler(frm_formClosed);
                }
                return frm;
            }
        }
        #endregion

        public FRM_Main()
        {
            InitializeComponent();
            //TO control from FRM LOGIN
            if (frm == null)
                frm = this;
            // to close all menu to login first
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المنتوجاتToolStripMenuItem.Enabled = false;
            this.المستخدمونToolStripMenuItem.Enabled = false;
            this.انشاءنسخهاحتياطيهToolStripMenuItem.Enabled = false;
            this.استعادهنسخهاحتياطيهToolStripMenuItem.Enabled = false;
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Login log = new FRM_Login();
            log.ShowDialog();

        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}