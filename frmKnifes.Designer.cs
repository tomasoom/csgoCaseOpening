namespace CSGOCaseOpening
{
    partial class frmKnifes
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
            this.lvInventory.Location = new System.Drawing.Point(39, 12);
            this.lvInventory.Name = "lvInventory";
            this.lvInventory.Size = new System.Drawing.Size(1181, 627);
            this.lvInventory.TabIndex = 1;
            this.lvInventory.UseCompatibleStateImageBehavior = false;
            this.lvInventory.View = System.Windows.Forms.View.Details;
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
            // frmKnifes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 670);
            this.Controls.Add(this.lvInventory);
            this.Name = "frmKnifes";
            this.Text = "frmKnifes";
            this.Load += new System.EventHandler(this.frmKnifes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvInventory;
        private System.Windows.Forms.ColumnHeader columnHeaderArma;
        private System.Windows.Forms.ColumnHeader columnHeaderCor;
        private System.Windows.Forms.ColumnHeader columnHeaderEstado;
        private System.Windows.Forms.ColumnHeader columnHeaderFloat;
        private System.Windows.Forms.ColumnHeader columnHeaderStatTrak;
    }
}