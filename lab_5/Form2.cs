using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace lab_5
{
    public partial class Form2 : Form
    {
        private void save_button_Click(object sender, EventArgs e)
        {

        }

        private void load_button_Click(object sender, EventArgs e)
        {

        }

        private void execute_button_Click(object sender, EventArgs e)
        {
           
        }

        private void b_opis_Click(object sender, EventArgs e)
        {
          
        }

        private void step_button_Click(object sender, EventArgs e)
        {
           
        }

        void read_code()
        {
            
        }


        public Form2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b_f1_Click(object sender, EventArgs e)
        {
            this.f_name.Text = "INT 17, 0";
            this.f_desc.Text = "Print Character";
            this.f_opis.Text = "[AH] = 0, Char in [AL]";
            //this.f_opis.Text = "Jakiś takiś bardzo długi opis, który po przeczytaniu nie będzie mieć większego sensu, jednakże niedługo odkryje się przed Tobą tajemnica, tak, tajemnica całej istoty tego przycisku i kiedy sobie ją uświadomisz, to będzie już za późno, bowiem właśnie zmarnowałeś 30 sekund swojego życia, na przeczytanie czegoś co nie ma treści merytorycznej, miłego dnia :P";;
        }

        private void b_f2_Click(object sender, EventArgs e)
        {
            this.f_name.Text = "INT 33, 3";
            this.f_desc.Text = "Get Mouse Position and Button Status";
            this.f_opis.Text = "[AH] = 3, [CX] = horizontal (X) position, [DX] = vertical (Y) position, [BX] = [_][_][_][_][_][_][X][X] -> 1 = pressed, bit0 = left button, bit1 = right button";
        }

        private void b_f3_Click(object sender, EventArgs e)
        {
            this.f_name.Text = "INT 21, 9";
            this.f_desc.Text = "Print String";
            this.f_opis.Text = "[AH] = 9, [DX] = pointer to string ending in $";
        }

        private void b_f4_Click(object sender, EventArgs e)
        {
            this.f_name.Text = "INT 21, 2A";
            this.f_desc.Text = "Get Date";
            this.f_opis.Text = "[AH] = 2A, [AL] = day of the week (0=Sunday), [CX] = year(1980 - 2099), [DH] = month(1 - 12), [DL] = day(1 - 31)";
        }

        private void b_f5_Click(object sender, EventArgs e)
        {
            this.f_name.Text = "INT 13, 10";
            this.f_desc.Text = "Disk Status";
            this.f_opis.Text = "[AH] = 10, 0 -> success, 1 -> error";
            //this.f_opis.Text = "[AH] = 3, [AL] = Status; (00)  no error, (01)  bad command passed to driver, (02) address mark not found or bad sector, (03)  diskette write protect error" 
            //    + "(04)  sector not found, (05)  fixed disk reset failed, (06)  diskette changed or removed, (07)  bad fixed disk parameter table, (08)  DMA overrun"
            //    + "(09)  DMA access across 64k boundary, (0A) bad fixed disk sector flag, (0B)  bad fixed disk cylinder, (0C) unsupported track / invalid media"
            //    + "(0D)  invalid number of sectors on fixed disk format, (0E)  fixed disk controlled data address mark detected, (0F)  fixed disk DMA arbitration level out of range"
            //    + "(10)  ECC / CRC error on disk read, (11)  recoverable fixed disk data error, data fixed by ECC, (20)  controller error(NEC for floppies), (40)  seek failure"
            //    + "(80)  time out, drive not ready, (AA)  fixed disk drive not ready, (BB)  fixed disk undefined error, (CC)  fixed disk write fault on selected drive"
            //    + "(E0)  fixed disk status error / Error reg = 0, (FF) sense operation failed";
        }

        private void b_f6_Click(object sender, EventArgs e)
        {
            this.f_name.Text = "INT 16, 0";
            this.f_desc.Text = "Wait for Keypress and Read Character";
            this.f_opis.Text = "[AH] = 0, Stops program until key is pressed";
        }
        private void b_f7_Click(object sender, EventArgs e)
        {
            this.f_name.Text = "INT 10, 11";
            this.f_desc.Text = "Changes color of the terminal";
            this.f_opis.Text = "[AH] = 11, [BH] = 0, [BL] = 0 -> Black, [BL] = 1 -> Blue, [BL] = 2 -> Green, [BL] = 3 -> Red, [BL] = 4 -> Purple, [BL] = 5 -> Brown, [BL] = 6 -> Yellow, [BL] = 7 -> White";
        }
        private void b_f8_Click(object sender, EventArgs e)
        {
            this.f_name.Text = "INT 1A, 1";
            this.f_desc.Text = "Set system clock counter";
            this.f_opis.Text = "[AH] = 1, [CX] = high order word of tick count, [DX] = low order word of tick count";
        }

        private void b_f9_Click(object sender, EventArgs e)
        {
            this.f_name.Text = "INT 1A, 2";
            this.f_desc.Text = "Read time from a real time clock";
            this.f_opis.Text = "[AH] = 2, [CH] = hours, [CL] = minutes, [DH] = seconds";
        }

        private void b_f10_Click(object sender, EventArgs e)
        {

        }

        private void f_opis_TextChanged(object sender, EventArgs e)
        {

        }

        private void f_name_Click(object sender, EventArgs e)
        {

        }

        private void f_desc_Click(object sender, EventArgs e)
        {

        }
    }
}
