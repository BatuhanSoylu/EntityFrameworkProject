using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PeopleDal _people=new PeopleDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPeople();
        }

        private void LoadPeople()
        {
            dgwPersonal.DataSource = _people.GetAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _people.Save(new People
            {
                FirsName=txtFirstName.Text,
                LastName=txtLastName.Text,
                City=txtCity.Text,
                Address=txtAddress.Text,
            });
            LoadPeople();
            MessageBox.Show("People is added.");
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _people.Delete(new People
            {
                Id = Convert.ToInt32(dgwPersonal.CurrentRow.Cells[0].Value)
            }) ;
            LoadPeople();
            MessageBox.Show("Delete");
        }


    }
}
