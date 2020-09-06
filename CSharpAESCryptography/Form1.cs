using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpAesCryptography;

namespace CSharpAESCryptography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// انتخاب فایل با استفاده از کلاس OpenFileDialog
        /// </summary>
        /// <param name="toDecrypt">مشخص می کنه که آیا فایل برای رمزگذاری انتخاب می شود یا رمزگشایی</param>
        private void SelectFile(bool toDecrypt = false)
        {
            using (var fileDialog = new OpenFileDialog())
            {
                if (fileDialog.ShowDialog() != DialogResult.OK)
                    return;

                if (toDecrypt)
                    TxtEncryptedFilePath.Text = fileDialog.FileName;
                else
                    TxtOriginalFilePath.Text = fileDialog.FileName;
            }
        }

        private void BtnEncryptText_Click(object sender, EventArgs e)
        {
            try
            {
                var input = TxtPlainText.Text;
                var password = TxtPassword.Text;
                var result = AesCryptography.EncryptText(input, password);
                TxtEncryptedText.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDecryptText_Click(object sender, EventArgs e)
        {
            try
            {
                var input = TxtEncryptedText.Text;
                var password = TxtPassword.Text;
                var result = AesCryptography.DecryptText(input, password);
                TxtDecryptedText.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnBrowseOriginalFile_Click(object sender, EventArgs e)
        {
            SelectFile();
        }

        private void BtbBrowseEncryptedFile_Click(object sender, EventArgs e)
        {
            SelectFile(true);
        }

        private async void BtnEncryptFile_Click(object sender, EventArgs e)
        {
            try
            {
                var mainTitle = Text;
                Text = @"در حال رمزگذاری فایل ...";
                var filePath = TxtOriginalFilePath.Text;
                var password = TxtPassword.Text;
                // برای آن که برنامه در هنگام عملیات رمزگذاری قفل نشود
                //  متد زیر را با استفاده از Task فراخوانی می کنیم
                await Task.Run(() => AesCryptography.EncryptFile(filePath, password));
                Text = mainTitle;
                MessageBox.Show(@"Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void BtnDecryptFile_Click(object sender, EventArgs e)
        {
            try
            {
                var mainTitle = Text;
                Text = @"در حال رمزگشایی فایل ...";
                var filePath = TxtEncryptedFilePath.Text;
                var password = TxtPassword.Text;
                // برای آن که برنامه در هنگام عملیات رمزگشایی قفل نشود
                //  متد زیر را با استفاده از Task فراخوانی می کنیم
                await Task.Run(() => AesCryptography.DecryptFile(filePath, password));
                Text = mainTitle;
                MessageBox.Show(@"Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
