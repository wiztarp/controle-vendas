namespace ControleVendas
{
    partial class frmPrincipal
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
            components = new System.ComponentModel.Container();
            sidebarTime = new System.Windows.Forms.Timer(components);
            panelChildForm = new Panel();
            sidebarContainer = new FlowLayoutPanel();
            panelMenu = new Panel();
            containerProcesso = new Panel();
            btnCadastroItens = new Button();
            btnProcesso = new Button();
            timerProcessamento = new System.Windows.Forms.Timer(components);
            panelChildForm.SuspendLayout();
            sidebarContainer.SuspendLayout();
            containerProcesso.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarTime
            // 
            sidebarTime.Interval = 15;
            sidebarTime.Tick += sidebarTime_Tick;
            // 
            // panelChildForm
            // 
            panelChildForm.Controls.Add(sidebarContainer);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(0, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1712, 577);
            panelChildForm.TabIndex = 0;
            // 
            // sidebarContainer
            // 
            sidebarContainer.BackColor = Color.White;
            sidebarContainer.Controls.Add(panelMenu);
            sidebarContainer.Controls.Add(containerProcesso);
            sidebarContainer.Dock = DockStyle.Left;
            sidebarContainer.Location = new Point(0, 0);
            sidebarContainer.MaximumSize = new Size(350, 1400);
            sidebarContainer.MinimumSize = new Size(84, 652);
            sidebarContainer.Name = "sidebarContainer";
            sidebarContainer.Size = new Size(250, 652);
            sidebarContainer.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.Location = new Point(3, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(247, 125);
            panelMenu.TabIndex = 1;
            // 
            // containerProcesso
            // 
            containerProcesso.BackColor = Color.White;
            containerProcesso.Controls.Add(btnCadastroItens);
            containerProcesso.Controls.Add(btnProcesso);
            containerProcesso.Location = new Point(3, 134);
            containerProcesso.MaximumSize = new Size(340, 427);
            containerProcesso.MinimumSize = new Size(340, 54);
            containerProcesso.Name = "containerProcesso";
            containerProcesso.Size = new Size(340, 54);
            containerProcesso.TabIndex = 1;
            containerProcesso.Visible = false;
            // 
            // btnCadastroItens
            // 
            btnCadastroItens.BackColor = Color.LightSteelBlue;
            btnCadastroItens.FlatStyle = FlatStyle.Flat;
            btnCadastroItens.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastroItens.Location = new Point(0, 61);
            btnCadastroItens.Name = "btnCadastroItens";
            btnCadastroItens.Padding = new Padding(30, 0, 0, 0);
            btnCadastroItens.Size = new Size(381, 62);
            btnCadastroItens.TabIndex = 2;
            btnCadastroItens.Text = "          Cadastro de Itens";
            btnCadastroItens.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastroItens.UseVisualStyleBackColor = false;
            // 
            // btnProcesso
            // 
            btnProcesso.FlatStyle = FlatStyle.Flat;
            btnProcesso.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProcesso.ImageAlign = ContentAlignment.MiddleLeft;
            btnProcesso.Location = new Point(-14, -8);
            btnProcesso.Name = "btnProcesso";
            btnProcesso.Size = new Size(381, 70);
            btnProcesso.TabIndex = 2;
            btnProcesso.Text = "          Processamento";
            btnProcesso.TextAlign = ContentAlignment.MiddleLeft;
            btnProcesso.UseVisualStyleBackColor = false;
            // 
            // timerProcessamento
            // 
            timerProcessamento.Interval = 10;
            timerProcessamento.Tick += timerProcessamento_Tick;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1712, 577);
            Controls.Add(panelChildForm);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmPrincipal";
            Text = "Sistema de Controle de Vendas";
            panelChildForm.ResumeLayout(false);
            sidebarContainer.ResumeLayout(false);
            containerProcesso.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer sidebarTime;
        private Panel panelChildForm;
        public FlowLayoutPanel sidebarContainer;
        private Panel containerProcesso;
        private Panel panelMenu;
        private Button btnProcesso;
        private Button btnCadastroItens;
        private System.Windows.Forms.Timer timerProcessamento;
    }
}
