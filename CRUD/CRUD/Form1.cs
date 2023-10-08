using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.Models;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Refrescar();

        }

        #region
            private void Refrescar()
        {
            using (CrudEntities db = new CrudEntities())
            {
                var lst = from d in db.Empleado
                          select d;
                Tabledb.DataSource = lst.ToList();
            }
        }
        #endregion
    }
}
