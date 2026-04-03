using System;
using System.Windows.Forms;
using CometAPI;

namespace CometExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Functions.CurrentConfig.SetConfig("User/Agent", "Executor_Name", 3, true, ExecutionMethod.Communication);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Functions.Attach();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Functions.Execute(richTextBox1.Text);
        }
    }
}
