namespace assingment4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAnimal addAnimal = new AddAnimal();
            addAnimal.ShowDialog(this);
        }

        private void viewSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSystem viewSystem = new ViewSystem();
            viewSystem.MdiParent = this;
            viewSystem.Show();
        }
    }
}
