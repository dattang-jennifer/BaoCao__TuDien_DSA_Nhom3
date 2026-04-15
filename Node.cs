using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuDienAnhViet
{
    public class Node
    {
        public string EnglishWord; // Key: Từ tiếng Anh
        public string VietnameseMeaning; // Value: Nghĩa tiếng Việt
        public Node Next; // Con trỏ trỏ đến Node tiếp theo

        public Node(string english, string vietnamese)
        {
            this.EnglishWord = english;
            this.VietnameseMeaning = vietnamese;
            this.Next = null;
        }
    }
}
