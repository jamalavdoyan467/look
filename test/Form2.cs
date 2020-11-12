using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.Список_клиентов". При необходимости она может быть перемещена или удалена.
            this.список_клиентовTableAdapter.Fill(this.baseDataSet.Список_клиентов);

        }
    }
}
