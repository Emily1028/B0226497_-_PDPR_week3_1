using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B0226497_段昱如_PDPR_week3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblresult_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string[,] SData = new string[5, 3];
            int[,] SDegree = new int[5, 3];
            double[,] Saver = new double[5, 1];
            SData[0, 0] = "B0226497_1";
            SData[0, 1] = "段昱如_1";
            SData[0, 2] = "000001";
            SData[1, 0] = "B0226497_2";
            SData[1, 1] = "段昱如_2";
            SData[1, 2] = "000002";
            SData[2, 0] = "B0226497_3";
            SData[2, 1] = "段昱如_3";
            SData[2, 2] = "000003";
            SData[3, 0] = "B0226497_4";
            SData[3, 1] = "段昱如_4";
            SData[3, 2] = "000004";
            SData[4, 0] = "B0226497_5";
            SData[4, 1] = "段昱如_5";
            SData[4, 2] = "000005";
            SDegree[0, 0] = 61;
            SDegree[0, 1] = 72;
            SDegree[0, 2] = 78;
            SDegree[1, 0] = 97;
            SDegree[1, 1] = 64;
            SDegree[1, 2] = 79;
            SDegree[2, 0] = 57;
            SDegree[2, 1] = 68;
            SDegree[2, 2] = 87;
            SDegree[3, 0] = 76;
            SDegree[3, 1] = 87;
            SDegree[3, 2] = 78;
            SDegree[4, 0] = 67;
            SDegree[4, 1] = 68;
            SDegree[4, 2] = 67;
            Saver[0, 0] = (SDegree[0, 0] + SDegree[0, 1] + SDegree[0, 2]) / 3;
            Saver[1, 0] = (SDegree[1, 0] + SDegree[1, 1] + SDegree[1, 2]) / 3;
            Saver[2, 0] = (SDegree[2, 0] + SDegree[2, 1] + SDegree[2, 2]) / 3;
            Saver[3, 0] = (SDegree[3, 0] + SDegree[3, 1] + SDegree[3, 2]) / 3;
            Saver[4, 0] = (SDegree[4, 0] + SDegree[4, 1] + SDegree[4, 2]) / 3;
            string str = "學生各項資料:";
            str += $"\n學號:{SData[0, 0]},姓名:{SData[0, 1]},電話:{SData[0, 2]},國文:{SDegree[0, 0]},數學:{SDegree[0, 1]},英文:{SDegree[0, 2]},平均:{Saver[0, 0]}";
            str += $"\n學號:{SData[1, 0]},姓名:{SData[1, 1]},電話:{SData[1, 2]},國文:{SDegree[1, 0]},數學:{SDegree[1, 1]},英文:{SDegree[1, 2]},平均:{Saver[1, 0]}";
            str += $"\n學號:{SData[2, 0]},姓名:{SData[2, 1]},電話:{SData[2, 2]},國文:{SDegree[2, 0]},數學:{SDegree[2, 1]},英文:{SDegree[2, 2]},平均:{Saver[2, 0]}";
            str += $"\n學號:{SData[3, 0]},姓名:{SData[3, 1]},電話:{SData[3, 2]},國文:{SDegree[3, 0]},數學:{SDegree[3, 1]},英文:{SDegree[3, 2]},平均:{Saver[3, 0]}";
            str += $"\n學號:{SData[4, 0]},姓名:{SData[4, 1]},電話:{SData[4, 2]},國文:{SDegree[4, 0]},數學:{SDegree[4, 1]},英文:{SDegree[4, 2]},平均:{Saver[4, 0]}";
            lblresult.Text = str;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
