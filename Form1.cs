using System.Windows.Forms;

namespace AhoyMatey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // change the form label
            label1.Text = "Ahoy, Matey";

            /**********************************
             * output some information to the console
             * useful for debugging 
             *********************************/
            System.Diagnostics.Debug.WriteLine("Hello World");

        }
    }
}
