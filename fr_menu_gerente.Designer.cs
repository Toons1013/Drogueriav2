﻿
namespace Drogueria_proyecto
{
    partial class fr_menu_gerente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerg = new System.Windows.Forms.Timer(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panelDesktop = new Guna.UI2.WinForms.Guna2Panel();
            this.labelfechag = new System.Windows.Forms.Label();
            this.labelhorag = new System.Windows.Forms.Label();
            this.PanelTitulo = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnSalir = new FontAwesome.Sharp.IconButton();
            this.BtnMaximizar = new FontAwesome.Sharp.IconButton();
            this.BtnMinimizar = new FontAwesome.Sharp.IconButton();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconButton();
            this.PanelLateral = new Guna.UI2.WinForms.Guna2Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.button_menug_inv = new FontAwesome.Sharp.IconButton();
            this.button_menug_cli = new FontAwesome.Sharp.IconButton();
            this.PLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.BtnInicio = new System.Windows.Forms.PictureBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.PanelTitulo.SuspendLayout();
            this.PanelLateral.SuspendLayout();
            this.PLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // timerg
            // 
            this.timerg.Enabled = true;
            this.timerg.Tick += new System.EventHandler(this.timerg_Tick);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(61)))));
            this.guna2CustomGradientPanel1.Controls.Add(this.panelDesktop);
            this.guna2CustomGradientPanel1.Controls.Add(this.PanelTitulo);
            this.guna2CustomGradientPanel1.Controls.Add(this.PanelLateral);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(77)))), ((int)(((byte)(101)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(232)))), ((int)(((byte)(253)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(77)))), ((int)(((byte)(101)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1058, 854);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Transparent;
            this.panelDesktop.BackgroundImage = global::Drogueria_proyecto.Properties.Resources.fondo1;
            this.panelDesktop.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.panelDesktop.Controls.Add(this.labelfechag);
            this.panelDesktop.Controls.Add(this.labelhorag);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(300, 60);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(758, 794);
            this.panelDesktop.TabIndex = 2;
            // 
            // labelfechag
            // 
            this.labelfechag.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelfechag.AutoSize = true;
            this.labelfechag.BackColor = System.Drawing.Color.Transparent;
            this.labelfechag.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfechag.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelfechag.Location = new System.Drawing.Point(99, 390);
            this.labelfechag.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelfechag.Name = "labelfechag";
            this.labelfechag.Size = new System.Drawing.Size(109, 39);
            this.labelfechag.TabIndex = 2;
            this.labelfechag.Text = "label1";
            // 
            // labelhorag
            // 
            this.labelhorag.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelhorag.AutoSize = true;
            this.labelhorag.BackColor = System.Drawing.Color.Transparent;
            this.labelhorag.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhorag.ForeColor = System.Drawing.Color.White;
            this.labelhorag.Location = new System.Drawing.Point(101, 536);
            this.labelhorag.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelhorag.Name = "labelhorag";
            this.labelhorag.Size = new System.Drawing.Size(210, 73);
            this.labelhorag.TabIndex = 1;
            this.labelhorag.Text = "label1";
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(120)))));
            this.PanelTitulo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.PanelTitulo.Controls.Add(this.BtnSalir);
            this.PanelTitulo.Controls.Add(this.BtnMaximizar);
            this.PanelTitulo.Controls.Add(this.BtnMinimizar);
            this.PanelTitulo.Controls.Add(this.iconCurrentChildForm);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(300, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(758, 60);
            this.PanelTitulo.TabIndex = 1;
            this.PanelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitulo_MouseDown_1);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.AutoSize = true;
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(120)))));
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSalir.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.BtnSalir.IconColor = System.Drawing.Color.White;
            this.BtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSalir.IconSize = 25;
            this.BtnSalir.Location = new System.Drawing.Point(696, 17);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(31, 31);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.AutoSize = true;
            this.BtnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(120)))));
            this.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximizar.FlatAppearance.BorderSize = 0;
            this.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.BtnMaximizar.IconColor = System.Drawing.Color.White;
            this.BtnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMaximizar.IconSize = 25;
            this.BtnMaximizar.Location = new System.Drawing.Point(659, 17);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(31, 31);
            this.BtnMaximizar.TabIndex = 3;
            this.BtnMaximizar.UseVisualStyleBackColor = false;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.AutoSize = true;
            this.BtnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(120)))));
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinimizar.IconColor = System.Drawing.Color.White;
            this.BtnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMinimizar.IconSize = 25;
            this.BtnMinimizar.Location = new System.Drawing.Point(622, 17);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(31, 31);
            this.BtnMinimizar.TabIndex = 2;
            this.BtnMinimizar.UseVisualStyleBackColor = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(120)))));
            this.iconCurrentChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 25;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(15, 17);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(31, 26);
            this.iconCurrentChildForm.TabIndex = 1;
            this.iconCurrentChildForm.UseVisualStyleBackColor = false;
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(120)))));
            this.PanelLateral.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.PanelLateral.Controls.Add(this.iconButton3);
            this.PanelLateral.Controls.Add(this.iconButton2);
            this.PanelLateral.Controls.Add(this.button_menug_inv);
            this.PanelLateral.Controls.Add(this.button_menug_cli);
            this.PanelLateral.Controls.Add(this.PLogo);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(300, 854);
            this.PanelLateral.TabIndex = 0;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(183)))));
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton3.FlatAppearance.BorderSize = 4;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 32;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 477);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton3.Size = new System.Drawing.Size(300, 80);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.Text = "Reporte";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(183)))));
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton2.FlatAppearance.BorderSize = 4;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 397);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(300, 80);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "Proveedores";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // button_menug_inv
            // 
            this.button_menug_inv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(183)))));
            this.button_menug_inv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_menug_inv.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_menug_inv.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_menug_inv.FlatAppearance.BorderSize = 4;
            this.button_menug_inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menug_inv.ForeColor = System.Drawing.Color.White;
            this.button_menug_inv.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.button_menug_inv.IconColor = System.Drawing.Color.White;
            this.button_menug_inv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_menug_inv.IconSize = 32;
            this.button_menug_inv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_menug_inv.Location = new System.Drawing.Point(0, 317);
            this.button_menug_inv.Name = "button_menug_inv";
            this.button_menug_inv.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_menug_inv.Size = new System.Drawing.Size(300, 80);
            this.button_menug_inv.TabIndex = 2;
            this.button_menug_inv.Text = "Productos";
            this.button_menug_inv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_menug_inv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_menug_inv.UseVisualStyleBackColor = false;
            this.button_menug_inv.Click += new System.EventHandler(this.button_menug_inv_Click);
            // 
            // button_menug_cli
            // 
            this.button_menug_cli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(144)))), ((int)(((byte)(183)))));
            this.button_menug_cli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_menug_cli.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_menug_cli.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_menug_cli.FlatAppearance.BorderSize = 4;
            this.button_menug_cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menug_cli.ForeColor = System.Drawing.Color.White;
            this.button_menug_cli.IconChar = FontAwesome.Sharp.IconChar.User;
            this.button_menug_cli.IconColor = System.Drawing.Color.White;
            this.button_menug_cli.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_menug_cli.IconSize = 32;
            this.button_menug_cli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_menug_cli.Location = new System.Drawing.Point(0, 237);
            this.button_menug_cli.Name = "button_menug_cli";
            this.button_menug_cli.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_menug_cli.Size = new System.Drawing.Size(300, 80);
            this.button_menug_cli.TabIndex = 1;
            this.button_menug_cli.Text = "Clientes";
            this.button_menug_cli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_menug_cli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_menug_cli.UseVisualStyleBackColor = false;
            this.button_menug_cli.Click += new System.EventHandler(this.button_menug_cli_Click_1);
            // 
            // PLogo
            // 
            this.PLogo.Controls.Add(this.lbTitulo);
            this.PLogo.Controls.Add(this.BtnInicio);
            this.PLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PLogo.Location = new System.Drawing.Point(0, 0);
            this.PLogo.Name = "PLogo";
            this.PLogo.Size = new System.Drawing.Size(300, 237);
            this.PLogo.TabIndex = 0;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(56, 138);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(177, 37);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "MedExpress";
            // 
            // BtnInicio
            // 
            this.BtnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInicio.Image = global::Drogueria_proyecto.Properties.Resources.pildora11;
            this.BtnInicio.Location = new System.Drawing.Point(79, 33);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(135, 102);
            this.BtnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnInicio.TabIndex = 0;
            this.BtnInicio.TabStop = false;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // fr_menu_gerente
            // 
            this.ClientSize = new System.Drawing.Size(1058, 854);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "fr_menu_gerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Gerente";
            this.Resize += new System.EventHandler(this.fr_menu_gerente_Resize);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            this.PanelLateral.ResumeLayout(false);
            this.PLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerg;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel PanelTitulo;
        private Guna.UI2.WinForms.Guna2Panel PanelLateral;
        private Guna.UI2.WinForms.Guna2Panel PLogo;
        private System.Windows.Forms.PictureBox BtnInicio;
        private FontAwesome.Sharp.IconButton button_menug_cli;
        private System.Windows.Forms.Label lbTitulo;
        private FontAwesome.Sharp.IconButton iconCurrentChildForm;
        private Guna.UI2.WinForms.Guna2Panel panelDesktop;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton button_menug_inv;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private FontAwesome.Sharp.IconButton BtnMaximizar;
        private FontAwesome.Sharp.IconButton BtnMinimizar;
        private System.Windows.Forms.Label labelhorag;
        private System.Windows.Forms.Label labelfechag;
    }
}