using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuDienAnhViet
{
    public class MyLinkedList
    {
        private Node head;

        public MyLinkedList()
        {
            head = null;
        }

        // Hàm thêm một từ mới vào cuối danh sách
        public void Add(string english, string vietnamese)
        {
            Node newNode = new Node(english, vietnamese);
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                // Nếu từ đã tồn tại, cập nhật nghĩa mới (Xử lý trùng từ)
                if (current.EnglishWord.Equals(english, StringComparison.OrdinalIgnoreCase))
                {
                    current.VietnameseMeaning = vietnamese;
                    return;
                }
                current = current.Next;
            }

            // Kiểm tra Node cuối cùng
            if (current.EnglishWord.Equals(english, StringComparison.OrdinalIgnoreCase))
            {
                current.VietnameseMeaning = vietnamese;
            }
            else
            {
                current.Next = newNode;
            }
        }

        // Hàm tìm kiếm nghĩa của một từ
        public string Search(string english)
        {
            Node current = head;
            while (current != null)
            {
                if (current.EnglishWord.Equals(english, StringComparison.OrdinalIgnoreCase))
                {
                    return current.VietnameseMeaning;
                }
                current = current.Next;
            }
            return null; // Không tìm thấy
        }

        // Hàm xóa một từ khỏi danh sách
        public bool Remove(string english)
        {
            if (head == null) return false;

            if (head.EnglishWord.Equals(english, StringComparison.OrdinalIgnoreCase))
            {
                head = head.Next;
                return true;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.EnglishWord.Equals(english, StringComparison.OrdinalIgnoreCase))
                {
                    current.Next = current.Next.Next;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        // Trả về Node đầu tiên (Dùng cho class Dictionary duyệt danh sách)
        public Node GetHead()
        {
            return head;
        }
    }
}


