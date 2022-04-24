using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.WinAppServices;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ObservableCollection<ApplicationInfo> applicationInfos;
        ApplicationInfo selectedItem;

        private void UpdateProcessList()
        {
            applicationInfos = WinAppServices.GetHts();
            if (applicationInfos.Count > 0)
            {
                comboBox1.DataSource = applicationInfos;
                comboBox1.DisplayMember = "Name";
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.DataSource = null;
                MessageBox.Show("프로그램 리스트 감지 실패.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = comboBox1.SelectedItem as ApplicationInfo;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateProcessList();
        }

        /// <summary>
        /// 매도
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            selectedItem = comboBox1.SelectedItem as ApplicationInfo;
            if (selectedItem != null)
            {
                sendKey(selectedItem.Handle, VKeys.KEY_F12, true);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 청산
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            selectedItem = comboBox1.SelectedItem as ApplicationInfo;
            if (selectedItem != null)
            {
                sendKey(selectedItem.Handle, VKeys.KEY_F11, true);
            }
        }

        /// <summary>
        /// 매수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            selectedItem = comboBox1.SelectedItem as ApplicationInfo;
            if (selectedItem != null)
            {
                sendKey(selectedItem.Handle, VKeys.KEY_9, true);
            }
        }
    }
}
