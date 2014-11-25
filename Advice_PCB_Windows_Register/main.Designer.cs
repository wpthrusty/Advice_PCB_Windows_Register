namespace Advice_PCB_Windows_Register
{
    partial class main
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.listView1 = new System.Windows.Forms.ListView();
            this.top_toolstip = new System.Windows.Forms.ToolStrip();
            this.bottom_toolstip = new System.Windows.Forms.ToolStrip();
            this.bottom_toolstip_timetext = new System.Windows.Forms.ToolStripLabel();
            this.time_tick = new System.Windows.Forms.Timer(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bottom_toolstip_datetext = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bottom_toolstip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.CadetBlue;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(871, 511);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // top_toolstip
            // 
            this.top_toolstip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.top_toolstip.Location = new System.Drawing.Point(0, 0);
            this.top_toolstip.Name = "top_toolstip";
            this.top_toolstip.Size = new System.Drawing.Size(871, 25);
            this.top_toolstip.TabIndex = 1;
            this.top_toolstip.Text = "toolStrip1";
            // 
            // bottom_toolstip
            // 
            this.bottom_toolstip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_toolstip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bottom_toolstip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bottom_toolstip_datetext,
            this.toolStripLabel2,
            this.bottom_toolstip_timetext,
            this.toolStripSeparator1});
            this.bottom_toolstip.Location = new System.Drawing.Point(0, 486);
            this.bottom_toolstip.Name = "bottom_toolstip";
            this.bottom_toolstip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bottom_toolstip.Size = new System.Drawing.Size(871, 25);
            this.bottom_toolstip.TabIndex = 2;
            this.bottom_toolstip.Text = "toolStrip2";
            // 
            // bottom_toolstip_timetext
            // 
            this.bottom_toolstip_timetext.Name = "bottom_toolstip_timetext";
            this.bottom_toolstip_timetext.Size = new System.Drawing.Size(49, 22);
            this.bottom_toolstip_timetext.Text = "00:00:00";
            this.bottom_toolstip_timetext.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // time_tick
            // 
            this.time_tick.Enabled = true;
            this.time_tick.Interval = 1000;
            this.time_tick.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bottom_toolstip_datetext
            // 
            this.bottom_toolstip_datetext.Name = "bottom_toolstip_datetext";
            this.bottom_toolstip_datetext.Size = new System.Drawing.Size(65, 22);
            this.bottom_toolstip_datetext.Text = "00/00/0000";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(10, 22);
            this.toolStripLabel2.Text = "|";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(448, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(330, 268);
            this.dataGridView1.TabIndex = 3;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 511);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bottom_toolstip);
            this.Controls.Add(this.top_toolstip);
            this.Controls.Add(this.listView1);
            this.Name = "main";
            this.Text = "Advice Prachinburi - Technician Department Application";
            this.Load += new System.EventHandler(this.main_Load);
            this.bottom_toolstip.ResumeLayout(false);
            this.bottom_toolstip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStrip top_toolstip;
        private System.Windows.Forms.ToolStrip bottom_toolstip;
        private System.Windows.Forms.ToolStripLabel bottom_toolstip_timetext;
        private System.Windows.Forms.Timer time_tick;
        private System.Windows.Forms.ToolStripLabel bottom_toolstip_datetext;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

