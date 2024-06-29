namespace Notepad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            file = new ToolStripMenuItem();
            newTab = new ToolStripMenuItem();
            open = new ToolStripMenuItem();
            save = new ToolStripMenuItem();
            saveAll = new ToolStripMenuItem();
            exit = new ToolStripMenuItem();
            edit = new ToolStripMenuItem();
            undo = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            cut = new ToolStripMenuItem();
            copy = new ToolStripMenuItem();
            paste = new ToolStripMenuItem();
            selectAll = new ToolStripMenuItem();
            view = new ToolStripMenuItem();
            zoom = new ToolStripMenuItem();
            zoomOutToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlText;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { file, edit, view, formatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 46);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // file
            // 
            file.BackColor = SystemColors.ActiveCaptionText;
            file.BackgroundImageLayout = ImageLayout.None;
            file.DropDownItems.AddRange(new ToolStripItem[] { newTab, open, save, saveAll, exit });
            file.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            file.ForeColor = Color.Snow;
            file.Margin = new Padding(0, 0, 20, 0);
            file.Name = "file";
            file.ShortcutKeys = Keys.Alt | Keys.F;
            file.Size = new Size(74, 42);
            file.Text = "File";
            file.ToolTipText = "File";
            file.Click += fileToolStripMenuItem_Click;
            // 
            // newTab
            // 
            newTab.Name = "newTab";
            newTab.ShortcutKeys = Keys.Control | Keys.N;
            newTab.Size = new Size(330, 42);
            newTab.Text = "New Tab ";
            newTab.Click += newTabCtrlNToolStripMenuItem_Click;
            // 
            // open
            // 
            open.Name = "open";
            open.ShortcutKeys = Keys.Control | Keys.O;
            open.Size = new Size(330, 42);
            open.Text = "Open ";
            open.Click += openToolStripMenuItem_Click;
            // 
            // save
            // 
            save.Name = "save";
            save.ShortcutKeys = Keys.Control | Keys.S;
            save.Size = new Size(330, 42);
            save.Text = "Save";
            save.Click += save_Click;
            // 
            // saveAll
            // 
            saveAll.Name = "saveAll";
            saveAll.ShortcutKeys = Keys.Control | Keys.W;
            saveAll.Size = new Size(330, 42);
            saveAll.Text = "Close Tab";
            saveAll.Click += saveAll_Click;
            // 
            // exit
            // 
            exit.Name = "exit";
            exit.Size = new Size(330, 42);
            exit.Text = "Exit";
            exit.Click += exit_Click;
            // 
            // edit
            // 
            edit.DropDownItems.AddRange(new ToolStripItem[] { undo, redoToolStripMenuItem, cut, copy, paste, selectAll });
            edit.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edit.ForeColor = Color.Snow;
            edit.Margin = new Padding(0, 0, 20, 0);
            edit.Name = "edit";
            edit.ShortcutKeys = Keys.Alt | Keys.E;
            edit.Size = new Size(77, 42);
            edit.Text = "Edit";
            edit.Click += editToolStripMenuItem_Click;
            // 
            // undo
            // 
            undo.Name = "undo";
            undo.ShortcutKeys = Keys.Control | Keys.Z;
            undo.Size = new Size(315, 42);
            undo.Text = "Undo";
            undo.Click += undo_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(315, 42);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // cut
            // 
            cut.Name = "cut";
            cut.ShortcutKeys = Keys.Control | Keys.X;
            cut.Size = new Size(315, 42);
            cut.Text = "Cut";
            cut.Click += cut_Click;
            // 
            // copy
            // 
            copy.Name = "copy";
            copy.ShortcutKeys = Keys.Control | Keys.C;
            copy.Size = new Size(315, 42);
            copy.Text = "Copy";
            copy.Click += copy_Click;
            // 
            // paste
            // 
            paste.Name = "paste";
            paste.ShortcutKeys = Keys.Control | Keys.V;
            paste.Size = new Size(315, 42);
            paste.Text = "Paste";
            paste.Click += paste_Click;
            // 
            // selectAll
            // 
            selectAll.Name = "selectAll";
            selectAll.ShortcutKeys = Keys.Control | Keys.A;
            selectAll.Size = new Size(315, 42);
            selectAll.Text = "Select all";
            selectAll.Click += selectAll_Click;
            // 
            // view
            // 
            view.DropDownItems.AddRange(new ToolStripItem[] { zoom, zoomOutToolStripMenuItem });
            view.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            view.ForeColor = Color.Snow;
            view.Margin = new Padding(0, 0, 20, 0);
            view.Name = "view";
            view.ShortcutKeys = Keys.Alt | Keys.V;
            view.Size = new Size(90, 42);
            view.Text = "View";
            view.Click += viewToolStripMenuItem_Click;
            // 
            // zoom
            // 
            zoom.Name = "zoom";
            zoom.Size = new Size(234, 42);
            zoom.Text = "Zoom In";
            zoom.Click += zoomToolStripMenuItem_Click;
            // 
            // zoomOutToolStripMenuItem
            // 
            zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            zoomOutToolStripMenuItem.Size = new Size(234, 42);
            zoomOutToolStripMenuItem.Text = "Zoom Out";
            zoomOutToolStripMenuItem.Click += zoomOutToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, colorToolStripMenuItem });
            formatToolStripMenuItem.Font = new Font("Segoe UI", 16.2F);
            formatToolStripMenuItem.ForeColor = Color.White;
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(118, 42);
            formatToolStripMenuItem.Text = "Format";
            formatToolStripMenuItem.Click += formatToolStripMenuItem_Click;
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(224, 42);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(224, 42);
            colorToolStripMenuItem.Text = "Color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 46);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(8, 5);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 440);
            tabControl1.TabIndex = 4;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 457);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 29);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.ForeColor = Color.Black;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(76, 23);
            toolStripStatusLabel1.Text = "NotePad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(statusStrip1);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            ForeColor = Color.Cornsilk;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notepad";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem file;
        private ToolStripMenuItem newTab;
        private ToolStripMenuItem open;
        private ToolStripMenuItem save;
        private ToolStripMenuItem saveAll;
        private ToolStripMenuItem exit;
        private ToolStripMenuItem edit;
        private ToolStripMenuItem view;
        private ToolStripMenuItem undo;
        private ToolStripMenuItem cut;
        private ToolStripMenuItem copy;
        private ToolStripMenuItem paste;
        private ToolStripMenuItem selectAll;
        private ToolStripMenuItem zoom;
        private TabControl tabControl1;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
