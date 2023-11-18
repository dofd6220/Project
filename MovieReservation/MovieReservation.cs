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

namespace MovieReservation
{
    public partial class MovieReservation : Form
    {
        private List<MovieCredentials> movies;
        public MovieReservation(List<MovieCredentials> MovieList)
        {
            movies = MovieList;
            InitializeComponent();
            Initdata();
        }
        public void Initdata()
        {
            LoadImageForMovie(movies[0].MovieTitle);
            if (DateTime.TryParseExact(movies[0].MovieTime, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime movieTime))
            {
                // 성공적으로 시간을 파싱한 경우
                int movietimecal = int.Parse(movieTime.ToString("HHmm"));

            }

            string date = DateTime.Now.ToString("yyyy-MM-" + movies[0].Date);
            Movietxt.Text = movies[0].MovieTitle;
            Lasertxt.Text = movies[0].GroupText;
            Theatertxt.Text = movies[0].Theater;
            Hourstxt.Text = movies[0].Hourse;
            MovieTimetxt.Text = movies[0].MovieTime + " ~ " + movieTime.AddMinutes(110).ToString("HH:mm");

            SeatNum.Text = movies[1].SeatText;
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
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // 이미지가 없는 경우 PictureBox 초기화
                    pictureBox1.Image = null;
                }
            }
            catch (FileNotFoundException)
            {
                pictureBox1.Image = null;
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
    }
}
