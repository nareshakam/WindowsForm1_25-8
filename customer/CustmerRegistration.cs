using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace customer
{
    public partial class CustmerRegistration : Form
    {
        public CustmerRegistration()
        {
            InitializeComponent();
        }

        private void PreviewBtn_Click(object sender, EventArgs e)
        {
            String sex = "";
            String hobbies = "";
            String Status = "";
            if(radioMarried.Checked)
            {
                Status = "Married";
            }
            else
            {
                Status = "UnMarried";
            }
            if(checkPainting.Checked||checkReading.Checked)
            {
                hobbies = "reading,Painting";
            }
            else if(checkPainting.Checked)
            {
                hobbies = "Painting";
            }
            else
            {
                hobbies = "Reading";
            }
            if(radioMale.Checked)
            {
                sex = "Male";
            }
            else
            {
                sex = "Female";
            }
            String cuntry = "";//own Adding to Handile the Exception start 1
            if(cmbCuntry.SelectedValue==null)
            {
                cuntry = cmbCuntry.Text;
            }
            else
            {
                cuntry =cmbCuntry.SelectedValue.ToString();
            }//end 1
            CustmerPreview cp = new CustmerPreview();
            cp.setValues(txtName.Text, cuntry, sex,hobbies,Status);
            cp.ShowDialog();
        }
    }
}
