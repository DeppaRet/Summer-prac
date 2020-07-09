using System;
using System.Windows.Forms;

namespace WorkInProgress
{
  public partial class MainWindow : Form
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void Close_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void About_Click(object sender, EventArgs e)
    {
      About about = new About();
      about.Show();
    }

    private void Run_Click(object sender, EventArgs e)
    {
      try
      {

      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }



    /* private void Time_Scroll(object sender, EventArgs e)
     {
       CurrentTime.Text = Time.Value.ToString();
     }*/
  }
}
