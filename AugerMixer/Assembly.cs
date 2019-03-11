﻿using System;
using System.Windows.Forms;

namespace AugerMixer
{
    public partial class Assembly : Form
    {
        private Inventor.Application app = null;
        public Assembly() =>
            InitializeComponent();
        // Запуск других окон
        private void InventorControl_Click(object sender, EventArgs e)
        {
            InventorControl IC = new InventorControl();
            IC.ShowDialog();
        }
        private void MainBody_Click(object sender, EventArgs e)
        {
            MainBody MB = new MainBody();
            MB.ShowDialog();
        }
        private void Top_Click(object sender, EventArgs e)
        {
            Top T = new Top();
            T.ShowDialog();
        }
        private void Screw_Click(object sender, EventArgs e)
        {
            Auger W = new Auger();
            W.ShowDialog();
        }
        private void Bottom_Click(object sender, EventArgs e)
        {
            Bottom B = new Bottom();
            B.ShowDialog();
        }
        private void Hold_Click(object sender, EventArgs e)
        {
            Hold H = new Hold();
            H.ShowDialog();
        }
        // Сборка
        private void Build_Click(object sender, EventArgs e)
        {
            app = Auto.AppActivity(app);
            if (app == null)
                return;
            Build.Assembly(app, openFileDialog1, Text);
        }
    }
}