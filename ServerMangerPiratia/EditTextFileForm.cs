﻿using ServerManagerPiratia.Cunstruct;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerManagerPiratia
{
    public partial class EditTextFileForm : Form
    {
        public EditTextFileForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ItemInfo(), EditTextPanel);
        }

        // Заполнение
        private static Button currentBtn = new();
        private static Form currentChildForm = null;


        // Методы
        public static void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(118, 118, 118);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.BackColor = color;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private static void DisableButton()
        {
            if (currentBtn != null)
            {
                // Button
                currentBtn.BackColor = Color.FromArgb(211, 211, 211);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.BackColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public static void OpenChildForm(Form childform, Panel panel)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel.Controls.Add(childform);
            panel.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
    }
}
