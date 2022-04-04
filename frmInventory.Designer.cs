namespace CSGOCaseOpening
{
    partial class frmInventory
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
            this.lvInventory = new System.Windows.Forms.ListView();
            this.columnHeaderArma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFloat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatTrak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKnifes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvInventory
            // 
            this.lvInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderArma,
            this.columnHeaderCor,
            this.columnHeaderEstado,
            this.columnHeaderFloat,
            this.columnHeaderStatTrak});
            this.lvInventory.GridLines = true;
            this.lvInventory.HideSelection = false;
            this.lvInventory.Location = new System.Drawing.Point(100, 15);
            this.lvInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvInventory.Name = "lvInventory";
            this.lvInventory.Size = new System.Drawing.Size(1573, 771);
            this.lvInventory.TabIndex = 0;
            this.lvInventory.UseCompatibleStateImageBehavior = false;
            this.lvInventory.View = System.Windows.Forms.View.Details;
            this.lvInventory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvInventory_KeyDown);
            this.lvInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvInventory_KeyPress);
            this.lvInventory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lvInventory_KeyUp);
            // 
            // columnHeaderArma
            // 
            this.columnHeaderArma.Text = "Arma";
            this.columnHeaderArma.Width = 269;
            // 
            // columnHeaderCor
            // 
            this.columnHeaderCor.Text = "Cor";
            this.columnHeaderCor.Width = 116;
            // 
            // columnHeaderEstado
            // 
            this.columnHeaderEstado.Text = "Estado";
            this.columnHeaderEstado.Width = 150;
            // 
            // columnHeaderFloat
            // 
            this.columnHeaderFloat.Text = "Float";
            this.columnHeaderFloat.Width = 525;
            // 
            // columnHeaderStatTrak
            // 
            this.columnHeaderStatTrak.Text = "StatTrak";
            this.columnHeaderStatTrak.Width = 118;
            // 
            // btnKnifes
            // 
            this.btnKnifes.Location = new System.Drawing.Point(29, 794);
            this.btnKnifes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKnifes.Name = "btnKnifes";
            this.btnKnifes.Size = new System.Drawing.Size(100, 28);
            this.btnKnifes.TabIndex = 1;
            this.btnKnifes.Text = "Knifes";
            this.btnKnifes.UseVisualStyleBackColor = true;
            this.btnKnifes.Click += new System.EventHandler(this.btnKnifes_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1791, 828);
            this.Controls.Add(this.btnKnifes);
            this.Controls.Add(this.lvInventory);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInventory";
            this.Text = "frmInventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvInventory;
        private System.Windows.Forms.ColumnHeader columnHeaderArma;
        private System.Windows.Forms.ColumnHeader columnHeaderCor;
        private System.Windows.Forms.ColumnHeader columnHeaderEstado;
        private System.Windows.Forms.ColumnHeader columnHeaderFloat;
        private System.Windows.Forms.ColumnHeader columnHeaderStatTrak;
        private System.Windows.Forms.Button btnKnifes;
    }
}