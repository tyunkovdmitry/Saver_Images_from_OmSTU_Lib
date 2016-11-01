using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Saver_Images_from_OmSTU_Lib.Properties;

namespace Saver_Images_from_OmSTU_Lib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string tempUriString = textBoxURL.Text;
            string pathString = textBoxPath.Text;
            if (!String.IsNullOrWhiteSpace(tempUriString))
            {
                if (!String.IsNullOrWhiteSpace(pathString))
                {
                    if (numericUpDownStartPage.Value <= numericUpDownEndPage.Value)
                    {
                        string uriString = tempUriString.Replace("id=ShowFT&o=sc", "id=FTShowPagePng");
                        uriString = tempUriString.Replace("id=ShowFT&o=sp", "id=FTShowPagePng");
                        for (var i = numericUpDownStartPage.Value; i <= numericUpDownEndPage.Value; i++)
                        {
                            string pageUriString = uriString + "&p=" + i;
                            string fileString = pathString + Path.DirectorySeparatorChar + i + ".png";
                            DownloadRemoteImageFile(pageUriString, fileString);
                        }
                    }
                    else
                    {
                        MessageBox.Show(Resources.Form1_buttonSave_Click_Start_page_should_be_less_than_or_equal_to_end_page, Resources.Form1_buttonSave_Click_Error_page_number, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(Resources.Form1_buttonSave_Click_Please_enter_path_and_try_again,
                        Resources.Form1_buttonSave_Click_Empty_path, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(Resources.Form1_buttonSave_Click_Please_enter_the_URL_and_try_again,
                    Resources.Form1_buttonSave_Click_Empty_URL, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = folderBrowserDialog.SelectedPath;
            }
            
        }

        private static void DownloadRemoteImageFile(string uri, string fileName)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest) WebRequest.Create(uri);
                HttpWebResponse response = (HttpWebResponse) request.GetResponse();

                // Check that the remote file was found. The ContentType
                // check is performed since a request for a non-existent
                // image file might be redirected to a 404-page, which would
                // yield the StatusCode "OK", even though the image was not
                // found.
                if ((response.StatusCode == HttpStatusCode.OK ||
                     response.StatusCode == HttpStatusCode.Moved ||
                     response.StatusCode == HttpStatusCode.Redirect) &&
                    response.ContentType.StartsWith("image", StringComparison.OrdinalIgnoreCase))
                {

                    // if the remote file was found, download oit
                    using (Stream inputStream = response.GetResponseStream())
                    using (Stream outputStream = File.OpenWrite(fileName))
                    {
                        byte[] buffer = new byte[4096];
                        int bytesRead;
                        do
                        {
                            bytesRead = inputStream.Read(buffer, 0, buffer.Length);
                            outputStream.Write(buffer, 0, bytesRead);
                        } while (bytesRead != 0);
                    }
                }
            }
            catch (WebException exception)
            {
                if (exception.Status.Equals(WebExceptionStatus.ProtocolError))
                {
                    Thread.Sleep(TimeSpan.FromSeconds(10));
                    DownloadRemoteImageFile(uri, fileName);
                }
                else
                {
                    MessageBox.Show(exception.Message, exception.Status.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(1);
                }
            }
        }

        private void selectNumUpDownText(object numUpDownObj, EventArgs e)
        {
            var numericUpDown = numUpDownObj as NumericUpDown;
            if (numericUpDown != null)
                numericUpDown.Select(0, numericUpDown.Text.Length);
        }

        private void selectTextBoxText(object textBoxObj, EventArgs e)
        {
            var textBox = textBoxObj as TextBox;
            if (textBox != null)
                textBox.SelectAll();
        }
    }
}