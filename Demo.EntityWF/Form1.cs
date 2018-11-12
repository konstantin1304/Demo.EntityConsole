using Demo.Entities;
using Demo.EntityConsole;
using Demo.UnitOfWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.EntityWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource =
                Unit. DepartmentsRepository.AllItems.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Department item = (sender as ComboBox).SelectedItem as Department;
            listBox1.DataSource =
                Unit.TeachersRepository.AllItems.Where(x => x.Department.Id == item.Id).ToList();
        }
    }
}
