using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Semkin_K.M._23VP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int[] array;
        private static int[] array1;
        private static int[] array2;
        private static int[] array3;


        private static int Final_time = 0;
        private static int StartTime = 0;
        private static int Final_time1 = 0;
        private static int StartTime1 = 0;
        private static int Final_time2 = 0;
        private static int StartTime2 = 0;

        private bool f = true;
        private int size;
        private Random rnd;

        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();

        }

        private void ord_radio_CheckedChanged(object sender, EventArgs e)
        {
            chart_update();
            size = (int)size_num.Value;
            if (size <= 0) { 
                errors.Text = "Неверный размер массива"; 
                sort_button.Enabled = false;
            }
            else
            {
                sort_button.Enabled=true;
                array = new int[size];
                array[0] = rnd.Next(0, 5);
                for (int i = 1; i < size; i++)
                {
                    array[i] = array[i - 1] + rnd.Next(1, 5);
                }
            }
            
        }

        private void unOrd_radio_CheckedChanged(object sender, EventArgs e)
        {
            chart_update();
            size = (int)size_num.Value;
            if (size <= 0)
            {
                errors.Text = "Неверный размер массива";
                sort_button.Enabled = false;
            }
            else 
            {
                sort_button.Enabled = true;
                array = new int[size];
                for (int i = 0; i < size; i++)
                {
                    array[i] = rnd.Next(1, size);
                }
            }
        }

        private void rOrd_radio_CheckedChanged(object sender, EventArgs e)
        {
            chart_update();
            size = (int)size_num.Value;
            if (size <= 0)
            {
                errors.Text = "Неверный размер массива";
                sort_button.Enabled = false;
            }
            else
            {
                sort_button.Enabled = true;
                array = new int[size];
                array[size - 1] = rnd.Next(0, 5);
                for (int i = size - 2; i > 0; i--)
                {
                    array[i] = array[i + 1] + rnd.Next(1, 5);
                }
            }
        }

        private void partOrd_radio_CheckedChanged(object sender, EventArgs e)
        {
            chart_update();
            size = (int)size_num.Value;
            if (size <= 0)
            {
                errors.Text = "Неверный размер массива";
                sort_button.Enabled = false;
            }
            else
            {
                sort_button.Enabled = true;
                array = new int[size];
                int percent = (int)percentage.Value;
                array[0] = rnd.Next(0, 5);
                for (int i = 1; i < size * percent / 100; i++)
                {
                    array[i] = array[i - 1] + rnd.Next(1, 5);
                }
                for (int i = size * percent / 100; i < size; i++)
                {
                    array[i] = array[i - 1] + rnd.Next(1, 5);
                }
            }
        }

        private void clone(int[] arr1, ref int[] arr2, int size)
        {
            arr2 = new int[size];

            for (int i = 0; i < size; i++) {
                arr2[i] = arr1[i];
            }

        }

        private void quickSortF(int[] array, int leftindex, int rightindex)
        {
            int i = leftindex;
            int j = rightindex;
            int pivot = array[leftindex];

            if (f)
            {
                StartTime = Environment.TickCount;
                f = false;
            }

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftindex < j)
                quickSortF(array, leftindex, j);

            if (i < rightindex)
                quickSortF(array, i, rightindex);

            Final_time = Environment.TickCount - StartTime;

        }

        private void quickSortM(int[] array, int leftindex, int rightindex)
        {

            int i = leftindex;
            int j = rightindex;
            int pivot = array[(rightindex+leftindex)/2];

            if (f) { 
                StartTime1 = Environment.TickCount;
                f = false;
            }

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftindex < j)
                quickSortM(array, leftindex, j);

            if (i < rightindex)
                quickSortM(array, i, rightindex);

            Final_time1 = Environment.TickCount - StartTime1;

        }

        private void quickSortL(int[] array, int leftindex, int rightindex)
        {

            int i = leftindex;
            int j = rightindex;
            int pivot = array[rightindex];

            if (f) {
                StartTime2 = Environment.TickCount;
                f = false;
            }

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftindex < j)
                quickSortL(array, leftindex, j);

            if (i < rightindex)
                quickSortL(array, i, rightindex);

            Final_time2 = Environment.TickCount - StartTime2;

        }

        private void chart_fill(int switcher)
        {

            switch (switcher)
            {
                case 1:

                    Time.Series[0].Points.AddY(Final_time);
                    break;

                case 2:

                    Time.Series[1].Points.AddY(Final_time1);
                    break;

                case 3:

                    Time.Series[2].Points.AddY(Final_time2);
                    break;
            }

        }

        private void chart_update()
        {
            Time.Series[0].Points.Clear();
            Time.Series[1].Points.Clear();
            Time.Series[2].Points.Clear();
        }

        private void start_Click(object sender, EventArgs e)
        {
            timeTable.Rows.Clear();
            chart_update();
            errors.Text = "";

            int percent = 1;
            int row_count = 0;

            try {
                while (percent <= 100)
                {

                    clone(array, ref array1, (size * percent) / 100);
                    clone(array, ref array2, (size * percent) / 100);
                    clone(array, ref array3, (size * percent) / 100);

                    timeTable.Rows.Add();

                    timeTable.Rows[row_count].Cells[0].Value = percent + "%";

                    quickSortF(array1, 0, ((size * percent) / 100) - 1);
                    timeTable.Rows[row_count].Cells[1].Value = Final_time + "ticks";
                    chart_fill(1);

                    f = true;

                    quickSortM(array2, 0, ((size * percent) / 100) - 1);
                    timeTable.Rows[row_count].Cells[2].Value = Final_time1 + "ticks";
                    chart_fill(2);

                    f = true;

                    quickSortL(array3, 0, ((size * percent) / 100) - 1);
                    timeTable.Rows[row_count].Cells[3].Value = Final_time2 + "ticks";
                    chart_fill(3);

                    f = true;

                    percent += 1;
                    row_count++;

                }

            } 
            catch (Exception ex)
            {
                errors.Text = "Укажите тип массива!";
            }
            

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Time_Click(object sender, EventArgs e)
        {

        }
    }
}
