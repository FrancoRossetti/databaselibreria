using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCRUDAPP
{
    public partial class Form1 : Form
    {
        //Customer model = new Customer();
        public Form1()
        {
            InitializeComponent();
            cmb_TipoDoc_Aut.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_TipoDoc_Lec.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_Codigo_Libro.Enabled = false;
            txt_Cod_Empleado.Enabled = false;
        }

        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    Clear();
        //}

        //void Clear()
        //{
        //    txtFirstname.Text = txtLastName.Text = txtCity.Text = txtAddress.Text = "";
        //    btnSave.Text = "Save";
        //    btnDelete.Enabled = false;
        //    model.CustomerID = 0;
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            //Clear();
            //PopulateDataGridView();
        }


        //--------------------------------------------- SOLO NUMEROS EN TEXTBOX---------------------------------------------//
        private void Txt_Cod_Postal_Aut_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }
        private void Txt_NroDoc_Lec_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }
        private void Txt_CodPostal_Lec_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }
        private void TxtNroDoc_Aut_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }
        private void Txt_NroDoc_Empl_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }
        private void Txt_Cant_Pag_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }



        //void PopulateDataGridView()
        //{
        //    dgvCustomer.AutoGenerateColumns = false;
        //    using (DBEntities db = new DBEntities())
        //    {
        //        dgvCustomer.DataSource = db.Customers.ToList<Customer>();

        //    }
        //}
    }
}
