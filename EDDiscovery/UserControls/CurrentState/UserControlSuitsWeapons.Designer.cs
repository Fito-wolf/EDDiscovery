﻿/*
 * Copyright © 2021 - 2021 EDDiscovery development team
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this
 * file except in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software distributed under
 * the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF
 * ANY KIND, either express or implied. See the License for the specific language
 * governing permissions and limitations under the License.
 * 
 * EDDiscovery is not affiliated with Frontier Developments plc.
 */
namespace EDDiscovery.UserControls
{
    partial class UserControlSuitsWeapons
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelPrev = new System.Windows.Forms.Panel();
            this.extPanelDataGridViewScrollWeapons = new ExtendedControls.ExtPanelDataGridViewScroll();
            this.dataGridViewWeapons = new BaseUtils.DataGridViewColumnHider();
            this.CWTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CWName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CWPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CWDPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extScrollBar1 = new ExtendedControls.ExtScrollBar();
            this.panelCurrent = new System.Windows.Forms.Panel();
            this.extPanelDataGridViewScrollSuits = new ExtendedControls.ExtPanelDataGridViewScroll();
            this.dataGridViewSuits = new BaseUtils.DataGridViewColumnHider();
            this.CSTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSLoadout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSPrimary1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSPrimary2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSSecondary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripSuits = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.forceSellShipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extScrollBar2 = new ExtendedControls.ExtScrollBar();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainerMissions = new System.Windows.Forms.SplitContainer();
            this.panelPrev.SuspendLayout();
            this.extPanelDataGridViewScrollWeapons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeapons)).BeginInit();
            this.panelCurrent.SuspendLayout();
            this.extPanelDataGridViewScrollSuits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuits)).BeginInit();
            this.contextMenuStripSuits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMissions)).BeginInit();
            this.splitContainerMissions.Panel1.SuspendLayout();
            this.splitContainerMissions.Panel2.SuspendLayout();
            this.splitContainerMissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrev
            // 
            this.panelPrev.Controls.Add(this.extPanelDataGridViewScrollWeapons);
            this.panelPrev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrev.Location = new System.Drawing.Point(0, 0);
            this.panelPrev.Name = "panelPrev";
            this.panelPrev.Size = new System.Drawing.Size(800, 302);
            this.panelPrev.TabIndex = 4;
            // 
            // extPanelDataGridViewScrollWeapons
            // 
            this.extPanelDataGridViewScrollWeapons.Controls.Add(this.dataGridViewWeapons);
            this.extPanelDataGridViewScrollWeapons.Controls.Add(this.extScrollBar1);
            this.extPanelDataGridViewScrollWeapons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extPanelDataGridViewScrollWeapons.InternalMargin = new System.Windows.Forms.Padding(0);
            this.extPanelDataGridViewScrollWeapons.Location = new System.Drawing.Point(0, 0);
            this.extPanelDataGridViewScrollWeapons.Name = "extPanelDataGridViewScrollWeapons";
            this.extPanelDataGridViewScrollWeapons.Size = new System.Drawing.Size(800, 302);
            this.extPanelDataGridViewScrollWeapons.TabIndex = 0;
            this.extPanelDataGridViewScrollWeapons.VerticalScrollBarDockRight = true;
            // 
            // dataGridViewWeapons
            // 
            this.dataGridViewWeapons.AllowUserToAddRows = false;
            this.dataGridViewWeapons.AllowUserToDeleteRows = false;
            this.dataGridViewWeapons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWeapons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeapons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CWTime,
            this.CWName,
            this.CWPrice,
            this.CWDPS});
            this.dataGridViewWeapons.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewWeapons.Name = "dataGridViewWeapons";
            this.dataGridViewWeapons.ReadOnly = true;
            this.dataGridViewWeapons.RowHeaderMenuStrip = null;
            this.dataGridViewWeapons.RowHeadersVisible = false;
            this.dataGridViewWeapons.SingleRowSelect = true;
            this.dataGridViewWeapons.Size = new System.Drawing.Size(784, 302);
            this.dataGridViewWeapons.TabIndex = 1;
            // 
            // CWTime
            // 
            this.CWTime.HeaderText = "Time";
            this.CWTime.Name = "CWTime";
            this.CWTime.ReadOnly = true;
            // 
            // CWName
            // 
            this.CWName.HeaderText = "Name";
            this.CWName.Name = "CWName";
            this.CWName.ReadOnly = true;
            // 
            // CWPrice
            // 
            this.CWPrice.HeaderText = "Price";
            this.CWPrice.Name = "CWPrice";
            this.CWPrice.ReadOnly = true;
            // 
            // CWDPS
            // 
            this.CWDPS.HeaderText = "DPS";
            this.CWDPS.Name = "CWDPS";
            this.CWDPS.ReadOnly = true;
            // 
            // extScrollBar1
            // 
            this.extScrollBar1.ArrowBorderColor = System.Drawing.Color.LightBlue;
            this.extScrollBar1.ArrowButtonColor = System.Drawing.Color.LightGray;
            this.extScrollBar1.ArrowColorScaling = 0.5F;
            this.extScrollBar1.ArrowDownDrawAngle = 270F;
            this.extScrollBar1.ArrowUpDrawAngle = 90F;
            this.extScrollBar1.BorderColor = System.Drawing.Color.White;
            this.extScrollBar1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.extScrollBar1.HideScrollBar = false;
            this.extScrollBar1.LargeChange = 0;
            this.extScrollBar1.Location = new System.Drawing.Point(784, 0);
            this.extScrollBar1.Maximum = -1;
            this.extScrollBar1.Minimum = 0;
            this.extScrollBar1.MouseOverButtonColor = System.Drawing.Color.Green;
            this.extScrollBar1.MousePressedButtonColor = System.Drawing.Color.Red;
            this.extScrollBar1.Name = "extScrollBar1";
            this.extScrollBar1.Size = new System.Drawing.Size(16, 302);
            this.extScrollBar1.SliderColor = System.Drawing.Color.DarkGray;
            this.extScrollBar1.SmallChange = 1;
            this.extScrollBar1.TabIndex = 0;
            this.extScrollBar1.Text = "extScrollBar1";
            this.extScrollBar1.ThumbBorderColor = System.Drawing.Color.Yellow;
            this.extScrollBar1.ThumbButtonColor = System.Drawing.Color.DarkBlue;
            this.extScrollBar1.ThumbColorScaling = 0.5F;
            this.extScrollBar1.ThumbDrawAngle = 0F;
            this.extScrollBar1.Value = -1;
            this.extScrollBar1.ValueLimited = -1;
            // 
            // panelCurrent
            // 
            this.panelCurrent.Controls.Add(this.extPanelDataGridViewScrollSuits);
            this.panelCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCurrent.Location = new System.Drawing.Point(0, 0);
            this.panelCurrent.Name = "panelCurrent";
            this.panelCurrent.Size = new System.Drawing.Size(800, 266);
            this.panelCurrent.TabIndex = 3;
            // 
            // extPanelDataGridViewScrollSuits
            // 
            this.extPanelDataGridViewScrollSuits.Controls.Add(this.dataGridViewSuits);
            this.extPanelDataGridViewScrollSuits.Controls.Add(this.extScrollBar2);
            this.extPanelDataGridViewScrollSuits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extPanelDataGridViewScrollSuits.InternalMargin = new System.Windows.Forms.Padding(0);
            this.extPanelDataGridViewScrollSuits.Location = new System.Drawing.Point(0, 0);
            this.extPanelDataGridViewScrollSuits.Name = "extPanelDataGridViewScrollSuits";
            this.extPanelDataGridViewScrollSuits.Size = new System.Drawing.Size(800, 266);
            this.extPanelDataGridViewScrollSuits.TabIndex = 1;
            this.extPanelDataGridViewScrollSuits.VerticalScrollBarDockRight = true;
            // 
            // dataGridViewSuits
            // 
            this.dataGridViewSuits.AllowUserToAddRows = false;
            this.dataGridViewSuits.AllowUserToDeleteRows = false;
            this.dataGridViewSuits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSuits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CSTime,
            this.CSName,
            this.CSPrice,
            this.CSLoadout,
            this.CSPrimary1,
            this.CSPrimary2,
            this.CSSecondary});
            this.dataGridViewSuits.ContextMenuStrip = this.contextMenuStripSuits;
            this.dataGridViewSuits.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSuits.Name = "dataGridViewSuits";
            this.dataGridViewSuits.ReadOnly = true;
            this.dataGridViewSuits.RowHeaderMenuStrip = null;
            this.dataGridViewSuits.RowHeadersVisible = false;
            this.dataGridViewSuits.SingleRowSelect = true;
            this.dataGridViewSuits.Size = new System.Drawing.Size(784, 266);
            this.dataGridViewSuits.TabIndex = 1;
            // 
            // CSTime
            // 
            this.CSTime.HeaderText = "Time";
            this.CSTime.Name = "CSTime";
            this.CSTime.ReadOnly = true;
            // 
            // CSName
            // 
            this.CSName.HeaderText = "Name";
            this.CSName.Name = "CSName";
            this.CSName.ReadOnly = true;
            // 
            // CSPrice
            // 
            this.CSPrice.HeaderText = "Price";
            this.CSPrice.Name = "CSPrice";
            this.CSPrice.ReadOnly = true;
            // 
            // CSLoadout
            // 
            this.CSLoadout.HeaderText = "Loadout";
            this.CSLoadout.Name = "CSLoadout";
            this.CSLoadout.ReadOnly = true;
            // 
            // CSPrimary1
            // 
            this.CSPrimary1.HeaderText = "Primary 1";
            this.CSPrimary1.Name = "CSPrimary1";
            this.CSPrimary1.ReadOnly = true;
            // 
            // CSPrimary2
            // 
            this.CSPrimary2.HeaderText = "Primary 2";
            this.CSPrimary2.Name = "CSPrimary2";
            this.CSPrimary2.ReadOnly = true;
            // 
            // CSSecondary
            // 
            this.CSSecondary.HeaderText = "Secondary";
            this.CSSecondary.Name = "CSSecondary";
            this.CSSecondary.ReadOnly = true;
            // 
            // contextMenuStripSuits
            // 
            this.contextMenuStripSuits.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forceSellShipToolStripMenuItem});
            this.contextMenuStripSuits.Name = "contextMenuStripSuits";
            this.contextMenuStripSuits.Size = new System.Drawing.Size(181, 48);
            // 
            // forceSellShipToolStripMenuItem
            // 
            this.forceSellShipToolStripMenuItem.Name = "forceSellShipToolStripMenuItem";
            this.forceSellShipToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.forceSellShipToolStripMenuItem.Text = "Force Suit Sale";
            this.forceSellShipToolStripMenuItem.Click += new System.EventHandler(this.forceSellSuitToolStripMenuItem_Click);
            // 
            // extScrollBar2
            // 
            this.extScrollBar2.ArrowBorderColor = System.Drawing.Color.LightBlue;
            this.extScrollBar2.ArrowButtonColor = System.Drawing.Color.LightGray;
            this.extScrollBar2.ArrowColorScaling = 0.5F;
            this.extScrollBar2.ArrowDownDrawAngle = 270F;
            this.extScrollBar2.ArrowUpDrawAngle = 90F;
            this.extScrollBar2.BorderColor = System.Drawing.Color.White;
            this.extScrollBar2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.extScrollBar2.HideScrollBar = false;
            this.extScrollBar2.LargeChange = 0;
            this.extScrollBar2.Location = new System.Drawing.Point(784, 0);
            this.extScrollBar2.Maximum = -1;
            this.extScrollBar2.Minimum = 0;
            this.extScrollBar2.MouseOverButtonColor = System.Drawing.Color.Green;
            this.extScrollBar2.MousePressedButtonColor = System.Drawing.Color.Red;
            this.extScrollBar2.Name = "extScrollBar2";
            this.extScrollBar2.Size = new System.Drawing.Size(16, 266);
            this.extScrollBar2.SliderColor = System.Drawing.Color.DarkGray;
            this.extScrollBar2.SmallChange = 1;
            this.extScrollBar2.TabIndex = 0;
            this.extScrollBar2.Text = "extScrollBar2";
            this.extScrollBar2.ThumbBorderColor = System.Drawing.Color.Yellow;
            this.extScrollBar2.ThumbButtonColor = System.Drawing.Color.DarkBlue;
            this.extScrollBar2.ThumbColorScaling = 0.5F;
            this.extScrollBar2.ThumbDrawAngle = 0F;
            this.extScrollBar2.Value = -1;
            this.extScrollBar2.ValueLimited = -1;
            // 
            // toolTip
            // 
            this.toolTip.ShowAlways = true;
            // 
            // splitContainerMissions
            // 
            this.splitContainerMissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMissions.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMissions.Name = "splitContainerMissions";
            this.splitContainerMissions.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMissions.Panel1
            // 
            this.splitContainerMissions.Panel1.Controls.Add(this.panelCurrent);
            // 
            // splitContainerMissions.Panel2
            // 
            this.splitContainerMissions.Panel2.Controls.Add(this.panelPrev);
            this.splitContainerMissions.Size = new System.Drawing.Size(800, 572);
            this.splitContainerMissions.SplitterDistance = 266;
            this.splitContainerMissions.TabIndex = 3;
            // 
            // UserControlSuitsWeapons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerMissions);
            this.Name = "UserControlSuitsWeapons";
            this.Size = new System.Drawing.Size(800, 572);
            this.panelPrev.ResumeLayout(false);
            this.extPanelDataGridViewScrollWeapons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeapons)).EndInit();
            this.panelCurrent.ResumeLayout(false);
            this.extPanelDataGridViewScrollSuits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuits)).EndInit();
            this.contextMenuStripSuits.ResumeLayout(false);
            this.splitContainerMissions.Panel1.ResumeLayout(false);
            this.splitContainerMissions.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMissions)).EndInit();
            this.splitContainerMissions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panelPrev;
        private System.Windows.Forms.Panel panelCurrent;
        private System.Windows.Forms.SplitContainer splitContainerMissions;
        private ExtendedControls.ExtPanelDataGridViewScroll extPanelDataGridViewScrollWeapons;
        private BaseUtils.DataGridViewColumnHider dataGridViewWeapons;
        private ExtendedControls.ExtScrollBar extScrollBar1;
        private ExtendedControls.ExtPanelDataGridViewScroll extPanelDataGridViewScrollSuits;
        private BaseUtils.DataGridViewColumnHider dataGridViewSuits;
        private ExtendedControls.ExtScrollBar extScrollBar2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CWTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CWName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CWPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CWDPS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSLoadout;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSPrimary1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSPrimary2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSSecondary;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSuits;
        private System.Windows.Forms.ToolStripMenuItem forceSellShipToolStripMenuItem;
    }
}
