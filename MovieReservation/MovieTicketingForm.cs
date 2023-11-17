using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserDataClassLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MovieReservation
{
    public partial class MovieTicketingForm : Form
    {
        private List<UserCredentials> users;
        private List<MovieCredentials> movies;
        private UserCredentials currentUser;

        private List<System.Windows.Forms.RadioButton> radioButtonGroup1;
        private List<System.Windows.Forms.RadioButton> radioButtonGroup2;

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

            Submitbtn.Click += Submitbtn_Click;

            radioButtonGroup1 = new List<System.Windows.Forms.RadioButton>
        {
            radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, radioButton6,
        };

            radioButtonGroup2 = new List<System.Windows.Forms.RadioButton>
        {
            radioButton7, radioButton8, 
        };
        }
        private void InitData()
        {
            movies = new List<MovieCredentials>();
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
                // 선택한 영화 표지
                LoadImageForMovie(selectedItem);
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
                // 선택한 영화 표지
                LoadImageForMovie(selectedItem);
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
                if (theatertxt.Text == "명동역씨네...")
                {
                    theatertxt.Text = "명동역씨네라이브러리";
                }
                if (theatertxt.Text == "송도타임스...")
                {
                    theatertxt.Text = "송도타임스페이스";
                }
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

                if (selectedRadioButton == radioButton7 || selectedRadioButton == radioButton8)
                {
                    // Uncheck radio1 to radio6 when radio7 or radio8 is checked
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                }
                else if (radioButton7.Checked || radioButton8.Checked)
                {
                    // Uncheck radio7 and radio8 when radio1 to radio6 is checked
                    radioButton7.Checked = false;
                    radioButton8.Checked = false;
                }
            }
        }

        private void LoadImageForMovie(string movieTitle)
        {
            try
            {
                // 여기서 movieTitle에 따라 해당하는 이미지 파일을 가져오는 로직을 구현합니다.
                // 이미지 파일의 경로를 적절히 수정하세요.
                string imagePath = GetImagePathForMovie(movieTitle);

                // PictureBox에 이미지 로드
                if (!string.IsNullOrEmpty(imagePath))
                {
                    pictureBox5.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // 이미지가 없는 경우 PictureBox 초기화
                    pictureBox5.Image = null;
                }
            }
            catch (FileNotFoundException)
            {
                pictureBox5.Image = null;
            }
        }

        private string GetImagePathForMovie(string movieTitle)
        {
            // 각 영화 제목에 대한 이미지 파일의 경로를 반환하는 로직을 구현합니다.
            // 예를 들어, 영화 제목에 따라 특정 폴더에 이미지 파일이 저장되어 있다고 가정합니다.
            // 이 부분을 실제 프로젝트에 맞게 수정하세요.

            // 예시 경로: "C:\MovieImages\"
            string imageName = "";
            string imageFolderPath = @"..\..\img\MovieCover\";

            // 예시: 영화 제목에 공백을 제거하고 ".jpg" 확장자를 붙인다.
            if (movieTitle.Contains(":"))
            {
                imageName = SanitizeMovieTitle(movieTitle) + ".jpg";
            }
            else
            {
                imageName = movieTitle.Replace(" ", "") + ".jpg";
            }

            // 이미지 파일의 전체 경로 반환
            return Path.Combine(imageFolderPath, imageName);
        }
        static string SanitizeMovieTitle(string title)
        {
            // 특수 문자 및 공백을 제거하고 언더스코어로 대체
            string sanitizedTitle = Regex.Replace(title, "[^a-zA-Z0-9]", "_");

            return sanitizedTitle;
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.RadioButton selectedRadioButton = radioButtonGroup1.Concat(radioButtonGroup2).FirstOrDefault(rb => rb.Checked);

            string movieTitle = titletxt.Text;
            string theater = theatertxt.Text;
            string date = datetxt.Text;
            string hours = hourstxt.Text;
            string movietime = selectedRadioButton?.Text;
            string groupText = "";

            if (selectedRadioButton != null)
            {
                // 라디오 버튼이 그룹1에 속하는지 확인
                if (radioButtonGroup1.Contains(selectedRadioButton))
                {
                    // groupbox1의 text를 전송
                    groupText = groupBox1.Text;
                    // 처리 로직 추가
                }
                // 라디오 버튼이 그룹2에 속하는지 확인
                else if (radioButtonGroup2.Contains(selectedRadioButton))
                {
                    // groupbox2의 text를 전송
                    groupText = groupBox2.Text;
                    // 처리 로직 추가
                }

                movies.Add(new MovieCredentials(movieTitle, theater, date, hours, movietime, groupText));

                this.Visible = false;
                SeatSelection frm = new SeatSelection(movies);
                frm.Show();
            }
        }
    }
}
