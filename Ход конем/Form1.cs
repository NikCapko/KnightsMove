using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ход_конем
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
            ClearGame();
        }

        static int CountHutch = 5;
        int[,] M = new int[CountHutch, CountHutch];
        int K = 0;

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Restart();
            ClearGame();
        }

        private void подсказкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (K == 0 || K == 25) return;

            int k = FindNuminMatrix(K, M)[0];
            int l = FindNuminMatrix(K, M)[1];

            bool flag = false;

            for (int i = 0; i < CountHutch; i++)
            {
                for (int j = 0; j < CountHutch; j++)
                {
                    flag = false;

                    if (Math.Abs(k - i) == 1 && Math.Abs(j - l) == 2 && M[i, j] == 0) flag = true;
                    if (Math.Abs(k - i) == 2 && Math.Abs(j - l) == 1 && M[i, j] == 0) flag = true;

                    if (flag)
                    {
                        switch (i)
                        {
                            case 0:
                                switch (j)
                                {
                                    case 0: btn00.BackColor = Color.Silver; break;
                                    case 1: btn01.BackColor = Color.Silver; break;
                                    case 2: btn02.BackColor = Color.Silver; break;
                                    case 3: btn03.BackColor = Color.Silver; break;
                                    case 4: btn04.BackColor = Color.Silver; break;
                                }
                                break;
                            case 1:
                                switch (j)
                                {
                                    case 0: btn10.BackColor = Color.Silver; break;
                                    case 1: btn11.BackColor = Color.Silver; break;
                                    case 2: btn12.BackColor = Color.Silver; break;
                                    case 3: btn13.BackColor = Color.Silver; break;
                                    case 4: btn14.BackColor = Color.Silver; break;
                                }
                                break;
                            case 2:
                                switch (j)
                                {
                                    case 0: btn20.BackColor = Color.Silver; break;
                                    case 1: btn21.BackColor = Color.Silver; break;
                                    case 2: btn22.BackColor = Color.Silver; break;
                                    case 3: btn23.BackColor = Color.Silver; break;
                                    case 4: btn24.BackColor = Color.Silver; break;
                                }
                                break;
                            case 3:
                                switch (j)
                                {
                                    case 0: btn30.BackColor = Color.Silver; break;
                                    case 1: btn31.BackColor = Color.Silver; break;
                                    case 2: btn32.BackColor = Color.Silver; break;
                                    case 3: btn33.BackColor = Color.Silver; break;
                                    case 4: btn34.BackColor = Color.Silver; break;
                                }
                                break;
                            case 4:
                                switch (j)
                                {
                                    case 0: btn40.BackColor = Color.Silver; break;
                                    case 1: btn41.BackColor = Color.Silver; break;
                                    case 2: btn42.BackColor = Color.Silver; break;
                                    case 3: btn43.BackColor = Color.Silver; break;
                                    case 4: btn44.BackColor = Color.Silver; break;
                                }
                                break;
                        }
                    }
                }
            }
        }

        private void отменитьХодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (K > 0)
            {
                int i = FindNuminMatrix(K, M)[0];
                int j = FindNuminMatrix(K, M)[1];

                M[i, j] = 0;
                K--;

                switch (i)
                {
                    case 0:
                        switch (j)
                        {
                            case 0: { btn00.Text = ""; break; }
                            case 1: { btn01.Text = ""; break; }
                            case 2: { btn02.Text = ""; break; }
                            case 3: { btn03.Text = ""; break; }
                            case 4: { btn04.Text = ""; break; }
                        }
                        break;
                    case 1:
                        switch (j)
                        {
                            case 0: { btn10.Text = ""; break; }
                            case 1: { btn11.Text = ""; break; }
                            case 2: { btn12.Text = ""; break; }
                            case 3: { btn13.Text = ""; break; }
                            case 4: { btn14.Text = ""; break; }
                        }
                        break;
                    case 2:
                        switch (j)
                        {
                            case 0: { btn20.Text = ""; break; }
                            case 1: { btn21.Text = ""; break; }
                            case 2: { btn22.Text = ""; break; }
                            case 3: { btn23.Text = ""; break; }
                            case 4: { btn24.Text = ""; break; }
                        }
                        break;
                    case 3:
                        switch (j)
                        {
                            case 0: { btn30.Text = ""; break; }
                            case 1: { btn31.Text = ""; break; }
                            case 2: { btn32.Text = ""; break; }
                            case 3: { btn33.Text = ""; break; }
                            case 4: { btn34.Text = ""; break; }
                        }
                        break;
                    case 4:
                        switch (j)
                        {
                            case 0: { btn40.Text = ""; break; }
                            case 1: { btn41.Text = ""; break; }
                            case 2: { btn42.Text = ""; break; }
                            case 3: { btn43.Text = ""; break; }
                            case 4: { btn44.Text = ""; break; }
                        }
                        break;
                }
            }
        }

        private int[] FindNuminMatrix(int k, int[,] m)
        {
            int[] temp = new int[2];

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(0); j++)
                {
                    if (m[i, j] == k)
                    {
                        temp[0] = i;
                        temp[1] = j;
                        break;
                    }
                }
            }

            return temp;
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (CloseGame())
                this.Close();
        }

        private void обИгреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("         Цель игры — обойти все клетки поля буквой Г,\r\n   при этом не наступая на одну и ту же клетку дважды.", "Об игре", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void авторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                Цапко Николай\r\n\n       E-mail: nik.capko@mail.ru", "Авторы", MessageBoxButtons.OK);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ClearColor();

            bool flag = false;

            int k = int.Parse((sender as Button).Tag.ToString()[0].ToString());
            int l = int.Parse((sender as Button).Tag.ToString()[1].ToString());

            if ((sender as Button).Text != "") return;

            if (K == 0)
            {
                flag = true;
                M[k, l] = K;
            }
            else
            {
                int i = FindNuminMatrix(K, M)[0];
                int j = FindNuminMatrix(K, M)[1];

                if (Math.Abs(k - i) == 1 && Math.Abs(j - l) == 2) flag = true;
                if (Math.Abs(k - i) == 2 && Math.Abs(j - l) == 1) flag = true;
            }

            if (flag)
            {
                K++;
                (sender as Button).Text = K.ToString();
                M[k, l] = K;
            }

            if (K == 25)
            {
                MessageBox.Show("Вы выиграли");
                return;
            }

            if (!Check()) MessageBox.Show("       Ходы закончились. Вы проиграли.");
        }

        private void ClearGame()
        {
            K = 0;

            for (int i = 0; i < CountHutch; i++)
            {
                for (int j = 0; j < CountHutch; j++)
                {
                    M[i, j] = 0;
                }
            }

            btn00.Text = "";
            btn01.Text = "";
            btn02.Text = "";
            btn03.Text = "";
            btn04.Text = "";

            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn14.Text = "";

            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn23.Text = "";
            btn24.Text = "";

            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            btn33.Text = "";
            btn34.Text = "";

            btn40.Text = "";
            btn41.Text = "";
            btn42.Text = "";
            btn43.Text = "";
            btn44.Text = "";
        }

        private void ClearColor()
        {
            btn00.BackColor = SystemColors.Control;
            btn01.BackColor = SystemColors.Control;
            btn02.BackColor = SystemColors.Control;
            btn03.BackColor = SystemColors.Control;
            btn04.BackColor = SystemColors.Control;

            btn10.BackColor = SystemColors.Control;
            btn11.BackColor = SystemColors.Control;
            btn12.BackColor = SystemColors.Control;
            btn13.BackColor = SystemColors.Control;
            btn14.BackColor = SystemColors.Control;

            btn20.BackColor = SystemColors.Control;
            btn21.BackColor = SystemColors.Control;
            btn22.BackColor = SystemColors.Control;
            btn23.BackColor = SystemColors.Control;
            btn24.BackColor = SystemColors.Control;

            btn30.BackColor = SystemColors.Control;
            btn31.BackColor = SystemColors.Control;
            btn32.BackColor = SystemColors.Control;
            btn33.BackColor = SystemColors.Control;
            btn34.BackColor = SystemColors.Control;

            btn40.BackColor = SystemColors.Control;
            btn41.BackColor = SystemColors.Control;
            btn42.BackColor = SystemColors.Control;
            btn43.BackColor = SystemColors.Control;
            btn44.BackColor = SystemColors.Control;
        }

        private bool Check()
        {
            int k = FindNuminMatrix(K, M)[0];
            int l = FindNuminMatrix(K, M)[1];

            for (int i = 0; i < CountHutch; i++)
            {
                for (int j = 0; j < CountHutch; j++)
                {
                    if (Math.Abs(k - i) == 1 && Math.Abs(j - l) == 2 && M[i, j] == 0) return true;
                    if (Math.Abs(k - i) == 2 && Math.Abs(j - l) == 1 && M[i, j] == 0) return true;
                }
            }

            return false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (!CloseGame()) e.Cancel = true;
                //else 
                    e.Cancel = false;
        }

        private bool CloseGame()
        {
            if (MessageBox.Show("       Вы действительно хотите выйти из игры ??", "Ход конем", MessageBoxButtons.YesNo) == DialogResult.Yes) return true;
            return false;
        }
    }
}