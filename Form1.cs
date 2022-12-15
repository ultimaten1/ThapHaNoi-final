using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThapHaNoifinal
{
    public partial class formTHNf : Form
    {
        public formTHNf()
        {
            InitializeComponent();
        }
        bool bStop = true;
        int sodia;
        int sobuoc = 0;
        Label[] Dia;
        Label[] Kiemtra = new Label[3];
        
        Stack<Label> cocN = new Stack<Label>();
        Stack<Label> cocTG = new Stack<Label>();
        Stack<Label> cocD = new Stack<Label>();
       
        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics Gr = e.Graphics;
            Pen pe = new Pen(Color.Brown);
            // Vẽ Cọc 1
            Point p1 = new Point(200, 400);
            Point p2 = new Point(200, 100);
            Gr.DrawLine(pe, p1, p2);
            p1.X = 100; p1.Y = 400;
            p2.X = 300; p2.Y = 400;
            Gr.DrawLine(pe, p1, p2);
            //Vẽ Cọc 2
            p1.X = 500; p1.Y = 400;
            p2.X = 500; p2.Y = 100;
            Gr.DrawLine(pe, p1, p2);
            p1.X = 400; p1.Y = 400;
            p2.X = 600; p2.Y = 400;
            Gr.DrawLine(pe, p1, p2);
            //Vẽ Cọc 3
            p1.X = 800; p1.Y = 400;
            p2.X = 800; p2.Y = 100;
            Gr.DrawLine(pe, p1, p2);
            p1.X = 700; p1.Y = 400;
            p2.X = 900; p2.Y = 400;
            Gr.DrawLine(pe, p1, p2);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGiailai.Enabled = false;
            Random random = new Random();
            cocN.Clear(); cocTG.Clear(); cocD.Clear();
            this.Controls.Clear(); //xóa các đĩa cũ
            
            // add lại
            this.Controls.Add(lblCocNguon);
            this.Controls.Add(lblCocTrungGian);
            this.Controls.Add(lblCocDich);
            this.Controls.Add(lblChonsodia);
            this.Controls.Add(btnGiai);
            this.Controls.Add(cboSodia);
            this.Controls.Add(btnGiailai);
            this.Controls.Add(txtLoigiai);
            this.Controls.Add(lblLoigiai);
            this.Controls.Add(lblSobuoc);
            lblSobuoc.Text = "Số bước: 0";
            sodia = int.Parse(cboSodia.SelectedItem.ToString());
           
            // Gán thuộc tính cho label kiểm tra
            for (int i = 0; i < 2; i++)
            {
                Kiemtra[i] = new Label();
                Kiemtra[i].Height = 20; Kiemtra[i].Width= 20; Kiemtra[i].Left = 1880; Kiemtra[i].Top = 680;
                Kiemtra[i].BackColor = Color.White;
                Kiemtra[i].Text = i.ToString();
            }
            cocN.Push(Kiemtra[0]); cocTG.Push(Kiemtra[1]); cocD.Push(Kiemtra[2]);

            // thêm đĩa
            Dia = new Label[sodia];
            for (int i = 0; i< sodia; i++)
            {
                Dia[i] = new Label();
                // Gán thuộc tính cho label đĩa
                Dia[i].Height = 20;
                Dia[i].BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                if (i == 0)
                {
                    Dia[i].Width = 100;
                    Dia[i].Left = 150;
                    Dia[i].Top = 400 - 20 * sodia;
                }
                else
                {
                    Dia[i].Width = Dia[i - 1].Width + 40;
                    Dia[i].Left = Dia[i - 1].Left - 20;
                    Dia[i].Top = Dia[i - 1].Top + 20;
                }
                this.Controls.Add(Dia[i]);
            }
            for (int i = sodia - 1; i >= 0; i--)
                cocN.Push(Dia[i]);            
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            txtLoigiai.Text = "";
            if (btnGiai.Text == "Giải")
            {
                if (btnGiailai.Enabled)
                {
                    MessageBox.Show("Vui lòng chọn số đĩa !!", "ERROR");
                    return;
                }
                btnGiailai.Enabled = true;
                btnGiai.Text = "Dừng";
                sobuoc = 0;
                bStop = false;
                ChuyenDia(sodia, cocN, cocTG, cocD);
                LoiGiaiChuyenDia(sodia, "Cọc Nguồn", "Cọc Trung Gian", "Cọc Đích");
                btnGiai.Text = "Giải";
                bStop = true;
            }
            else
            {
                btnGiai.Text = "Giải";
                bStop = true;
            }
        }
        // Lời giải chuyển đĩa
        public void LoiGiaiChuyenDia(int SoDia, string CocNguon, string CocTG, string CocDich)
        {
            if (SoDia == 1)
            {
                txtLoigiai.Text = txtLoigiai.Text + "\n" + CocNguon + " ---------> " + CocDich + "\r\n";
            }
            else
            {
                LoiGiaiChuyenDia(SoDia - 1, CocNguon, CocDich, CocTG);
                LoiGiaiChuyenDia(1, CocNguon, CocTG, CocDich);
                LoiGiaiChuyenDia(SoDia - 1, CocTG, CocNguon, CocDich);
            }
        }

        private void formTHNf_Load(object sender, EventArgs e)
        {
            // Add item số đĩa cho combobox
            cboSodia.Items.Clear();
            for (int i = 1; i <= 8; i++)
                cboSodia.Items.Add(i);
        }
        private void btnGiailai_Click(object sender, EventArgs e)
        {
            // Gọi lại events của combobox
            comboBox1_SelectedIndexChanged(sender, e);
        }
        private void HieuUng(Stack<Label> cocnguon, Stack<Label> cocdich)
        {
            
            lblSobuoc.Text = "Số bước: " + sobuoc.ToString();
            Label lblDia = Dia[0];
            int speed = 1; // Tốc độ di chuyển đĩa
            // Tìm đĩa cần chuyển (đĩa đầu ở cocnguon)
            for (int i = 0; i < sodia; i++)
                if (cocnguon.Contains(Dia[i]) == true)
                {
                    lblDia = Dia[i];
                    break;
                }

            // Tính số đĩa đã có ở cột đích
            int demDich =  cocdich.Count - 1;

            // Nâng đĩa lên trên
            while (lblDia.Top > 100)
            {
                lblDia.Top -= speed;
                Application.DoEvents();
            }

            // Dịch trái phải
            int vitrimoi = cocdich.Contains(Kiemtra[0]) == true ? 200 : cocdich.Contains(Kiemtra[1]) == true ? 500 : 800;
            if (lblDia.Left + lblDia.Width / 2 < vitrimoi)
            {
                while (lblDia.Left + lblDia.Width / 2 < vitrimoi)
                {
                    lblDia.Left += speed;
                    Application.DoEvents();
                }
            }
            else if (lblDia.Left + lblDia.Width / 2 > vitrimoi)
            {
                while (lblDia.Left + lblDia.Width / 2 > vitrimoi)
                {
                    lblDia.Left -= speed;
                    Application.DoEvents();
                }
            }
            // Đặt đĩa xuống
            while (lblDia.Top < 380 - demDich * 20)
            {
                lblDia.Top += speed;
                Application.DoEvents();
            }
            cocdich.Push(cocnguon.Pop());
        }
        // Giải thuật
        public void ChuyenDia (int soDia, Stack<Label> cocnguon, Stack<Label> coctrunggian, Stack<Label> cocdich)
        {
            if (soDia > 0)
            {                
                ChuyenDia(soDia - 1, cocnguon, cocdich, coctrunggian);
                
                sobuoc++;
                if (bStop) return; // dung lai neu stop
                HieuUng(cocnguon, cocdich);
                ChuyenDia(soDia - 1, coctrunggian, cocnguon, cocdich);
                
                if (bStop) return;
            }
        }
    }
}
