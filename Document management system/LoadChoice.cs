namespace Document_management_system
{
    public partial class LoadChoice : Form
    {
        public LoadChoice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StuLoad stuLoad = new StuLoad();
            stuLoad.Show();
        }

        private void teacher_Click(object sender, EventArgs e)
        {
            TeaLoad teacherLoad = new TeaLoad();
            teacherLoad.Show();
        }
    }
}
