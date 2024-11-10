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
        int num1 = 10;

        public void SignUp(string username, string password)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("UserCredentials.txt", true))
                {
                    writer.WriteLine($"{username},{password}");
                }

                MessageBox.Show("Signed up successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception err)
            {

                MessageBox.Show($"Error occured: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SignIn(string username, string password)
        {
            try
            {
                if (Validate(username,password))
                {
                    MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {

                MessageBox.Show($"Error occured: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool Validate(string username, string password)
        {
            if (!File.Exists("UserCredentials.txt"))
            {
                MessageBox.Show("User not found. Please sign up first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            string[] data = File.ReadAllLines("UserCredentials.txt");
            foreach (string line in data)
            {
                var credentials = line.Split(',');
                if (credentials[0] == username && credentials[1] == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
