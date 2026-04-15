using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TuDienAnhViet
{
    public partial class Form2 : Form
    {
        // Khai báo từ điển
        private MyDictionary myDict = new MyDictionary(100);

        public Form2()
        {
            InitializeComponent();
        }

        // Khi form load, đọc dữ liệu từ file data.txt
        private void Form2_Load(object sender, EventArgs e)
        {
            if (File.Exists("data.txt"))
            {
                foreach (var line in File.ReadAllLines("data.txt"))
                {
                    var parts = line.Split('=');
                    if (parts.Length == 2)
                    {
                        myDict.Add(parts[0], parts[1]);
                        lstWords.Items.Add(parts[0]);
                    }
                }
            }
        }

        // Nút Tra cứu
        private void bntSearch_Click(object sender, EventArgs e)
        {
            string word = txtEnglish.Text.Trim();
            string meaning = myDict.Search(word);
            txtVietnamese.Text = meaning ?? "Không tìm thấy từ này.";
        }

        // Nút Thêm từ
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string word = txtEnglish.Text.Trim();
            string meaning = txtVietnamese.Text.Trim();

            if (!string.IsNullOrEmpty(word) && !string.IsNullOrEmpty(meaning))
            {
                myDict.Add(word, meaning);

                if (!lstWords.Items.Contains(word))
                    lstWords.Items.Add(word);

                // Ghi lại toàn bộ từ điển vào file
                var lines = new List<string>();
                myDict.Traverse((w, m) => lines.Add(w + "=" + m));
                File.WriteAllLines("data.txt", lines);

                MessageBox.Show("Đã thêm/cập nhật từ mới!");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ từ và nghĩa.");
            }
        }


        // Nút Xóa từ
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string word = txtEnglish.Text.Trim();

            if (!string.IsNullOrEmpty(word) && lstWords.Items.Contains(word))
            {
                myDict.Remove(word);
                lstWords.Items.Remove(word);

                // Ghi lại toàn bộ từ điển vào file
                var lines = new List<string>();
                myDict.Traverse((w, m) => lines.Add(w + "=" + m));
                File.WriteAllLines("data.txt", lines);

                MessageBox.Show("Đã xóa từ!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy từ cần xóa.");
            }
        }


        // Các hàm trống để tránh lỗi nếu Designer có gắn sự kiện
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void txtVietnamese_TextChanged(object sender, EventArgs e) { }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
