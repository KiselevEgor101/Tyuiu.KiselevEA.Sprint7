namespace Tyuiu.KiselevEA.Sprint7.Project.V9
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            
        }

        private void buttonClose_KEA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAbout_KEA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.TopMost = true;
            formAbout.ShowDialog();
        }

        private void buttonStart_KEA_Click(object sender, EventArgs e)
        {            
            FormGeneral formGeneral = new FormGeneral();
            formGeneral.TopMost = true;
            formGeneral.ShowDialog();
            this.Hide();            
        }

        private void buttonGuide_KEA_Click(object sender, EventArgs e)
        {
            FormGuides formGuides = new FormGuides();
            formGuides.TopMost = true;
            formGuides.ShowDialog();
        }

        private void buttonStart_KEA_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
