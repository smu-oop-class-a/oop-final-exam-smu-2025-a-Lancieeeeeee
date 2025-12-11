namespace OOP.FinalTerm.Exam
{
    partial class SettingsForm
    {
       
        private System.ComponentModel.IContainer components = null;

      
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblTitle = new Label();
            tabControl = new TabControl();
            tabMovies = new TabPage();
            panel2 = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            panel3 = new Panel();
            dgvMovies = new DataGridView();
            tabDirectors = new TabPage();
            panel4 = new Panel();
            btnDirectorAdd = new Button();
            panel5 = new Panel();
            dgvDirectors = new DataGridView();
            panel1.SuspendLayout();
            tabControl.SuspendLayout();
            tabMovies.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            tabDirectors.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDirectors).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 20, 20);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 60);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(15, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(143, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Management";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabMovies);
            tabControl.Controls.Add(tabDirectors);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 60);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1000, 540);
            tabControl.TabIndex = 1;
            tabControl.BackColor = Color.FromArgb(30, 30, 30);
            tabControl.ForeColor = Color.White;
            // 
            // tabMovies
            // 
            tabMovies.BackColor = Color.FromArgb(30, 30, 30);
            tabMovies.Controls.Add(panel3);
            tabMovies.Controls.Add(panel2);
            tabMovies.Location = new Point(4, 24);
            tabMovies.Name = "tabMovies";
            tabMovies.Padding = new Padding(3);
            tabMovies.Size = new Size(992, 512);
            tabMovies.TabIndex = 0;
            tabMovies.Text = "🎬 Movies";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(20, 20, 20);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnAdd);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 439);
            panel2.Name = "panel2";
            panel2.Size = new Size(986, 70);
            panel2.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(120, 0, 0);
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(540, 15);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "🗑️ Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(100, 100, 100);
            btnEdit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(350, 15);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 40);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "✏️ Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(221, 0, 0);
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(160, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 40);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "➕ Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Click += BtnAdd_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 30, 30);
            panel3.Controls.Add(dgvMovies);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(986, 436);
            panel3.TabIndex = 2;
            // 
            // dgvMovies
            // 
            dgvMovies.AllowUserToAddRows = false;
            dgvMovies.AllowUserToDeleteRows = false;
            dgvMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovies.BackgroundColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(20, 20, 20);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(221, 0, 0);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovies.Dock = DockStyle.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(221, 0, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMovies.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMovies.EnableHeadersVisualStyles = false;
            dgvMovies.GridColor = Color.FromArgb(60, 60, 60);
            dgvMovies.Location = new Point(10, 10);
            dgvMovies.Name = "dgvMovies";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(20, 20, 20);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(221, 0, 0);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvMovies.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvMovies.RowHeadersWidth = 50;
            dgvMovies.Size = new Size(966, 416);
            dgvMovies.TabIndex = 0;
            // 
            // tabDirectors
            // 
            tabDirectors.BackColor = Color.FromArgb(30, 30, 30);
            tabDirectors.Controls.Add(panel5);
            tabDirectors.Controls.Add(panel4);
            tabDirectors.Location = new Point(4, 24);
            tabDirectors.Name = "tabDirectors";
            tabDirectors.Padding = new Padding(3);
            tabDirectors.Size = new Size(992, 512);
            tabDirectors.TabIndex = 1;
            tabDirectors.Text = "👤 Directors";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(20, 20, 20);
            panel4.Controls.Add(btnDirectorAdd);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(3, 439);
            panel4.Name = "panel4";
            panel4.Size = new Size(986, 70);
            panel4.TabIndex = 3;
            // 
            // btnDirectorAdd
            // 
            btnDirectorAdd.BackColor = Color.FromArgb(221, 0, 0);
            btnDirectorAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDirectorAdd.ForeColor = Color.White;
            btnDirectorAdd.Location = new Point(160, 15);
            btnDirectorAdd.Name = "btnDirectorAdd";
            btnDirectorAdd.Size = new Size(100, 40);
            btnDirectorAdd.TabIndex = 0;
            btnDirectorAdd.Text = "➕ Add";
            btnDirectorAdd.UseVisualStyleBackColor = false;
            btnDirectorAdd.FlatStyle = FlatStyle.Flat;
            btnDirectorAdd.FlatAppearance.BorderSize = 0;
            btnDirectorAdd.Click += BtnDirectorAdd_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 30, 30);
            panel5.Controls.Add(dgvDirectors);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(10);
            panel5.Size = new Size(986, 436);
            panel5.TabIndex = 4;
            // 
            // dgvDirectors
            // 
            dgvDirectors.AllowUserToAddRows = false;
            dgvDirectors.AllowUserToDeleteRows = false;
            dgvDirectors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDirectors.BackgroundColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(20, 20, 20);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(221, 0, 0);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDirectors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDirectors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDirectors.Dock = DockStyle.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(221, 0, 0);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvDirectors.DefaultCellStyle = dataGridViewCellStyle5;
            dgvDirectors.EnableHeadersVisualStyles = false;
            dgvDirectors.GridColor = Color.FromArgb(60, 60, 60);
            dgvDirectors.Location = new Point(10, 10);
            dgvDirectors.Name = "dgvDirectors";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(20, 20, 20);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(221, 0, 0);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvDirectors.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvDirectors.RowHeadersWidth = 50;
            dgvDirectors.Size = new Size(966, 416);
            dgvDirectors.TabIndex = 0;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1000, 600);
            Controls.Add(tabControl);
            Controls.Add(panel1);
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings - Management";
            Load += SettingsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabMovies.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            tabDirectors.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDirectors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private TabControl tabControl;
        private TabPage tabMovies;
        private Panel panel2;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Panel panel3;
        private DataGridView dgvMovies;
        private TabPage tabDirectors;
        private Panel panel4;
        private Button btnDirectorAdd;
        private Panel panel5;
        private DataGridView dgvDirectors;
    }
}