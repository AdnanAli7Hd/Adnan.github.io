using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  
    public partial class Form1 : Form
    {
        public void FF() {
            QTy = Convert.ToInt32(textBox6.Text);
            if (Name_of_wagbah == "برست") { PRICE = 1000; }
            if (Name_of_wagbah == "شاورما") { PRICE = 250; }
            if (Name_of_wagbah == "لحم") { PRICE = 2000; }
            DATAGRI.Rows.Add(Name_of_wagbah, QTy, PRICE, (QTy * PRICE));
            textBox6.Text = "";
        }
        public string Name_of_wagbah; //متغير اسم الوجبة
        public int PRICE;                  //متغير سعر الوجبة
        public int QTy; //متغير كمية الوجبة في التيكست بوكس
        public int  sum;
        public  int su1 =0, su2 =0, su3 =0 ;  

        public string NAME;
        public int QTY,Price;
        public int II = 0;
        public int II1 = 0;
        public decimal Valuee;
        //public int mdtota;
        
        public Form1()
        {
            InitializeComponent();
           
            textBox6.Visible = false;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tocli(object sender, EventArgs e)
        {
            //string a = button2.Text;
            //DATAGRI.Rows.Add(a);
            //Button bb = new Button();
            //string nametxt = bb.Text;
            //DATAGRI.Rows.Add(nametxt);

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            //DATAGRI.Rows.Add(bt1.Text);

        }

        private void bt2_Click(object sender, EventArgs e)
        {
            //DATAGRI.Rows.Add(bt2.Text);
        }

        private void TOCLI(object a, EventArgs e)
        {
           
            //Button aa = (Button)a;
            //QTY = aa.Text;
            //Button BB = (Button)sender;
            //DATAGRI.Rows.Add(BB.Text);
        }

        private void totalclicks(object sender, EventArgs e)

        {
        
        
            Button BB = (Button)sender;
            NAME = BB.Text;
          
            if (NAME == "بروست")
            {
                QTY = Convert.ToInt32(textBox1.Text);

                Price = 1000;
                DATAGRI.Rows.Add(NAME, QTY, Price, (QTY * Price));
                //QTY = Convert.ToInt32(textBox1.Text);
                //QTY = 1;
                II += (QTY * Price);
            }
            else
            //    if (NAME == "شاورما")
            {
                 QTY = Convert.ToInt32(textBox2.Text);
               
               
                Price = 500;
                DATAGRI.Rows.Add(NAME, QTY, Price, (QTY * Price));
                II1 += (QTY * Price);
                
            }
          
           
       
                //object[] data = { 
           
        //};


              
          
     
        }

        private void buttTOT_Click(object sender, EventArgs e)
        {
            sum = su1 + su2 + su3;
            MessageBox.Show(sum.ToString());
        }

        private void DATAGRI_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DATAGRI.Rows.Clear();
        }

        private void DATAGRI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DATAGRI_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void DATAGRI_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //كوداسقاط الداتا قريديفيو في التجهيز لعمليات الطباعة
            Bitmap BMab = new Bitmap(this.DATAGRI.Width, this.DATAGRI.Height);
            DATAGRI.DrawToBitmap(BMab, new Rectangle(0, 0, this.DATAGRI.Width, this.DATAGRI.Height));
            e.Graphics.DrawImage(BMab, 100, 100);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int AD = 0; AD <= 3; AD++) {
                DATAGRI.CurrentRow.Cells[AD].Value = "";
            }

           
           
        }

        private void Vchang(object sender, EventArgs e)
        {
            NumericUpDown NN = (NumericUpDown)sender;
            Valuee =
            NN.Value;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Valuee.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        { 
            //كود معاينة الفاتورة
            printPreviewDialog1.ShowDialog();
            //pageSetupDialog1.ShowDialog();
        }
        //حدث buttunclick لثلاثة بوتونات
        private void ToCl3(object sender, EventArgs e)
        {
            Button BT3 = (Button)sender;
            Name_of_wagbah = BT3.Text;
            int x = 2;
            x--;
                if (textBox6.Text != ""&&x==1)
                {

                    FF();
                    su1 += (QTy * PRICE);
                  
                }
                else if (textBox6.Text != "" && x != 1)
                {     QTy = Convert.ToInt32(textBox6.Text);
                    if (Name_of_wagbah == "برست") { PRICE = 1000; }
                    if (Name_of_wagbah == "شاورما") { PRICE = 250; }
                    if (Name_of_wagbah == "لحم") { PRICE = 2000; }
                    DATAGRI.Rows.Add(Name_of_wagbah, QTy, PRICE, (QTy * PRICE));
                    textBox6.Text = "";
                    su2 += (QTy * PRICE);
                 
                }
                else  
                {    QTy = 1;
                    if (Name_of_wagbah == "برست") { PRICE = 1000; }
                    if (Name_of_wagbah == "شاورما") { PRICE = 250; }
                    if (Name_of_wagbah == "لحم") { PRICE = 2000; }
                    DATAGRI.Rows.Add(Name_of_wagbah, QTy, PRICE, (QTy * PRICE));
                    su3 += (QTy * PRICE);
                 
                }
            
  
         
            //    textBox6.Text = "";
            //    QTy = Convert.ToInt32(textBox6.Text);
            //if (Name_of_wagbah == "برست") { PRICE = 1000; }
            //if (Name_of_wagbah == "شاورما") { PRICE = 250; }
            //if (Name_of_wagbah == "لحم") { PRICE = 2000; }
            //DATAGRI.Rows.Add(Name_of_wagbah, QTy, PRICE, (QTy * PRICE));
        
            
        
        }

        private void txttot3(object sender1, EventArgs e)
        {
      
        }

        private void button11_Click(object sender, EventArgs e)
        {
         
        }
        //حدث MouseLeave لثلاثة تيكستبوكسات
        private void tl3(object sender11, EventArgs e)
        {
         
        }

        private void textBox6_MouseLeave(object sender, EventArgs e)
        {
            //if (textBox6.Text != "") {  }
           
           
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            textBox6.Location=new Point(560,382);
            textBox6.Visible = true;

        }

        private void groupBox1_Leave(object sender, EventArgs e)
        {
         
        }

        private void groupBox2_MouseHover(object sender, EventArgs e)
        {
            textBox6.Location = new Point(180, 314);
            textBox6.Visible = true;
           
        }

        private void groupBox2_Leave(object sender, EventArgs e)
        {
        
        }
    }
}
