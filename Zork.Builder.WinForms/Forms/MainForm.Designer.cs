﻿namespace InventoryManager.WinForms.Forms
{
    partial class MainForm
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
            System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
            System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.playersTabPage = new System.Windows.Forms.TabPage();
            this.availableItemsLabel = new System.Windows.Forms.Label();
            this.playerInventoryLabel = new System.Windows.Forms.Label();
            this.playerInventoryListBox = new System.Windows.Forms.ListBox();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.availableItemsListBox = new System.Windows.Forms.ListBox();
            this.removeItemFromInventoryButton = new System.Windows.Forms.Button();
            this.addItemToInventoryButton = new System.Windows.Forms.Button();
            this.playerScoreTextBox = new System.Windows.Forms.TextBox();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.playerHealthTextBox = new System.Windows.Forms.TextBox();
            this.playerHealthLabel = new System.Windows.Forms.Label();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.deletePlayerButton = new System.Windows.Forms.Button();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.playersListBox = new System.Windows.Forms.ListBox();
            this.itemsTabPage = new System.Windows.Forms.TabPage();
            this.itemWeightTextBox = new System.Windows.Forms.TextBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemWeightLabel = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.mapTabPage = new System.Windows.Forms.TabPage();
            this.mapAreaListBox = new System.Windows.Forms.ListBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.welcomeGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.deleteWelcomeMessageButton = new System.Windows.Forms.Button();
            this.newWelcomeMessageButton = new System.Windows.Forms.Button();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.playersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            this.itemsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.mapTabPage.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.welcomeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(231, 6);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(231, 6);
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(InventoryManager.WinForms.ViewModels.WorldViewModel);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files (*json)|*.json";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.playersTabPage);
            this.mainTabControl.Controls.Add(this.itemsTabPage);
            this.mainTabControl.Controls.Add(this.mapTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(20, 33);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(828, 681);
            this.mainTabControl.TabIndex = 1;
            // 
            // playersTabPage
            // 
            this.playersTabPage.Controls.Add(this.availableItemsLabel);
            this.playersTabPage.Controls.Add(this.playerInventoryLabel);
            this.playersTabPage.Controls.Add(this.playerInventoryListBox);
            this.playersTabPage.Controls.Add(this.availableItemsListBox);
            this.playersTabPage.Controls.Add(this.removeItemFromInventoryButton);
            this.playersTabPage.Controls.Add(this.addItemToInventoryButton);
            this.playersTabPage.Controls.Add(this.playerScoreTextBox);
            this.playersTabPage.Controls.Add(this.playerScoreLabel);
            this.playersTabPage.Controls.Add(this.playerHealthTextBox);
            this.playersTabPage.Controls.Add(this.playerHealthLabel);
            this.playersTabPage.Controls.Add(this.playerNameTextBox);
            this.playersTabPage.Controls.Add(this.playerNameLabel);
            this.playersTabPage.Controls.Add(this.deletePlayerButton);
            this.playersTabPage.Controls.Add(this.addPlayerButton);
            this.playersTabPage.Controls.Add(this.playersListBox);
            this.playersTabPage.Location = new System.Drawing.Point(4, 25);
            this.playersTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.playersTabPage.Name = "playersTabPage";
            this.playersTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.playersTabPage.Size = new System.Drawing.Size(820, 652);
            this.playersTabPage.TabIndex = 0;
            this.playersTabPage.Text = "Players";
            this.playersTabPage.UseVisualStyleBackColor = true;
            // 
            // availableItemsLabel
            // 
            this.availableItemsLabel.AutoSize = true;
            this.availableItemsLabel.Location = new System.Drawing.Point(589, 155);
            this.availableItemsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.availableItemsLabel.Name = "availableItemsLabel";
            this.availableItemsLabel.Size = new System.Drawing.Size(102, 17);
            this.availableItemsLabel.TabIndex = 13;
            this.availableItemsLabel.Text = "&Available Items";
            // 
            // playerInventoryLabel
            // 
            this.playerInventoryLabel.AutoSize = true;
            this.playerInventoryLabel.Location = new System.Drawing.Point(259, 155);
            this.playerInventoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerInventoryLabel.Name = "playerInventoryLabel";
            this.playerInventoryLabel.Size = new System.Drawing.Size(66, 17);
            this.playerInventoryLabel.TabIndex = 9;
            this.playerInventoryLabel.Text = "In&ventory";
            // 
            // playerInventoryListBox
            // 
            this.playerInventoryListBox.DataSource = this.inventoryBindingSource;
            this.playerInventoryListBox.DisplayMember = "Name";
            this.playerInventoryListBox.FormattingEnabled = true;
            this.playerInventoryListBox.ItemHeight = 16;
            this.playerInventoryListBox.Location = new System.Drawing.Point(263, 178);
            this.playerInventoryListBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerInventoryListBox.Name = "playerInventoryListBox";
            this.playerInventoryListBox.Size = new System.Drawing.Size(213, 404);
            this.playerInventoryListBox.TabIndex = 10;
            this.playerInventoryListBox.ValueMember = "Name";
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.playersBindingSource;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.AllowNew = true;
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // availableItemsListBox
            // 
            this.availableItemsListBox.FormattingEnabled = true;
            this.availableItemsListBox.ItemHeight = 16;
            this.availableItemsListBox.Location = new System.Drawing.Point(593, 175);
            this.availableItemsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.availableItemsListBox.Name = "availableItemsListBox";
            this.availableItemsListBox.Size = new System.Drawing.Size(213, 404);
            this.availableItemsListBox.TabIndex = 14;
            // 
            // removeItemFromInventoryButton
            // 
            this.removeItemFromInventoryButton.Location = new System.Drawing.Point(485, 326);
            this.removeItemFromInventoryButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeItemFromInventoryButton.Name = "removeItemFromInventoryButton";
            this.removeItemFromInventoryButton.Size = new System.Drawing.Size(100, 28);
            this.removeItemFromInventoryButton.TabIndex = 12;
            this.removeItemFromInventoryButton.Text = ">>";
            this.removeItemFromInventoryButton.UseVisualStyleBackColor = true;
            this.removeItemFromInventoryButton.Click += new System.EventHandler(this.RemoveItemFromInventoryButton_Click);
            // 
            // addItemToInventoryButton
            // 
            this.addItemToInventoryButton.Location = new System.Drawing.Point(485, 290);
            this.addItemToInventoryButton.Margin = new System.Windows.Forms.Padding(4);
            this.addItemToInventoryButton.Name = "addItemToInventoryButton";
            this.addItemToInventoryButton.Size = new System.Drawing.Size(100, 28);
            this.addItemToInventoryButton.TabIndex = 11;
            this.addItemToInventoryButton.Text = "<<";
            this.addItemToInventoryButton.UseVisualStyleBackColor = true;
            this.addItemToInventoryButton.Click += new System.EventHandler(this.AddItemToInventoryButton_Click);
            // 
            // playerScoreTextBox
            // 
            this.playerScoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Score", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.playerScoreTextBox.Location = new System.Drawing.Point(263, 127);
            this.playerScoreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerScoreTextBox.Name = "playerScoreTextBox";
            this.playerScoreTextBox.Size = new System.Drawing.Size(116, 22);
            this.playerScoreTextBox.TabIndex = 8;
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.Location = new System.Drawing.Point(259, 106);
            this.playerScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(49, 17);
            this.playerScoreLabel.TabIndex = 7;
            this.playerScoreLabel.Text = "&Score:";
            // 
            // playerHealthTextBox
            // 
            this.playerHealthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Health", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.playerHealthTextBox.Location = new System.Drawing.Point(263, 78);
            this.playerHealthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerHealthTextBox.Name = "playerHealthTextBox";
            this.playerHealthTextBox.Size = new System.Drawing.Size(116, 22);
            this.playerHealthTextBox.TabIndex = 6;
            // 
            // playerHealthLabel
            // 
            this.playerHealthLabel.AutoSize = true;
            this.playerHealthLabel.Location = new System.Drawing.Point(259, 57);
            this.playerHealthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerHealthLabel.Name = "playerHealthLabel";
            this.playerHealthLabel.Size = new System.Drawing.Size(53, 17);
            this.playerHealthLabel.TabIndex = 5;
            this.playerHealthLabel.Text = "&Health:";
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.playerNameTextBox.Location = new System.Drawing.Point(263, 28);
            this.playerNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(356, 22);
            this.playerNameTextBox.TabIndex = 4;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(259, 7);
            this.playerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(49, 17);
            this.playerNameLabel.TabIndex = 3;
            this.playerNameLabel.Text = "&Name:";
            // 
            // deletePlayerButton
            // 
            this.deletePlayerButton.Location = new System.Drawing.Point(119, 612);
            this.deletePlayerButton.Margin = new System.Windows.Forms.Padding(4);
            this.deletePlayerButton.Name = "deletePlayerButton";
            this.deletePlayerButton.Size = new System.Drawing.Size(100, 28);
            this.deletePlayerButton.TabIndex = 2;
            this.deletePlayerButton.Text = "&Delete";
            this.deletePlayerButton.UseVisualStyleBackColor = true;
            this.deletePlayerButton.Click += new System.EventHandler(this.DeletePlayerButton_Click);
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(11, 612);
            this.addPlayerButton.Margin = new System.Windows.Forms.Padding(4);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(100, 28);
            this.addPlayerButton.TabIndex = 1;
            this.addPlayerButton.Text = "&Add...";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // playersListBox
            // 
            this.playersListBox.DataSource = this.playersBindingSource;
            this.playersListBox.DisplayMember = "Name";
            this.playersListBox.FormattingEnabled = true;
            this.playersListBox.ItemHeight = 16;
            this.playersListBox.Location = new System.Drawing.Point(8, 7);
            this.playersListBox.Margin = new System.Windows.Forms.Padding(4);
            this.playersListBox.Name = "playersListBox";
            this.playersListBox.Size = new System.Drawing.Size(241, 596);
            this.playersListBox.TabIndex = 0;
            this.playersListBox.ValueMember = "Health";
            this.playersListBox.SelectedIndexChanged += new System.EventHandler(this.PlayersListBox_SelectedIndexChanged);
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.Controls.Add(this.itemWeightTextBox);
            this.itemsTabPage.Controls.Add(this.itemWeightLabel);
            this.itemsTabPage.Controls.Add(this.itemNameTextBox);
            this.itemsTabPage.Controls.Add(this.itemNameLabel);
            this.itemsTabPage.Controls.Add(this.deleteItemButton);
            this.itemsTabPage.Controls.Add(this.addItemButton);
            this.itemsTabPage.Controls.Add(this.itemsListBox);
            this.itemsTabPage.Location = new System.Drawing.Point(4, 25);
            this.itemsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.itemsTabPage.Size = new System.Drawing.Size(820, 652);
            this.itemsTabPage.TabIndex = 1;
            this.itemsTabPage.Text = "Items";
            this.itemsTabPage.UseVisualStyleBackColor = true;
            // 
            // itemWeightTextBox
            // 
            this.itemWeightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Weight", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.itemWeightTextBox.Location = new System.Drawing.Point(228, 78);
            this.itemWeightTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.itemWeightTextBox.Name = "itemWeightTextBox";
            this.itemWeightTextBox.Size = new System.Drawing.Size(116, 22);
            this.itemWeightTextBox.TabIndex = 6;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // itemWeightLabel
            // 
            this.itemWeightLabel.AutoSize = true;
            this.itemWeightLabel.Location = new System.Drawing.Point(224, 57);
            this.itemWeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemWeightLabel.Name = "itemWeightLabel";
            this.itemWeightLabel.Size = new System.Drawing.Size(56, 17);
            this.itemWeightLabel.TabIndex = 5;
            this.itemWeightLabel.Text = "&Weight:";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.itemNameTextBox.Location = new System.Drawing.Point(228, 28);
            this.itemNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(356, 22);
            this.itemNameTextBox.TabIndex = 4;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(224, 7);
            this.itemNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(49, 17);
            this.itemNameLabel.TabIndex = 3;
            this.itemNameLabel.Text = "&Name:";
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(116, 612);
            this.deleteItemButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(100, 28);
            this.deleteItemButton.TabIndex = 2;
            this.deleteItemButton.Text = "&Delete";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(8, 612);
            this.addItemButton.Margin = new System.Windows.Forms.Padding(4);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(100, 28);
            this.addItemButton.TabIndex = 1;
            this.addItemButton.Text = "&Add...";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // itemsListBox
            // 
            this.itemsListBox.DataSource = this.itemsBindingSource;
            this.itemsListBox.DisplayMember = "Name";
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 16;
            this.itemsListBox.Location = new System.Drawing.Point(8, 7);
            this.itemsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(207, 596);
            this.itemsListBox.TabIndex = 0;
            this.itemsListBox.ValueMember = "Name";
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // mapTabPage
            // 
            this.mapTabPage.Controls.Add(this.deleteWelcomeMessageButton);
            this.mapTabPage.Controls.Add(this.newWelcomeMessageButton);
            this.mapTabPage.Controls.Add(this.welcomeGroupBox);
            this.mapTabPage.Controls.Add(this.mapAreaListBox);
            this.mapTabPage.Location = new System.Drawing.Point(4, 25);
            this.mapTabPage.Name = "mapTabPage";
            this.mapTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mapTabPage.Size = new System.Drawing.Size(820, 652);
            this.mapTabPage.TabIndex = 2;
            this.mapTabPage.Text = "Map";
            this.mapTabPage.UseVisualStyleBackColor = true;
            // 
            // mapAreaListBox
            // 
            this.mapAreaListBox.DisplayMember = "Health";
            this.mapAreaListBox.FormattingEnabled = true;
            this.mapAreaListBox.ItemHeight = 16;
            this.mapAreaListBox.Location = new System.Drawing.Point(7, 17);
            this.mapAreaListBox.Margin = new System.Windows.Forms.Padding(4);
            this.mapAreaListBox.Name = "mapAreaListBox";
            this.mapAreaListBox.Size = new System.Drawing.Size(241, 628);
            this.mapAreaListBox.TabIndex = 1;
            this.mapAreaListBox.ValueMember = "Health";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(865, 28);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWorldToolStripMenuItem,
            this.openWorldToolStripMenuItem,
            this.closeWorldToolStripMenuItem,
            toolStripMenuItem2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newWorldToolStripMenuItem
            // 
            this.newWorldToolStripMenuItem.Name = "newWorldToolStripMenuItem";
            this.newWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newWorldToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.newWorldToolStripMenuItem.Text = "&New World...";
            this.newWorldToolStripMenuItem.Click += new System.EventHandler(this.NewWorldToolStripMenuItem_Click);
            // 
            // openWorldToolStripMenuItem
            // 
            this.openWorldToolStripMenuItem.Name = "openWorldToolStripMenuItem";
            this.openWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openWorldToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.openWorldToolStripMenuItem.Text = "&Open World...";
            this.openWorldToolStripMenuItem.Click += new System.EventHandler(this.OpenWorldToolStripMenuItem_Click);
            // 
            // closeWorldToolStripMenuItem
            // 
            this.closeWorldToolStripMenuItem.Name = "closeWorldToolStripMenuItem";
            this.closeWorldToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.closeWorldToolStripMenuItem.Text = "&Close World";
            this.closeWorldToolStripMenuItem.Click += new System.EventHandler(this.CloseWorldToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "World files (*.json)|*.json";
            this.saveFileDialog.Title = "Save world file";
            // 
            // welcomeGroupBox
            // 
            this.welcomeGroupBox.Controls.Add(this.textBox1);
            this.welcomeGroupBox.Location = new System.Drawing.Point(255, 545);
            this.welcomeGroupBox.Name = "welcomeGroupBox";
            this.welcomeGroupBox.Size = new System.Drawing.Size(359, 56);
            this.welcomeGroupBox.TabIndex = 2;
            this.welcomeGroupBox.TabStop = false;
            this.welcomeGroupBox.Text = "&Welcome Message:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(347, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "\"Welcome to Zork!\"";
            // 
            // deleteWelcomeMessageButton
            // 
            this.deleteWelcomeMessageButton.Location = new System.Drawing.Point(514, 608);
            this.deleteWelcomeMessageButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteWelcomeMessageButton.Name = "deleteWelcomeMessageButton";
            this.deleteWelcomeMessageButton.Size = new System.Drawing.Size(100, 28);
            this.deleteWelcomeMessageButton.TabIndex = 4;
            this.deleteWelcomeMessageButton.Text = "&Delete";
            this.deleteWelcomeMessageButton.UseVisualStyleBackColor = true;
            // 
            // newWelcomeMessageButton
            // 
            this.newWelcomeMessageButton.Location = new System.Drawing.Point(406, 608);
            this.newWelcomeMessageButton.Margin = new System.Windows.Forms.Padding(4);
            this.newWelcomeMessageButton.Name = "newWelcomeMessageButton";
            this.newWelcomeMessageButton.Size = new System.Drawing.Size(100, 28);
            this.newWelcomeMessageButton.TabIndex = 3;
            this.newWelcomeMessageButton.Text = "&New...";
            this.newWelcomeMessageButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 726);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.mainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Inventory Manager";
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.playersTabPage.ResumeLayout(false);
            this.playersTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            this.itemsTabPage.ResumeLayout(false);
            this.itemsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.mapTabPage.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.welcomeGroupBox.ResumeLayout(false);
            this.welcomeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage playersTabPage;
        private System.Windows.Forms.TabPage itemsTabPage;
        private System.Windows.Forms.ListBox playersListBox;
        private System.Windows.Forms.Button deletePlayerButton;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.TextBox playerScoreTextBox;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.TextBox playerHealthTextBox;
        private System.Windows.Forms.Label playerHealthLabel;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.Label playerInventoryLabel;
        private System.Windows.Forms.ListBox playerInventoryListBox;
        private System.Windows.Forms.ListBox availableItemsListBox;
        private System.Windows.Forms.Button removeItemFromInventoryButton;
        private System.Windows.Forms.Button addItemToInventoryButton;
        private System.Windows.Forms.Label availableItemsLabel;
        private System.Windows.Forms.ToolStripMenuItem newWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox itemWeightTextBox;
        private System.Windows.Forms.Label itemWeightLabel;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.TabPage mapTabPage;
        private System.Windows.Forms.ListBox mapAreaListBox;
        private System.Windows.Forms.Button deleteWelcomeMessageButton;
        private System.Windows.Forms.Button newWelcomeMessageButton;
        private System.Windows.Forms.GroupBox welcomeGroupBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

