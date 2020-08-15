using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Ex01.ApplicationUI
{
    public partial class FormAlbums : Form
    {
        FacebookObjectCollection<Album> albums;
        private int albumIndex;

        public FormAlbums(FacebookObjectCollection<Album> i_Albums)
        {
            this.albums = i_Albums;
            albumIndex = 0;
            InitializeComponent();
            initializeComponent();      
        }

        private void initializeComponent()
        {
            albumPictureBox1.Load(albums[albumIndex].PictureAlbumURL);
            f_LabelAlbumName.Text = albums[albumIndex].Name;
            f_LabelCreatedDate.Text = string.Format("created date: {0} ", albums[albumIndex].CreatedTime.ToString());  
        }

        private void previousLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (albumIndex > 0)
            {
                albumIndex--;
            }

            initializeComponent();
        }

        private void nextLinkLable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (albumIndex < albums.Count - 1)
            {
                albumIndex++;
            }

            initializeComponent();
        }
    }
}
