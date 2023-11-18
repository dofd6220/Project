using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserDataClassLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MovieReservation
{
    public partial class SeatSelection : Form
    {
        private List<MovieCredentials> movies;

        private List<string> seats = new List<string>();
        private int maxSeats = 1;
        private System.Windows.Forms.RadioButton previousSelectedRadioButton;
        private bool isEventHandlingEnabled = true;

        public SeatSelection(List<MovieCredentials> MovieList)
        {
            movies = MovieList;
            InitializeComponent();
            InitData();

            A1btn.Click += Button_Click;
            A2btn.Click += Button_Click;
            A3btn.Click += Button_Click;
            A4btn.Click += Button_Click;
            A5btn.Click += Button_Click;
            A6btn.Click += Button_Click;
            A7btn.Click += Button_Click;
            A8btn.Click += Button_Click;

            // B1 ~ B8 버튼
            B1btn.Click += Button_Click;
            B2btn.Click += Button_Click;
            B3btn.Click += Button_Click;
            B4btn.Click += Button_Click;
            B5btn.Click += Button_Click;
            B6btn.Click += Button_Click;
            B7btn.Click += Button_Click;
            B8btn.Click += Button_Click;

            // C1 ~ C8 버튼
            C1btn.Click += Button_Click;
            C2btn.Click += Button_Click;
            C3btn.Click += Button_Click;
            C4btn.Click += Button_Click;
            C5btn.Click += Button_Click;
            C6btn.Click += Button_Click;
            C7btn.Click += Button_Click;
            C8btn.Click += Button_Click;

            // D1 ~ D8 버튼
            D1btn.Click += Button_Click;
            D2btn.Click += Button_Click;
            D3btn.Click += Button_Click;
            D4btn.Click += Button_Click;
            D5btn.Click += Button_Click;
            D6btn.Click += Button_Click;
            D7btn.Click += Button_Click;
            D8btn.Click += Button_Click;

            // E1 ~ E8 버튼
            E1btn.Click += Button_Click;
            E2btn.Click += Button_Click;
            E3btn.Click += Button_Click;
            E4btn.Click += Button_Click;
            E5btn.Click += Button_Click;
            E6btn.Click += Button_Click;
            E7btn.Click += Button_Click;
            E8btn.Click += Button_Click;

            // 좌석 버튼
            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            radioButton2.CheckedChanged += RadioButton_CheckedChanged;
            radioButton3.CheckedChanged += RadioButton_CheckedChanged;
            radioButton4.CheckedChanged += RadioButton_CheckedChanged;
            radioButton5.CheckedChanged += RadioButton_CheckedChanged;

            radioButton6.CheckedChanged += RadioButton_CheckedChanged;
            radioButton7.CheckedChanged += RadioButton_CheckedChanged;
            radioButton8.CheckedChanged += RadioButton_CheckedChanged;
            radioButton9.CheckedChanged += RadioButton_CheckedChanged;
            radioButton10.CheckedChanged += RadioButton_CheckedChanged;

            radioButton11.CheckedChanged += RadioButton_CheckedChanged;
            radioButton12.CheckedChanged += RadioButton_CheckedChanged;
            radioButton13.CheckedChanged += RadioButton_CheckedChanged;
            radioButton14.CheckedChanged += RadioButton_CheckedChanged;
            radioButton15.CheckedChanged += RadioButton_CheckedChanged;

            radioButton16.CheckedChanged += RadioButton_CheckedChanged;
            radioButton17.CheckedChanged += RadioButton_CheckedChanged;
            radioButton18.CheckedChanged += RadioButton_CheckedChanged;
            radioButton19.CheckedChanged += RadioButton_CheckedChanged;
            radioButton20.CheckedChanged += RadioButton_CheckedChanged;

            radioButton21.CheckedChanged += RadioButton_CheckedChanged;
            radioButton22.CheckedChanged += RadioButton_CheckedChanged;
            radioButton23.CheckedChanged += RadioButton_CheckedChanged;
            radioButton24.CheckedChanged += RadioButton_CheckedChanged;
            radioButton25.CheckedChanged += RadioButton_CheckedChanged;

            //제출 버튼
            Submitbtn.Click += Submitbtn_Click;

        }
        private void InitData()
        {
            LoadImageForMovie(movies[0].MovieTitle);
            if (DateTime.TryParseExact(movies[0].MovieTime, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime movieTime))
            {
                // 성공적으로 시간을 파싱한 경우
                int movietimecal = int.Parse(movieTime.ToString("HHmm"));

            }

            string date = DateTime.Now.ToString("yyyy-MM-"+movies[0].Date);
            DateTimetxt.Text = date;
            titletxt.Text = movies[0].MovieTitle;
            theatertxt.Text = movies[0].Theater;
            theatertxt1.Text = movies[0].Theater;

            datetxt.Text = movies[0].Date;
            hourstxt.Text = movies[0].Hourse;
            MovieTimetxt.Text = movies[0].MovieTime + " ~ " + movieTime.AddMinutes(110).ToString("HH:mm");
            Lasertxt.Text = movies[0].GroupText;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!isEventHandlingEnabled)
            {
                return;
            }

            System.Windows.Forms.RadioButton selectedRadioButton = (System.Windows.Forms.RadioButton)sender;

            System.Windows.Forms.RadioButton tempPreviousSelectedRadioButton = previousSelectedRadioButton;

            if (seats.Count > int.Parse(selectedRadioButton.Text))
            {
                MessageBox.Show("선택한 좌석이 얘매 인원 보다 많습니다.");

                if (tempPreviousSelectedRadioButton != null)
                {
                    isEventHandlingEnabled = false;
                    tempPreviousSelectedRadioButton.Checked = true;
                    isEventHandlingEnabled = true;
                    SeatName.Text += tempPreviousSelectedRadioButton.Text;
                    SeatCnt(tempPreviousSelectedRadioButton.Text);
                }
                return;
            }
            SeatNameChecking();
            if (selectedRadioButton.Checked)
            {
                SeatName.Text += selectedRadioButton.Text;
                SeatCnt(selectedRadioButton.Text);
            }

            else if (radioButton26.Checked)
            {
                SeatName.Text += radioButton26.Text;
                SeatCnt(radioButton26.Text);
            }
            previousSelectedRadioButton = selectedRadioButton;
        }
        private void SeatNameChecking()
        {

            if (radioButton1.Checked || radioButton2.Checked ||
                radioButton3.Checked || radioButton4.Checked ||
                    radioButton5.Checked)
            {
                SeatName.Text = "수험표 ";
            }
            else if (radioButton6.Checked || radioButton7.Checked ||
                radioButton8.Checked || radioButton9.Checked ||
                    radioButton10.Checked)
            {
                SeatName.Text = "일반 ";
            }
            else if (radioButton11.Checked || radioButton12.Checked ||
                radioButton13.Checked || radioButton14.Checked ||
                    radioButton15.Checked)
            {
                SeatName.Text = "청소년 ";
            }
            else if (radioButton16.Checked || radioButton17.Checked ||
                radioButton18.Checked || radioButton19.Checked ||
                    radioButton20.Checked)
            {
                SeatName.Text = "우대 ";
            }
            else if (radioButton21.Checked || radioButton22.Checked ||
                radioButton23.Checked || radioButton24.Checked ||
                    radioButton25.Checked)
            {
                SeatName.Text = "경로 ";
            }
            else if (radioButton26.Checked)
            {
                SeatName.Text = "ALL ";
            }
        }
        private void UpdateSeatNumText()
        {
            seats.Sort();
            SeatNumtxt.Text = string.Join(" ", seats);
        }

        private void SeatCnt(String radioButtonValue)
        {
            maxSeats = int.Parse(radioButtonValue);
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string seatNumber = btn.Name.Substring(0, 2);

            // 라디오 버튼이 선택된 경우 해당 라디오 버튼 체크 해제
            if (btn.BackColor != Color.Red && seats.Count < maxSeats)
            {
                btn.BackColor = Color.Red;
                btn.ForeColor = Color.White;
                seats.Add(seatNumber);
            }
            else if (btn.BackColor == Color.Red)
            {
                btn.BackColor = default;
                btn.ForeColor = default;
                seats.Remove(seatNumber);
            }
            else if (seats.Count == maxSeats)
            {
                MessageBox.Show("이미 모든 좌석을 선택하였습니다.");
                return;
            }
            UpdateSeatNumText();
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

            string movieTitle = titletxt.Text;
            string theater = theatertxt.Text;
            string date = datetxt.Text;
            string movietime = MovieTimetxt.Text;
            string hours = hourstxt.Text;
            string groupText = Lasertxt.Text;
            string seat = SeatNumtxt.Text;

            MessageBox.Show(seat);
            movies.Add(new MovieCredentials( movieTitle,  theater,  date,  hours, movietime,  groupText,  seat));

            this.Visible = false;
            MovieReservation frm = new MovieReservation(movies);
            frm.Show();
            }
        }
    }