using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private HospitalEntities db= new HospitalEntities();    
        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txttc.Text);
                String pass = txtpass.Text;
                int ? switchoperation = db.loginbaglanti(id, pass).FirstOrDefault();  

                switch (switchoperation)
                {
                    case 1://admin
                        AdminPanel adminPanel = new AdminPanel();
                        this.Hide();
                        adminPanel.ShowDialog();
                        break;
                    case 2://doktor
                        DoctorPanel doctorPanel = new DoctorPanel();
                        this.Hide();
                        doctorPanel.ShowDialog();
                        break;
                    case 3://personel
                       // PersonelPanel personelPanel = new PersonelPanel();
                        //this.Hide();
                       // personelPanel.ShowDialog();
                        break;
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
           

        }
    }
}
