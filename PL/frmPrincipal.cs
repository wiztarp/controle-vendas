namespace ControleVendas
{
    public partial class frmPrincipal : Form
    {
        public string User;
        bool sidebarExpand;
        bool processamentoColapsed;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sidebarTime_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTime.Stop();
                    foreach (Form frm in this.MdiChildren)
                    {
                        frm.Size = new Size(this.ClientSize.Width - 84 - 10, this.ClientSize.Height - 10);
                    }
                }
            }
            else
            {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width == sidebarContainer.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTime.Stop();
                    foreach (Form frm in this.MdiChildren)
                    {
                        frm.Size = new Size(this.ClientSize.Width - 350 - 10, this.ClientSize.Height - 10);
                    }
                }
            }
        }

        private void timerProcessamento_Tick(object sender, EventArgs e)
        {
            if (processamentoColapsed)
            {
                containerProcesso.Width -= 10;
                if (containerProcesso.Width == containerProcesso.MinimumSize.Width)
                {
                    processamentoColapsed = false;
                    timerProcessamento.Stop();
                }
            }
            else
            {
                containerProcesso.Width += 10;
                if (containerProcesso.Width == containerProcesso.MaximumSize.Width)
                {
                    processamentoColapsed = true;
                    timerProcessamento.Stop();
                }
            }
        }
    }
}
