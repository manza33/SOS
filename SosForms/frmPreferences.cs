﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SosForms
{
    public partial class frmPreferences : Form
    {
        public frmPreferences()
        {
            InitializeComponent();
        }

        private void frmPreferences_Load(object sender, EventArgs e)
        {

        }

        public string Login
        {
            get => textBoxLogin.Text;
            set => textBoxLogin.Text = value;
        }
        public string Password
        {
            get => textBoxPassword.Text;
            set => textBoxPassword.Text = value;
        }

    }
}