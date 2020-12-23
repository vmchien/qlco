using QLCO.BLL;
using QLCO.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCO
{
    public partial class QuanLyHopDongVaKH : Form
    {
        TangBLL tbll = new TangBLL();
        public QuanLyHopDongVaKH()
        {
            InitializeComponent();
            this.Load += bntLoad_Click;
        }

        private void bntLoad_Click(object sender, EventArgs e)
        {
            Tang k = new Tang();
            k.MATANG = "Ms23";
            k.MACAOOC = "ssldj";
            k.SOPHONG = 5;
            tbll.Add(k);
        }
    }
}
