using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MasterForm
{
    public class Assitantclass
    {
        public static void makeFieldsBlank(Control control)
        {
            try
            {
                foreach (Control item in control.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                    if (item is ComboBox)
                    {
                        item.Text = null;
                    }
                    if (item is PictureBox)
                    {
                        item.BackgroundImage = null;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static byte[] imageConverter(PictureBox pictureBox)
        {
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                pictureBox.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] ImageFile = new byte[memoryStream.Length];
                memoryStream.Position = 0;
                memoryStream.Read(ImageFile, 0, ImageFile.Length);
                return ImageFile;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //public static byte[] codeContainingBug(RichTextBox richTextBox)
        //{
        //    try
        //    {

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}
