using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PRG272_Project.data_layer
{
    internal class Datahandler
    {
        public void SignUp(string username, string password)
        {
			try
			{
				using (StreamWriter writer = new StreamWriter("UserCredentials.txt",true))
				{
					writer.WriteLine($"{username},{password}");
				}

				MessageBox.Show("Signed up successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception err)
			{

				MessageBox.Show($"Error has occured: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }
    }
}
