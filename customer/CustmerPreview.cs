using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace customer
{
    public partial class CustmerPreview : Form
    {
        public CustmerPreview()
        {
            InitializeComponent();
        }

        private void CustmerPreview_Load(object sender, EventArgs e)
        {

        }
        public void setValues(String CustmerName,String cuntry,String sex,String hobbies,String Status)
        {
            NameData.Text = CustmerName;
            CuntryData.Text = cuntry;
            sexData.Text = sex;
            HobbyData.Text = hobbies;
            StatusData.Text = Status;
        }
    }
}
