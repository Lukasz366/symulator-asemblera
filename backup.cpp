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
using System.Windows.Input;
using System.Drawing;

namespace lab_5
{
    public partial class Form1 : Form
    {
        private byte CF;

        private byte AL, BL, CL, DL;
        private byte AH, BH, CH, DH;
        public DateTime startDate = new DateTime(1980, 1, 1);
        public DateTime current_date;
        public byte current_month;
        public ushort current_year;
        public byte day_of_week;
        public byte current_day;

        public Point mouse_position;
        

        public ushort AX
        {
            get
            {
                return (ushort)((AH << 8) | AL);
            }
            set
            {
                AH = (byte)(value >> 8);
                AL = (byte)(value & 0xFF);
            }
        }
        public ushort BX
        {
            get
            {
                return (ushort)((BH << 8) | BL);
            }
            set
            {
                BH = (byte)(value >> 8);
                BL = (byte)(value & 0xFF);
            }
        }

        public ushort CX
        {
            get
            {
                return (ushort)((CH << 8) | CL);
            }
            set
            {
                CH = (byte)(value >> 8);
                CL = (byte)(value & 0xFF);
            }
        }

        public ushort DX
        {
            get
            {
                return (ushort)((DH << 8) | DL);
            }
            set
            {
                DH = (byte)(value >> 8);
                DL = (byte)(value & 0xFF);
            }
        }

        private string str = "222";
        private string line;
        private string first_word;
        private string second_word;
        private string third_word;
        private int line_number = 0;
        private int line_count = 0;
        private string file_path = "code.txt";

        private void save_button_Click(object sender, EventArgs e)
        {
            string textToSave = code_textbox.Text;
            
            File.WriteAllText(file_path, textToSave);
            MessageBox.Show("Text saved to file successfully.");
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            code_textbox.Text = File.ReadAllText(file_path);
        }

        private void execute_button_Click(object sender, EventArgs e)
        {
            AX = 0;
            BX = 0;
            CX = 0;
            DX = 0;
            CF = 0;
            line_number = 0;
            line_count = code_textbox.Lines.Length;
            //MessageBox.Show((line_count.ToString()));

            for (int i = 0; i<line_count;i++)
            {
                read_code();
            }
        }

        private void b_opis_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void step_button_Click(object sender, EventArgs e)
        {
            read_code();
            step_number_label.Text=line_number.ToString();
        }

        void read_code()
        {
            line = code_textbox.Lines[line_number];
            line=line.ToUpper();
            //label_AX.Text = line;
            string[] words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            string first_word = words[0];
            string second_word = string.Empty;
            string third_word = string.Empty;

            if (words[1].EndsWith(","))
            {
                second_word = words[1].TrimEnd(',');
                third_word = words[2];
            }
            else if (words[1].EndsWith(",") && words[2].StartsWith(","))
            {
                second_word = words[1].TrimEnd(',');
                third_word = words[2].TrimStart(',');
            }
            else if (words.Length >= 4 && words[2].StartsWith(","))
            {
                second_word = words[1];
                third_word = words[3];
            }
            else if (words.Length >= 4 && words[2] == ",")
            {
                second_word = words[1];
                third_word = words[3];
            }
            else if (words.Length == 2)
            {
                second_word = words[1];
            }


            label_AX.Text = first_word;
            label_BX.Text = second_word;
            label_CX.Text = third_word;



            if (first_word=="ADD" || first_word == "SUB" || first_word == "MOV")
            {
                if (second_word == "AX")
                {
                    AX = Wynik(first_word, second_word, third_word);
                }
                else if (second_word == "BX")
                {
                    BX = Wynik(first_word, second_word, third_word);
                }
                else if (second_word == "CX")
                {
                    CX = Wynik(first_word, second_word, third_word);
                }
                else if (second_word == "DX")
                {
                    DX = Wynik(first_word, second_word, third_word);
                }
                else if (second_word == "AH")
                {
                    AH = (byte)(Wynik(first_word, second_word, third_word));
                }
                else if (second_word == "BH")
                {
                    BH = (byte)(Wynik(first_word, second_word, third_word));
                }
                else if (second_word == "CH")
                {
                    CH = (byte)(Wynik(first_word, second_word, third_word));
                }
                else if (second_word == "DH")
                {
                    DH = (byte)(Wynik(first_word, second_word, third_word));
                }
                else if (second_word == "AL")
                {
                    AL = (byte)(Wynik(first_word, second_word, third_word));
                }
                else if (second_word == "BL")
                {
                    BL = (byte)(Wynik(first_word, second_word, third_word));
                }
                else if (second_word == "CL")
                {
                    CL = (byte)(Wynik(first_word, second_word, third_word));
                }
                else if (second_word == "DL")
                {
                    DL = (byte)(Wynik(first_word, second_word, third_word));
                }
            }
            else if(first_word=="INT")
            {
                //MessageBox.Show((second_word.ToString()));

                if (second_word == "21H" && AH == 42)
                {
                    //MessageBox.Show((line_count.ToString()));

                    int_2Ah();
                }
                else if (second_word == "33H" && AX == 3)
                {
                    //MessageBox.Show((line_count.ToString()));

                    int_33h();
                }
                else if (second_word == "09H" && AH == 9)
                {
                    //MessageBox.Show((line_count.ToString()));

                    int_09h();
                }
                else if (second_word == "17H" && AH == 0)
                {
                    //MessageBox.Show((line_count.ToString()));

                    int_17h();
                }
                else if (second_word == "13H" && AH == 10)
                {
                    //MessageBox.Show((line_count.ToString()));

                    int_13h();
                }
                else if (second_word == "16H" && AH == 0)
                {
                    //MessageBox.Show((line_count.ToString()));

                    int_16h();
                }
                else if ((second_word == "10H" && AH == 11 && BH == 0))
                {
                    int_10b();
                    //MessageBox.Show((line_count.ToString()));
                }
                else if ((second_word == "13H" && AH == 16))
                {
                    int_1310();
                    //MessageBox.Show((line_count.ToString()));
                }

            }


            label_AX.Text = AX.ToString();
            label_BX.Text = BX.ToString();
            label_CX.Text = CX.ToString();
            label_DX.Text = DX.ToString();
            label_CF.Text = CF.ToString();

            line_number++;
        }

        void int_2Ah() //data  CX = year (1980-2099). DH = month. DL = day. AL = day of week (00h=Sunday)
        {
            current_date = DateTime.Now;
            current_year = (ushort)current_date.Year;
            current_month = (byte)current_date.Month;
            current_day = (byte)current_date.Day;
            day_of_week = (byte)current_date.DayOfWeek;

            CX = current_year;
            DH = current_month;
            DL = current_day;
            AL = day_of_week;
        }

        void int_33h()
        {
            if (((Control.MouseButtons & MouseButtons.Left) == MouseButtons.Left) && ((Control.MouseButtons & MouseButtons.Right) == MouseButtons.Right))
            {
                BX = 3;
            }
            else if ((Control.MouseButtons & MouseButtons.Left) == MouseButtons.Left)
            {
                //MessageBox.Show((line_count.ToString()));
                BX = 1;
            }
            else if ((Control.MouseButtons & MouseButtons.Right) == MouseButtons.Right)
            {
                BX = 2;
            }
            else
            {
                BX = 0;
            }
            mouse_position = Cursor.Position;
            CX = (ushort)mouse_position.X;
            DX = (ushort)mouse_position.Y;
        }

        private void terminal_TextChanged(object sender, EventArgs e)
        {

        }

        // czy na pewno to nie 17?
        void int_09h()
        {
            terminal.Text += (char)AL;
        }

        void int_17h()
        {
            terminal.Text += (char)AL;
        }

        void int_13h()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            //foreach (DriveInfo d in allDrives)
            //{
            //    Console.WriteLine("Drive {0}", d.Name);
            //    Console.WriteLine("  Drive type: {0}", d.DriveType);
 
            //    terminal.Text = d.IsReady.ToString();
            //}
            terminal.Text += allDrives[0].Name + "    Status:   ";
            if(allDrives[0].IsReady.ToString() == "True")
            {
                terminal.Text += "0";
            }
            else
            {
                terminal.Text += "1";
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // terminal.Text = e.KeyCode.ToString();
            if (block == true)
            {
                if (e.KeyCode == Keys.K)
                {
                    this.code_textbox.Enabled = true;
                    this.save_button.Enabled = true;
                    this.load_button.Enabled = true;
                    terminal.Enabled = true;
                    this.execute_button.Enabled = true;
                    this.step_button.Enabled = true;
                    this.b_opis.Enabled = true;

                    block = false;
                    terminal.Text = "";

                }
            }
            
            //terminal.Text = "sss";
            //if (e.KeyCode == Keys.Space)
            //{
            //    terminal.Text = "Guddo";

            //}
        }

        private void code_textbox_TextChanged(object sender, EventArgs e)
        {

        }


        void int_16h()
        {
            terminal.Text += "Press K";

            this.code_textbox.Enabled = false;
            this.save_button.Enabled = false;
            this.load_button.Enabled = false;
            terminal.Enabled = false;
            this.execute_button.Enabled = false;
            this.step_button.Enabled = false;
            this.b_opis.Enabled = false;
            block = true;
        }
        void int_02h()
        {
            // Subskrypcja zdarzenia KeyPress

        }

        void int_10b()
        {
            if(BL==0)
            {
                terminal.BackColor = Color.Black;
            }
            else if(BL==1)
            {
                terminal.BackColor = Color.Blue;
            }
            else if (BL == 2)
            {
                terminal.BackColor = Color.Green;
            }
            else if (BL == 3)
            {
                terminal.BackColor = Color.Cyan;
            }
            else if (BL == 4)
            {
                terminal.BackColor = Color.Red;
            }
            else if (BL == 5)
            {
                terminal.BackColor = Color.Purple;
            }
            else if (BL == 6)
            {
                terminal.BackColor = Color.Brown;
            }
            else if (BL == 7)
            {
                terminal.BackColor = Color.LightGray;
            }
            else if (BL == 8)
            {
                terminal.BackColor = Color.DarkGray;
            }
            else if (BL == 9)
            {
                terminal.BackColor = Color.LightBlue;
            }
            else if (BL == 10)
            {
                terminal.BackColor = Color.LightGreen;
            }
            else if (BL == 11)
            {
                terminal.BackColor = Color.LightCyan;
            }
            else if (BL == 12)
            {
                terminal.BackColor = Color.Red;
            }
            else if (BL == 13)
            {
                terminal.BackColor = Color.MediumPurple;
            }
            else if (BL == 14)
            {
                terminal.BackColor = Color.Yellow;
            }
            else if (BL == 15)
            {
                terminal.BackColor = Color.White;
            }
        }

        /*
        void int_1310()
        {
            if (BL == 0)
            {
                DriveInfo drive = new DriveInfo("A");

                if (drive.IsReady)
                {
                    //MessageBox.Show((line_count.ToString()));
                    //CF = 0;
                }
                else { CF = 1; }
            }
            else if (BL == 1)
            {
                DriveInfo drive = new DriveInfo("B");

                if (drive.IsReady)
                {
                    //MessageBox.Show((line_count.ToString()));
                    CF = 0;
                }
                else { CF = 1; }
            }
            else if (BL == 128)
            {
                DriveInfo drive = new DriveInfo("C");

                if (drive.IsReady)
                {
                    //MessageBox.Show((line_count.ToString()));
                    CF = 0;
                }
                else { CF = 1; }
            }
            else if (BL == 129)
            {
                DriveInfo drive = new DriveInfo("D");

                if (drive.IsReady)
                {
                    //MessageBox.Show((line_count.ToString()));
                    CF = 0;
                }
                else { CF = 1; }
            }


        }
        */


        ushort Wynik(string n1, string n2, string n3)
        {
            ushort number = 0;
            if(n2=="AX")
            {
                number = AX;
            }
            else if (n2=="BX")
            {
                number = BX;
            }
            else if (n2 == "CX")
            {
                number = CX;
            }
            else if (n2 == "DX")
            {
                number = DX;
            }

            if (n1=="ADD" || n1=="SUB" ||  n1=="MOV")
            {
                if (n1=="ADD")
                {
                    return (ushort)(number + Zmienna(n3));
                }
                else if (n1 == "SUB")
                {
                    return (ushort)(number - Zmienna(n3));
                }
                else if (n1 == "MOV")
                {
                    return Zmienna(n3);
                }
            }
            return 0;
        }

        ushort Zmienna(string n3)
        {
            ushort number =0;

            if (int.TryParse(n3, out _))
            {

                number = ushort.Parse(n3);
            }
            else if(n3 == "AX" || n3 == "BX" || n3 == "CX" || n3 == "DX")
            {
                if(n3=="AX")
                {
                    number = AX;
                }
                else if (n3 == "BX")
                {
                    number = BX;
                }
                else if (n3 == "CX")
                {
                    number = CX;
                }
                else if (n3 == "DX")
                {
                    number = DX;
                }
            }
            return number;
        }

        public Form1()
        {
            InitializeComponent();
            block = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AH = 0;
            BX= 0;
            CX = 0;
            DX = 0;
            CF = 0;

            label_AX.Text = AX.ToString();
            label_BX.Text = BX.ToString();
            label_CX.Text = CX.ToString();
            label_DX.Text = DX.ToString();
            label_CF.Text = CF.ToString();
        }
    }
}
