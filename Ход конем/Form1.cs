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

        static int CountHutch = 10;
        int[,] M = new int[CountHutch, CountHutch];
        int K = 0;

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Restart();
            ClearGame();
        }

        private void подсказкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (K == 0 || K == 100) return;

            ClearColor();

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
                                    case 5: btn05.BackColor = Color.Silver; break;
                                    case 6: btn06.BackColor = Color.Silver; break;
                                    case 7: btn07.BackColor = Color.Silver; break;
                                    case 8: btn08.BackColor = Color.Silver; break;
                                    case 9: btn09.BackColor = Color.Silver; break;
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
                                    case 5: btn15.BackColor = Color.Silver; break;
                                    case 6: btn16.BackColor = Color.Silver; break;
                                    case 7: btn17.BackColor = Color.Silver; break;
                                    case 8: btn18.BackColor = Color.Silver; break;
                                    case 9: btn19.BackColor = Color.Silver; break;
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
                                    case 5: btn25.BackColor = Color.Silver; break;
                                    case 6: btn25.BackColor = Color.Silver; break;
                                    case 7: btn27.BackColor = Color.Silver; break;
                                    case 8: btn28.BackColor = Color.Silver; break;
                                    case 9: btn29.BackColor = Color.Silver; break;
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
                                    case 5: btn35.BackColor = Color.Silver; break;
                                    case 6: btn36.BackColor = Color.Silver; break;
                                    case 7: btn37.BackColor = Color.Silver; break;
                                    case 8: btn38.BackColor = Color.Silver; break;
                                    case 9: btn39.BackColor = Color.Silver; break;
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
                                    case 5: btn45.BackColor = Color.Silver; break;
                                    case 6: btn46.BackColor = Color.Silver; break;
                                    case 7: btn47.BackColor = Color.Silver; break;
                                    case 8: btn48.BackColor = Color.Silver; break;
                                    case 9: btn49.BackColor = Color.Silver; break;
                                }
                                break;
                            case 5:
                                switch (j)
                                {
                                    case 0: btn50.BackColor = Color.Silver; break;
                                    case 1: btn51.BackColor = Color.Silver; break;
                                    case 2: btn52.BackColor = Color.Silver; break;
                                    case 3: btn53.BackColor = Color.Silver; break;
                                    case 4: btn54.BackColor = Color.Silver; break;
                                    case 5: btn55.BackColor = Color.Silver; break;
                                    case 6: btn56.BackColor = Color.Silver; break;
                                    case 7: btn57.BackColor = Color.Silver; break;
                                    case 8: btn58.BackColor = Color.Silver; break;
                                    case 9: btn59.BackColor = Color.Silver; break;
                                }
                                break;
                            case 6:
                                switch (j)
                                {
                                    case 0: btn60.BackColor = Color.Silver; break;
                                    case 1: btn61.BackColor = Color.Silver; break;
                                    case 2: btn62.BackColor = Color.Silver; break;
                                    case 3: btn63.BackColor = Color.Silver; break;
                                    case 4: btn64.BackColor = Color.Silver; break;
                                    case 5: btn65.BackColor = Color.Silver; break;
                                    case 6: btn66.BackColor = Color.Silver; break;
                                    case 7: btn67.BackColor = Color.Silver; break;
                                    case 8: btn68.BackColor = Color.Silver; break;
                                    case 9: btn69.BackColor = Color.Silver; break;
                                }
                                break;
                            case 7:
                                switch (j)
                                {
                                    case 0: btn70.BackColor = Color.Silver; break;
                                    case 1: btn71.BackColor = Color.Silver; break;
                                    case 2: btn72.BackColor = Color.Silver; break;
                                    case 3: btn73.BackColor = Color.Silver; break;
                                    case 4: btn74.BackColor = Color.Silver; break;
                                    case 5: btn75.BackColor = Color.Silver; break;
                                    case 6: btn76.BackColor = Color.Silver; break;
                                    case 7: btn77.BackColor = Color.Silver; break;
                                    case 8: btn78.BackColor = Color.Silver; break;
                                    case 9: btn79.BackColor = Color.Silver; break;
                                }
                                break;
                            case 8:
                                switch (j)
                                {
                                    case 0: btn80.BackColor = Color.Silver; break;
                                    case 1: btn81.BackColor = Color.Silver; break;
                                    case 2: btn82.BackColor = Color.Silver; break;
                                    case 3: btn83.BackColor = Color.Silver; break;
                                    case 4: btn84.BackColor = Color.Silver; break;
                                    case 5: btn85.BackColor = Color.Silver; break;
                                    case 6: btn86.BackColor = Color.Silver; break;
                                    case 7: btn87.BackColor = Color.Silver; break;
                                    case 8: btn88.BackColor = Color.Silver; break;
                                    case 9: btn89.BackColor = Color.Silver; break;
                                }
                                break;
                            case 9:
                                switch (j)
                                {
                                    case 0: btn90.BackColor = Color.Silver; break;
                                    case 1: btn91.BackColor = Color.Silver; break;
                                    case 2: btn92.BackColor = Color.Silver; break;
                                    case 3: btn93.BackColor = Color.Silver; break;
                                    case 4: btn94.BackColor = Color.Silver; break;
                                    case 5: btn95.BackColor = Color.Silver; break;
                                    case 6: btn95.BackColor = Color.Silver; break;
                                    case 7: btn97.BackColor = Color.Silver; break;
                                    case 8: btn98.BackColor = Color.Silver; break;
                                    case 9: btn99.BackColor = Color.Silver; break;
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
                ClearColor();

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
                            case 5: { btn05.Text = ""; break; }
                            case 6: { btn06.Text = ""; break; }
                            case 7: { btn07.Text = ""; break; }
                            case 8: { btn08.Text = ""; break; }
                            case 9: { btn09.Text = ""; break; }
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
                            case 5: { btn15.Text = ""; break; }
                            case 6: { btn16.Text = ""; break; }
                            case 7: { btn17.Text = ""; break; }
                            case 8: { btn18.Text = ""; break; }
                            case 9: { btn19.Text = ""; break; }
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
                            case 5: { btn25.Text = ""; break; }
                            case 6: { btn26.Text = ""; break; }
                            case 7: { btn27.Text = ""; break; }
                            case 8: { btn28.Text = ""; break; }
                            case 9: { btn29.Text = ""; break; }
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
                            case 5: { btn35.Text = ""; break; }
                            case 6: { btn36.Text = ""; break; }
                            case 7: { btn37.Text = ""; break; }
                            case 8: { btn38.Text = ""; break; }
                            case 9: { btn39.Text = ""; break; }
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
                            case 5: { btn45.Text = ""; break; }
                            case 6: { btn46.Text = ""; break; }
                            case 7: { btn47.Text = ""; break; }
                            case 8: { btn48.Text = ""; break; }
                            case 9: { btn49.Text = ""; break; }
                        }
                        break;
                    case 5:
                        switch (j)
                        {
                            case 0: { btn50.Text = ""; break; }
                            case 1: { btn51.Text = ""; break; }
                            case 2: { btn52.Text = ""; break; }
                            case 3: { btn53.Text = ""; break; }
                            case 4: { btn54.Text = ""; break; }
                            case 5: { btn55.Text = ""; break; }
                            case 6: { btn56.Text = ""; break; }
                            case 7: { btn57.Text = ""; break; }
                            case 8: { btn58.Text = ""; break; }
                            case 9: { btn59.Text = ""; break; }
                        }
                        break;
                    case 6:
                        switch (j)
                        {
                            case 0: { btn60.Text = ""; break; }
                            case 1: { btn61.Text = ""; break; }
                            case 2: { btn62.Text = ""; break; }
                            case 3: { btn63.Text = ""; break; }
                            case 4: { btn64.Text = ""; break; }
                            case 5: { btn65.Text = ""; break; }
                            case 6: { btn66.Text = ""; break; }
                            case 7: { btn67.Text = ""; break; }
                            case 8: { btn68.Text = ""; break; }
                            case 9: { btn69.Text = ""; break; }
                        }
                        break;
                    case 7:
                        switch (j)
                        {
                            case 0: { btn70.Text = ""; break; }
                            case 1: { btn71.Text = ""; break; }
                            case 2: { btn72.Text = ""; break; }
                            case 3: { btn73.Text = ""; break; }
                            case 4: { btn74.Text = ""; break; }
                            case 5: { btn75.Text = ""; break; }
                            case 6: { btn76.Text = ""; break; }
                            case 7: { btn77.Text = ""; break; }
                            case 8: { btn78.Text = ""; break; }
                            case 9: { btn79.Text = ""; break; }
                        }
                        break;
                    case 8:
                        switch (j)
                        {
                            case 0: { btn80.Text = ""; break; }
                            case 1: { btn81.Text = ""; break; }
                            case 2: { btn82.Text = ""; break; }
                            case 3: { btn83.Text = ""; break; }
                            case 4: { btn84.Text = ""; break; }
                            case 5: { btn85.Text = ""; break; }
                            case 6: { btn86.Text = ""; break; }
                            case 7: { btn87.Text = ""; break; }
                            case 8: { btn88.Text = ""; break; }
                            case 9: { btn89.Text = ""; break; }
                        }
                        break;
                    case 9:
                        switch (j)
                        {
                            case 0: { btn90.Text = ""; break; }
                            case 1: { btn91.Text = ""; break; }
                            case 2: { btn92.Text = ""; break; }
                            case 3: { btn93.Text = ""; break; }
                            case 4: { btn94.Text = ""; break; }
                            case 5: { btn95.Text = ""; break; }
                            case 6: { btn96.Text = ""; break; }
                            case 7: { btn97.Text = ""; break; }
                            case 8: { btn98.Text = ""; break; }
                            case 9: { btn99.Text = ""; break; }
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

            if (K == 100)
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
            btn05.Text = "";
            btn06.Text = "";
            btn07.Text = "";
            btn08.Text = "";
            btn09.Text = "";

            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn14.Text = "";
            btn15.Text = "";
            btn16.Text = "";
            btn17.Text = "";
            btn18.Text = "";
            btn19.Text = "";

            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn23.Text = "";
            btn24.Text = "";
            btn25.Text = "";
            btn25.Text = "";
            btn27.Text = "";
            btn28.Text = "";
            btn29.Text = "";

            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            btn33.Text = "";
            btn34.Text = "";
            btn35.Text = "";
            btn36.Text = "";
            btn37.Text = "";
            btn38.Text = "";
            btn39.Text = "";

            btn40.Text = "";
            btn41.Text = "";
            btn42.Text = "";
            btn43.Text = "";
            btn44.Text = "";
            btn45.Text = "";
            btn46.Text = "";
            btn47.Text = "";
            btn48.Text = "";
            btn49.Text = "";

            btn50.Text = "";
            btn51.Text = "";
            btn52.Text = "";
            btn53.Text = "";
            btn54.Text = "";
            btn55.Text = "";
            btn56.Text = "";
            btn57.Text = "";
            btn58.Text = "";
            btn59.Text = "";
            
            btn60.Text = "";
            btn61.Text = "";
            btn62.Text = "";
            btn63.Text = "";
            btn64.Text = "";
            btn65.Text = "";
            btn66.Text = "";
            btn67.Text = "";
            btn68.Text = "";
            btn69.Text = "";
            
            btn70.Text = "";
            btn71.Text = "";
            btn72.Text = "";
            btn73.Text = "";
            btn74.Text = "";
            btn75.Text = "";
            btn76.Text = "";
            btn77.Text = "";
            btn78.Text = "";
            btn79.Text = "";
            
            btn80.Text = "";
            btn81.Text = "";
            btn82.Text = "";
            btn83.Text = "";
            btn84.Text = "";
            btn85.Text = "";
            btn86.Text = "";
            btn87.Text = "";
            btn88.Text = "";
            btn89.Text = "";
            
            btn90.Text = "";
            btn91.Text = "";
            btn92.Text = "";
            btn93.Text = "";
            btn94.Text = "";
            btn95.Text = "";
            btn96.Text = "";
            btn97.Text = "";
            btn98.Text = "";
            btn99.Text = "";
        }

        private void ClearColor()
        {
            btn00.BackColor = SystemColors.Control;
            btn01.BackColor = SystemColors.Control;
            btn02.BackColor = SystemColors.Control;
            btn03.BackColor = SystemColors.Control;
            btn04.BackColor = SystemColors.Control;
            btn05.BackColor = SystemColors.Control;
            btn06.BackColor = SystemColors.Control;
            btn07.BackColor = SystemColors.Control;
            btn08.BackColor = SystemColors.Control;
            btn09.BackColor = SystemColors.Control;

            btn10.BackColor = SystemColors.Control;
            btn11.BackColor = SystemColors.Control;
            btn12.BackColor = SystemColors.Control;
            btn13.BackColor = SystemColors.Control;
            btn14.BackColor = SystemColors.Control;
            btn15.BackColor = SystemColors.Control;
            btn16.BackColor = SystemColors.Control;
            btn17.BackColor = SystemColors.Control;
            btn18.BackColor = SystemColors.Control;
            btn19.BackColor = SystemColors.Control;

            btn20.BackColor = SystemColors.Control;
            btn21.BackColor = SystemColors.Control;
            btn22.BackColor = SystemColors.Control;
            btn23.BackColor = SystemColors.Control;
            btn24.BackColor = SystemColors.Control;
            btn25.BackColor = SystemColors.Control;
            btn26.BackColor = SystemColors.Control;
            btn27.BackColor = SystemColors.Control;
            btn28.BackColor = SystemColors.Control;
            btn29.BackColor = SystemColors.Control;

            btn30.BackColor = SystemColors.Control;
            btn31.BackColor = SystemColors.Control;
            btn32.BackColor = SystemColors.Control;
            btn33.BackColor = SystemColors.Control;
            btn34.BackColor = SystemColors.Control;
            btn35.BackColor = SystemColors.Control;
            btn36.BackColor = SystemColors.Control;
            btn37.BackColor = SystemColors.Control;
            btn38.BackColor = SystemColors.Control;
            btn39.BackColor = SystemColors.Control;

            btn40.BackColor = SystemColors.Control;
            btn41.BackColor = SystemColors.Control;
            btn42.BackColor = SystemColors.Control;
            btn43.BackColor = SystemColors.Control;
            btn44.BackColor = SystemColors.Control;
            btn45.BackColor = SystemColors.Control;
            btn46.BackColor = SystemColors.Control;
            btn47.BackColor = SystemColors.Control;
            btn48.BackColor = SystemColors.Control;
            btn49.BackColor = SystemColors.Control;
            
            btn50.BackColor = SystemColors.Control;
            btn51.BackColor = SystemColors.Control;
            btn52.BackColor = SystemColors.Control;
            btn53.BackColor = SystemColors.Control;
            btn54.BackColor = SystemColors.Control;
            btn55.BackColor = SystemColors.Control;
            btn56.BackColor = SystemColors.Control;
            btn57.BackColor = SystemColors.Control;
            btn58.BackColor = SystemColors.Control;
            btn59.BackColor = SystemColors.Control;
            
            btn60.BackColor = SystemColors.Control;
            btn61.BackColor = SystemColors.Control;
            btn62.BackColor = SystemColors.Control;
            btn63.BackColor = SystemColors.Control;
            btn64.BackColor = SystemColors.Control;
            btn65.BackColor = SystemColors.Control;
            btn66.BackColor = SystemColors.Control;
            btn67.BackColor = SystemColors.Control;
            btn68.BackColor = SystemColors.Control;
            btn69.BackColor = SystemColors.Control;
            
            btn70.BackColor = SystemColors.Control;
            btn71.BackColor = SystemColors.Control;
            btn72.BackColor = SystemColors.Control;
            btn73.BackColor = SystemColors.Control;
            btn74.BackColor = SystemColors.Control;
            btn75.BackColor = SystemColors.Control;
            btn76.BackColor = SystemColors.Control;
            btn77.BackColor = SystemColors.Control;
            btn78.BackColor = SystemColors.Control;
            btn79.BackColor = SystemColors.Control;
            
            btn80.BackColor = SystemColors.Control;
            btn81.BackColor = SystemColors.Control;
            btn82.BackColor = SystemColors.Control;
            btn83.BackColor = SystemColors.Control;
            btn84.BackColor = SystemColors.Control;
            btn85.BackColor = SystemColors.Control;
            btn86.BackColor = SystemColors.Control;
            btn87.BackColor = SystemColors.Control;
            btn88.BackColor = SystemColors.Control;
            btn89.BackColor = SystemColors.Control;
            
            btn90.BackColor = SystemColors.Control;
            btn91.BackColor = SystemColors.Control;
            btn92.BackColor = SystemColors.Control;
            btn93.BackColor = SystemColors.Control;
            btn94.BackColor = SystemColors.Control;
            btn95.BackColor = SystemColors.Control;
            btn96.BackColor = SystemColors.Control;
            btn97.BackColor = SystemColors.Control;
            btn98.BackColor = SystemColors.Control;
            btn99.BackColor = SystemColors.Control;
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