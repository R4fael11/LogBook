namespace LogBook.Vew
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diarioDeBordoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dioarioDeBorodoPorTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dioarioDeBorodoPorAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.relatorioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.diarioDeBordoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alunoToolStripMenuItem.Text = "Alunos";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
            // 
            // diarioDeBordoToolStripMenuItem
            // 
            this.diarioDeBordoToolStripMenuItem.Name = "diarioDeBordoToolStripMenuItem";
            this.diarioDeBordoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.diarioDeBordoToolStripMenuItem.Text = "Diario de Bordo";
            this.diarioDeBordoToolStripMenuItem.Click += new System.EventHandler(this.diarioDeBordoToolStripMenuItem_Click);
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dioarioDeBorodoPorTurmaToolStripMenuItem,
            this.dioarioDeBorodoPorAlunoToolStripMenuItem});
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatorioToolStripMenuItem.Text = "Relatorio";
            // 
            // dioarioDeBorodoPorTurmaToolStripMenuItem
            // 
            this.dioarioDeBorodoPorTurmaToolStripMenuItem.Name = "dioarioDeBorodoPorTurmaToolStripMenuItem";
            this.dioarioDeBorodoPorTurmaToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.dioarioDeBorodoPorTurmaToolStripMenuItem.Text = "Dioario de Borodo por Turma";
            // 
            // dioarioDeBorodoPorAlunoToolStripMenuItem
            // 
            this.dioarioDeBorodoPorAlunoToolStripMenuItem.Name = "dioarioDeBorodoPorAlunoToolStripMenuItem";
            this.dioarioDeBorodoPorAlunoToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.dioarioDeBorodoPorAlunoToolStripMenuItem.Text = "Dioario de Borodo por Aluno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 583);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Admistrador do Sistema";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diarioDeBordoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dioarioDeBorodoPorTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dioarioDeBorodoPorAlunoToolStripMenuItem;
    }
}

