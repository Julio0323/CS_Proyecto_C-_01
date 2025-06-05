namespace CapaPresentacionCliente
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
            dataGridView1 = new DataGridView();
            laber_Nombre = new Label();
            Nombre_Dime = new TextBox();
            Salario_Dime = new TextBox();
            Cargo_Dime = new TextBox();
            Departamento_Dime = new TextBox();
            LabelDepartamento = new Label();
            labelSalario = new Label();
            labelCargo = new Label();
            button1 = new Button();
            tb_ADM = new Button();
            tb_OP = new Button();
            tb_Todos = new Button();
            bt_Eliminar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(784, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(928, 318);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // laber_Nombre
            // 
            laber_Nombre.AutoSize = true;
            laber_Nombre.Location = new Point(12, 42);
            laber_Nombre.Name = "laber_Nombre";
            laber_Nombre.Size = new Size(78, 25);
            laber_Nombre.TabIndex = 1;
            laber_Nombre.Text = "Nombre";
            // 
            // Nombre_Dime
            // 
            Nombre_Dime.Location = new Point(135, 46);
            Nombre_Dime.Name = "Nombre_Dime";
            Nombre_Dime.Size = new Size(226, 31);
            Nombre_Dime.TabIndex = 2;
            // 
            // Salario_Dime
            // 
            Salario_Dime.Location = new Point(119, 290);
            Salario_Dime.Name = "Salario_Dime";
            Salario_Dime.Size = new Size(242, 31);
            Salario_Dime.TabIndex = 3;
            // 
            // Cargo_Dime
            // 
            Cargo_Dime.Location = new Point(119, 199);
            Cargo_Dime.Name = "Cargo_Dime";
            Cargo_Dime.Size = new Size(242, 31);
            Cargo_Dime.TabIndex = 4;
            // 
            // Departamento_Dime
            // 
            Departamento_Dime.Location = new Point(154, 123);
            Departamento_Dime.Name = "Departamento_Dime";
            Departamento_Dime.Size = new Size(207, 31);
            Departamento_Dime.TabIndex = 5;
            Departamento_Dime.TextChanged += textBox4_TextChanged;
            // 
            // LabelDepartamento
            // 
            LabelDepartamento.AutoSize = true;
            LabelDepartamento.Location = new Point(21, 123);
            LabelDepartamento.Name = "LabelDepartamento";
            LabelDepartamento.Size = new Size(127, 25);
            LabelDepartamento.TabIndex = 6;
            LabelDepartamento.Text = "Departamento";
            // 
            // labelSalario
            // 
            labelSalario.AutoSize = true;
            labelSalario.Location = new Point(22, 290);
            labelSalario.Name = "labelSalario";
            labelSalario.Size = new Size(65, 25);
            labelSalario.TabIndex = 7;
            labelSalario.Text = "Salario";
            // 
            // labelCargo
            // 
            labelCargo.AutoSize = true;
            labelCargo.Location = new Point(22, 202);
            labelCargo.Name = "labelCargo";
            labelCargo.Size = new Size(60, 25);
            labelCargo.TabIndex = 8;
            labelCargo.Text = "Cargo";
            // 
            // button1
            // 
            button1.Location = new Point(35, 397);
            button1.Name = "button1";
            button1.Size = new Size(216, 58);
            button1.TabIndex = 9;
            button1.Text = "Mandar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tb_ADM
            // 
            tb_ADM.Location = new Point(1157, 397);
            tb_ADM.Name = "tb_ADM";
            tb_ADM.Size = new Size(147, 58);
            tb_ADM.TabIndex = 10;
            tb_ADM.Text = "ADM";
            tb_ADM.UseVisualStyleBackColor = true;
            tb_ADM.Click += FiltrarPorDepartamento;
            // 
            // tb_OP
            // 
            tb_OP.Location = new Point(1357, 397);
            tb_OP.Name = "tb_OP";
            tb_OP.Size = new Size(150, 58);
            tb_OP.TabIndex = 11;
            tb_OP.Text = "OP";
            tb_OP.UseVisualStyleBackColor = true;
            tb_OP.Click += btnFiltrarAdministrativos_Click;
            // 
            // tb_Todos
            // 
            tb_Todos.Location = new Point(1550, 397);
            tb_Todos.Name = "tb_Todos";
            tb_Todos.Size = new Size(162, 58);
            tb_Todos.TabIndex = 12;
            tb_Todos.Text = "Todos";
            tb_Todos.UseVisualStyleBackColor = true;
            tb_Todos.Click += btnMostrarTodos_Click_Click;
            // 
            // bt_Eliminar
            // 
            bt_Eliminar.Location = new Point(784, 397);
            bt_Eliminar.Name = "bt_Eliminar";
            bt_Eliminar.Size = new Size(171, 58);
            bt_Eliminar.TabIndex = 13;
            bt_Eliminar.Text = "Eliminar";
            bt_Eliminar.UseVisualStyleBackColor = true;
            bt_Eliminar.Click += bt_Eliminar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Negra;
            pictureBox1.Location = new Point(-44, -75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(2549, 1376);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1806, 643);
            Controls.Add(bt_Eliminar);
            Controls.Add(tb_Todos);
            Controls.Add(tb_OP);
            Controls.Add(tb_ADM);
            Controls.Add(button1);
            Controls.Add(labelCargo);
            Controls.Add(labelSalario);
            Controls.Add(LabelDepartamento);
            Controls.Add(Departamento_Dime);
            Controls.Add(Cargo_Dime);
            Controls.Add(Salario_Dime);
            Controls.Add(Nombre_Dime);
            Controls.Add(laber_Nombre);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label laber_Nombre;
        private TextBox Nombre_Dime;
        private TextBox Salario_Dime;
        private TextBox Cargo_Dime;
        private TextBox Departamento_Dime;
        private Label LabelDepartamento;
        private Label labelSalario;
        private Label labelCargo;
        private Button button1;
        private Button tb_ADM;
        private Button tb_OP;
        private Button tb_Todos;
        private Button bt_Eliminar;
        private PictureBox pictureBox1;
    }
}
