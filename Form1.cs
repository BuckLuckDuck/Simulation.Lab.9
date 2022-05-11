using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Simulation.Lab._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void set_prob5_value()
        {
            decimal temp = (decimal)(1d - (double)nud_prob1.Value - (double)nud_prob2.Value - (double)nud_prob3.Value - (double)nud_prob4.Value);
            if (temp > 0) nud_prob5.Value = temp;
        }

        private void reload_chart()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(1, nud_prob1.Value);
            chart1.Series[0].Points.AddXY(2, nud_prob2.Value);
            chart1.Series[0].Points.AddXY(3, nud_prob3.Value);
            chart1.Series[0].Points.AddXY(4, nud_prob4.Value);
            chart1.Series[0].Points.AddXY(5, nud_prob5.Value);
        }

        private void nud_prob1_ValueChanged(object sender, EventArgs e)
        {
            set_prob5_value();
            reload_chart();
        }

        private void nud_prob2_ValueChanged(object sender, EventArgs e)
        {
            set_prob5_value();
            reload_chart();
        }

        private void nud_prob3_ValueChanged(object sender, EventArgs e)
        {
            set_prob5_value();
            reload_chart();
        }

        private void nud_prob4_ValueChanged(object sender, EventArgs e)
        {
            set_prob5_value();
            reload_chart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int random_prob = 1001;
            nud_prob1.Value = (decimal)rnd.Next(random_prob) / 1000;
            random_prob = random_prob - (int)(nud_prob1.Value * 1000);
            nud_prob2.Value = (decimal)rnd.Next(random_prob) / 1000;
            random_prob = random_prob - (int)(nud_prob2.Value * 1000);
            nud_prob3.Value = (decimal)rnd.Next(random_prob) / 1000;
            random_prob = random_prob - (int)(nud_prob3.Value * 1000);
            nud_prob4.Value = (decimal)rnd.Next(random_prob) / 1000;
        }

        private void btn_get_answer_Click(object sender, EventArgs e)
        {
            List<double> probabilities = new List<double>() { (double)nud_prob1.Value, (double)nud_prob2.Value, (double)nud_prob3.Value, (double)nud_prob4.Value, (double)nud_prob5.Value };
            int[] probs_count = new int[5] { 0, 0, 0, 0, 0 };
            int N = (int)nud_n.Value;
            Random random = new Random();

            for (int i = 0; i < N; i++)
            {
                double A = random.NextDouble();
                int k = 0;
                do
                {
                    A -= probabilities[k];
                    k++;
                }
                while (A > 0);
                probs_count[k - 1]++;
            }

            // Эмпирическое среднее.
            double average = 0;
            for (int i = 1; i < probs_count.Length + 1; i++)
            {
                average += (double)probs_count[i - 1] / N * i;
            }

            // Эмпирическая дисперсия.
            double variance = 0;
            for (int i = 1; i < probs_count.Length + 1; i++)
            {
                variance += (double)probs_count[i - 1] / N * i * i;
            }
            variance -= Math.Pow(average, 2);

            // Математическое среднее.
            double mathAverage = 0;
            for (int i = 1; i < probs_count.Length + 1; i++)
            {
                mathAverage += probabilities[i - 1] * i;
            }

            // Математическое среднее.
            double mathVariance = 0;
            for (int i = 1; i < probs_count.Length + 1; i++)
            {
                mathVariance += probabilities[i - 1] * i * i;
            }
            mathVariance -= Math.Pow(mathAverage, 2);

            // Относительная погрешность среднего.
            double avgRelErr = Math.Abs(average - mathAverage) / Math.Abs(mathAverage);

            // Относительная погрещность дисперсии.
            double varianceRelErr = Math.Abs(variance - mathVariance) / Math.Abs(mathVariance);

            // Хи-квадрат
            double chiSqr = 0;
            for (int i = 1; i < probs_count.Length + 1; i++)
            {
                chiSqr += (double)probs_count[i - 1] * probs_count[i - 1] / (N * probabilities[i - 1]);
            }
            chiSqr -= N;

            lbl_prob1_end.Text = Convert.ToString((double)probs_count[0] / N);
            lbl_prob2_end.Text = Convert.ToString((double)probs_count[1] / N);
            lbl_prob3_end.Text = Convert.ToString((double)probs_count[2] / N);
            lbl_prob4_end.Text = Convert.ToString((double)probs_count[3] / N);
            lbl_prob5_end.Text = Convert.ToString((double)probs_count[4] / N);

            lbl_average_value.Text = Convert.ToString(average);
            lbl_variance_value.Text = Convert.ToString(variance);
            lbl_chi_value.Text = Convert.ToString(chiSqr) + " > 9.488";
            lbl_average_error.Text = Convert.ToString(avgRelErr) + "%";
            lbl_variance_error.Text = Convert.ToString(varianceRelErr) + "%";
        }
    }
}
