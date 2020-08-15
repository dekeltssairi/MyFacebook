using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01.ApplicationUI
{
    public partial class FormAlbums : Form
    {
        // private FacebookObjectCollection<Album> albums;
        FacebookObjectCollection<Album> albums;
        private int albumIndex;
        public FormAlbums(FacebookObjectCollection<Album> albums)
        {
            this.albums = albums;
            albumIndex = 0;
            InitializeComponent();
            initializeComponent();
               
        }

        private void initializeComponent()
        {
            albumPictureBox1.Load(albums[albumIndex].PictureAlbumURL);
            f_LabelAlbumName.Text = albums[albumIndex].Name;
            f_LabelCreatedDate.Text = string.Format("created date: {0} ",albums[albumIndex].CreatedTime.ToString());
            
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
