namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btndot_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + ".";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + "3";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + "6";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + "8";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + "5";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + "2";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + "1";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + "4";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + "7";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + "0";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + "9";
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            textresult.Clear();
            texttotal.Clear();
        }

        float num;
        int count;

        private void btnpls_Click(object sender, EventArgs e)
        {
            if (texttotal.Text != "")
            {
                num = float.Parse(texttotal.Text);
                textresult.Text = texttotal.Text + "+";
                texttotal.Clear();
                count = 1;
            }
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            if (texttotal.Text != "")
            {
                num = float.Parse(texttotal.Text);
                textresult.Text = texttotal.Text + "-";
                texttotal.Clear();
                count = 2;
            }
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            if (texttotal.Text != "")
            {
                num = float.Parse(texttotal.Text);
                textresult.Text = texttotal.Text + "*";
                texttotal.Clear();
                count = 3;
            }
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            if (texttotal.Text != "")
            {
                num = float.Parse(texttotal.Text);
                textresult.Text = texttotal.Text + "/";
                texttotal.Clear();
                count = 4;
            }
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            float ans;
            switch(count)
            {
                case 1:
                    ans = num + float.Parse(texttotal.Text);
                    textresult.Text = textresult.Text + texttotal.Text + "=" + ans;
                    texttotal.Text = ans.ToString();
                    break;

                case 2:
                    ans = num - float.Parse(texttotal.Text);
                    textresult.Text = textresult.Text + texttotal.Text + "=" + ans;
                    texttotal.Text = ans.ToString();
                    break;

                case 3:
                    ans = num * float.Parse(texttotal.Text);
                    textresult.Text = textresult.Text + texttotal.Text + "=" + ans;
                    texttotal.Text = ans.ToString();
                    break;

                case 4:
                    ans = num + float.Parse(texttotal.Text);
                    textresult.Text = textresult.Text + texttotal.Text + "=" + ans;
                    texttotal.Text = ans.ToString();
                    break;
            }
        }
    }
}
