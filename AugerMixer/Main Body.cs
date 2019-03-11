﻿using System;
using System.Windows.Forms;

namespace AugerMixer
{
    public partial class MainBody : Form
    {
        private InventorAPI api;
        private Inventor.Application app = null;
        public static double H = 1635, Degree = 18, D = 1530, B = 100, A = 15, T = 40, Rb = 730, Rm = 24, Ds = 250; // Размеры
        public MainBody()
        {
            InitializeComponent();
            textBox1.Text = Convert.ToString(H);
            textBox2.Text = Convert.ToString(D);
            textBox3.Text = Convert.ToString(B);
            textBox4.Text = Convert.ToString(A);
            textBox5.Text = Convert.ToString(T);
            textBox7.Text = Convert.ToString(Rb);
            textBox8.Text = Convert.ToString(Rm);
            textBox10.Text = Convert.ToString(Ds);
        }
        private void Build_Click(object sender, EventArgs e)
        {
            app = Auto.AppActivity(app);
            if (app == null)
                return;
            api = new InventorAPI(app, "КК", "Конический корпус");
            Build.MainBody(api, Text);
        }
        private void Save_Click(object sender, EventArgs e) =>
            Auto.SavePart(app, saveFileDialog1, this, api);
        private void textBox1_TextChanged(object sender, EventArgs e) =>
            H = Auto.CheckTextBoxChange(textBox1, 1635);
        private void textBox2_TextChanged(object sender, EventArgs e) =>
            D = Auto.CheckTextBoxChange(textBox2, 1530);
        private void textBox3_TextChanged(object sender, EventArgs e) =>
            B = Auto.CheckTextBoxChange(textBox3, D / 2 / 2);
        private void textBox4_TextChanged(object sender, EventArgs e) =>
            A = Auto.CheckTextBoxChange(textBox4, 15);
        private void textBox5_TextChanged(object sender, EventArgs e) =>
            T = Auto.CheckTextBoxChange(textBox5, 40);
        private void textBox7_TextChanged(object sender, EventArgs e) =>
            Rb = Auto.CheckTextBoxChange(textBox7, 730);
        private void textBox8_TextChanged(object sender, EventArgs e) =>
            Rm = Auto.CheckTextBoxChange(textBox8, 24);
        private void textBox10_TextChanged(object sender, EventArgs e) =>
            Ds = Auto.CheckTextBoxChange(textBox10, (D / 2 - B) / 2);
    }
}