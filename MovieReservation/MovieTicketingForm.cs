using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserDataClassLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MovieReservation
{
    public partial class MovieTicketingForm : Form
    {
        private List<UserCredentials> users;
        private UserCredentials currentUser;
        public MovieTicketingForm(List<UserCredentials> userList)
        {
            users = userList;
            InitializeComponent();
            InitData();
            listBox1.MouseClick += listBox1_MouseClick;
            listBox2.MouseClick += listBox2_MouseClick;
            comboBox1.MouseClick += comboBox1_MouseClick;
            listBox3.MouseClick += listBox3_MouseClick;
            listBox4.MouseClick += listBox4_MouseClick;

            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            radioButton2.CheckedChanged += RadioButton_CheckedChanged;
            radioButton3.CheckedChanged += RadioButton_CheckedChanged;
            radioButton4.CheckedChanged += RadioButton_CheckedChanged;
            radioButton5.CheckedChanged += RadioButton_CheckedChanged;
            radioButton6.CheckedChanged += RadioButton_CheckedChanged;

            radioButton7.CheckedChanged += RadioButton_CheckedChanged;
            radioButton8.CheckedChanged += RadioButton_CheckedChanged;
        }
        private void InitData()
        {
       
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            DateTimetxt.Text = date;

            if (users.Count > 0)
            {
                currentUser = users[0];
                Nametxt.Text = currentUser.UserName + "님 반갑습니다.";
            }

            int totalDays = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            int currentDay = DateTime.Now.Day;
            for (int i = currentDay; i <= totalDays; i++)
            {
                listBox4.Items.Add(i.ToString());
            }
        }

    private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = -1;

            // 마우스 포인터의 위치
            Point point = e.Location;

            // 리스트 박스의 IndexFromPoint 메서드 호출
            selectedIndex = listBox1.IndexFromPoint(point);

            if (selectedIndex != -1) // 빈 공간이 아닌 곳을 더블클릭 했을 때.
            {
                // 선택된 항목 저장
                string selectedItem = listBox1.Items[selectedIndex] as string;

                // 선택한 항목으로 텍스트 대입
                titletxt.Text = selectedItem;
            }
        }
        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = -1;

            // 마우스 포인터의 위치
            Point point = e.Location;

            // 리스트 박스의 IndexFromPoint 메서드 호출
            selectedIndex = listBox2.IndexFromPoint(point);

            if (selectedIndex != -1) // 빈 공간이 아닌 곳을 더블클릭 했을 때.
            {
                // 선택된 항목 저장
                string selectedItem = listBox2.Items[selectedIndex] as string;

                // 선택한 항목으로 텍스트 대입
                titletxt.Text = selectedItem;
            }
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            listBox3.Items.Clear();

            string[] seoul = { "강남", "강변", "건대입구", "구로", "대학로", "동대문", "등촌", "명동", "명동역씨네라이브러리" };
            string[] gyeongi = { "경기광주", "고양백석", "고양행신", "범계", "부천", "동탄", "동두천", "다산", "산본" };
            string[] incheon = { "계양", "부평", "송도타임스페이스", "연수역", "인천", "인천가정", "인천논현", "인천도화", "인천시민공원" };
            string[] gangwon = { "강릉", "기린", "원주", "원통", "인제", "춘천" };

            for (int i = 0; i < seoul.Length; i++)
            {
                string text = seoul[i].ToString();
                if (text.Length > 5)
                {
                    text = text.Substring(0, 5) + "...";
                }
                if (comboBox1.SelectedIndex == 0)
                {
                    listBox3.Items.Add(text);
                }
            }
            for (int i = 0; i < gyeongi.Length; i++)
            {
                string text = gyeongi[i].ToString();
                if (text.Length > 5)
                {
                    text = text.Substring(0, 5) + "...";
                }

                if (comboBox1.SelectedIndex == 1)
                {
                    listBox3.Items.Add(text);
                }
            }
            for (int i = 0; i < incheon.Length; i++)
            {
                string text = incheon[i].ToString();
                if (text.Length > 5)
                {
                    text = text.Substring(0, 5) + "...";
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    listBox3.Items.Add(text);
                }
            }
            for (int i = 0; i < gangwon.Length; i++)
            {
                string text = gangwon[i].ToString();
                if (text.Length > 5)
                {
                    text = text.Substring(0, 5) + "...";
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    listBox3.Items.Add(text);
                }
            }
 
        }
        private void listBox3_MouseClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = -1;

            // 마우스 포인터의 위치
            Point point = e.Location;

            // 리스트 박스의 IndexFromPoint 메서드 호출
            selectedIndex = listBox3.IndexFromPoint(point);

            if (selectedIndex != -1) // 빈 공간이 아닌 곳을 더블클릭 했을 때.
            {
                // 선택된 항목 저장
                string selectedItem = listBox3.Items[selectedIndex] as string;

                // 선택한 항목으로 텍스트 대입
                theatertxt.Text = selectedItem;
            }           

        }
        private void listBox4_MouseClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = -1;

            // 마우스 포인터의 위치
            Point point = e.Location;

            // 리스트 박스의 IndexFromPoint 메서드 호출
            selectedIndex = listBox4.IndexFromPoint(point);

            if (selectedIndex != -1) // 빈 공간이 아닌 곳을 더블클릭 했을 때.
            {
                // 선택된 항목 저장
                string selectedItem = listBox4.Items[selectedIndex] as string;

                // 선택한 항목으로 텍스트 대입
                datetxt.Text = selectedItem;
            }

        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.RadioButton selectedRadioButton = (System.Windows.Forms.RadioButton)sender;

            if (selectedRadioButton.Checked)
            {
                // 라디오버튼이 선택되었을 때 label에 텍스트를 설정합니다.
                hourstxt.Text = selectedRadioButton.Text;
            }

            // 라디오 버튼 7~8이 체크되었을 때
            if (selectedRadioButton == radioButton1)
            {
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;

            }
            if (selectedRadioButton == radioButton2)
            {
                radioButton1.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;

            }
            if (selectedRadioButton == radioButton3)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;

            }
            if (selectedRadioButton == radioButton4)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;

            }
            if (selectedRadioButton == radioButton5)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;

            }
            if (selectedRadioButton == radioButton6)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
            }
            if (selectedRadioButton == radioButton7)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton8.Checked = false;

            }
            if (selectedRadioButton == radioButton8)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;

            }
        }
    }
}
