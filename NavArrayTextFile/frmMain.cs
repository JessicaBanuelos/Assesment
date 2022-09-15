namespace NavArrayTextFile
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRelease1_Click_1(object sender, EventArgs e)
        {
            frmRelease1 release1 = new frmRelease1();
            release1.Show();
             Visible = false;
        }

        private void btnRelease2_Click(object sender, EventArgs e)
        {
            frmRelease2 release2 = new frmRelease2();
            release2.Show();
            Visible = false;
        }

        private void btnRelease3_Click(object sender, EventArgs e)
        {
            frmRelease3 release3 = new frmRelease3();
            release3.Show();
            Visible = false;
        }
    }
}