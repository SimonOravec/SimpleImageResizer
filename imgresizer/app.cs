using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imgresizer
{
    public partial class app : Form
    {

        public static String filepath;
        public static Image image = null;
        public app()
        {
            InitializeComponent();
        }

        private void btn_selectfile_Click(object sender, EventArgs e)
        {
            if (openfile_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filepath = openfile_dialog.FileName;
                    
                    try
                    {
                        image = Image.FromFile(filepath);
                        
                    } catch (Exception ex)
                    {
                        MessageBox.Show("Failed to open file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    img_preview.Image = image;

                    input_height.Text = image.Height.ToString();
                    input_width.Text = image.Width.ToString();

                    input_height.Enabled = true;
                    input_width.Enabled = true;
                    format_selector.Enabled = true;
                    btn_resize.Enabled = true;

                    format_selector.SelectedIndex = getFormatSelectorIndexByExtension(Path.GetExtension(filepath));
                    
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to open file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btn_resize_Click(object sender, EventArgs e)
        {
            String height_raw = input_height.Text;
            String width_raw = input_width.Text;

            if (!int.TryParse(height_raw, out int height)
                || !int.TryParse(width_raw, out int width)
                || height < 1
                || width < 1
                )
            {
                MessageBox.Show("Invalid size entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ImageFormat format = getSelectedFormat();
            if (format == null)
            {
                MessageBox.Show("Invalid format selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String format_text = getFormatString(format);

            savefile_dialog.FileName = "resized" + format_text.Replace("*","").ToLower();
            savefile_dialog.Filter = "Image|"+format_text;
            if (savefile_dialog.ShowDialog() == DialogResult.OK)
            {
                Size newsize = new Size(width, height);
                Image newimage = resizeImage(image, newsize);
                newimage.Save(savefile_dialog.FileName, format);
                MessageBox.Show("Done!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }

        private static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private static String getExtensionFromFormat(ImageFormat format)
        {
            return ImageCodecInfo.GetImageEncoders().FirstOrDefault(x => x.FormatID == format.Guid).FilenameExtension;
        }

        private ImageFormat getSelectedFormat()
        {
            switch(format_selector.SelectedIndex)
            {
                case 0:
                    return ImageFormat.Png;
                case 1:
                    return ImageFormat.Jpeg;
                case 2:
                    return ImageFormat.Bmp;
                case 3:
                    return ImageFormat.Gif;
                default:
                    return null;
            }
        }

        private String getFormatString(ImageFormat format)
        {
            if (format.Equals(ImageFormat.Png)) return "*.PNG";
            if (format.Equals(ImageFormat.Jpeg)) return "*.JPG";
            if (format.Equals(ImageFormat.Bmp)) return "*.BMP";
            if (format.Equals(ImageFormat.Gif)) return "*.GIF";

            return null;
        }

        private int getFormatSelectorIndexByExtension(String ext)
        {
            ext = ext.ToLower();
            switch(ext)
            {
                case ".png":
                    return 0;
                case ".jpg":
                    return 1;
                case ".jpeg":
                    return 1;
                case ".jfif":
                    return 1;
                case ".bmp":
                    return 2;
                case ".gif":
                    return 3;
                default:
                    return 0;
            }
        }
    }
}
