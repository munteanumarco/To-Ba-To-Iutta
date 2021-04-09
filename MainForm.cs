﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Ba_To_Iutta
{
    public partial class MainForm : Form
    {

        public MainForm(bool splash = true)
        {
            if (splash) showSplashForm();
            InitializeComponent();
            roundCorners();
            titleLabel.Text = System.Reflection.Assembly.GetEntryAssembly().Location;
            Crypt.Data.MainPanelForm = new TextCryptForm(Crypt.Procedure.decrypt);
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.AddRange(Crypt.Data.MainPanelForm.ControlsArray);
        }
        private void showSplashForm()
        {
            SplashForm f = new SplashForm();
            f.ShowDialog();
        }

        private bool logoPanelClicked = false;
        private Point logoPanelClickedStartPoint;
        private void roundCorners()
        {
            Rectangle Bounds = new Rectangle(0, 0, Width, Height);
            float CornerRadius = Crypt.Constants.FormBorderRadius;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(Bounds.X, Bounds.Y, 2 * CornerRadius, 2 * CornerRadius, 180, 90);
            path.AddArc(Bounds.X + Bounds.Width - 2 * CornerRadius, Bounds.Y, 2 * CornerRadius, 2 * CornerRadius, 270, 90);
            path.AddArc(Bounds.X + Bounds.Width - 2 * CornerRadius, Bounds.Y + Bounds.Height - 2 * CornerRadius, 2 * CornerRadius, 2 * CornerRadius, 0, 90);
            path.AddArc(Bounds.X, Bounds.Y + Bounds.Height - 2 * CornerRadius, 2 * CornerRadius, 2 * CornerRadius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);
        }

        #region Move Form Panel
        private void movePanel_MouseDown(object sender, MouseEventArgs e)
        {
            logoPanelClicked = true;
            logoPanelClickedStartPoint = e.Location;
        }

        private void movePanel_MouseUp(object sender, MouseEventArgs e)
        {
            logoPanelClicked = false;
        }

        private void movePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(logoPanelClicked)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - logoPanelClickedStartPoint.X, p.Y - logoPanelClickedStartPoint.Y);
            }
        }
        #endregion

        private void closeFormHandler(object sender, EventArgs e) 
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Close(); 
        }
        private void minimizeFormHandler(object sender, EventArgs e) 
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Minimized;
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
