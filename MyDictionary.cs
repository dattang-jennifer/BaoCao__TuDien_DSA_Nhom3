using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuDienAnhViet
{
    // Class Dictionary sử dụng Hash Table + LinkedList (Chaining)
    public class MyDictionary
    {
        private MyLinkedList[] table; // Mảng các LinkedList (bucket)
        private int size; // Kích thước bảng băm

        // Constructor
        public MyDictionary(int size = 100)
        {
            this.size = size;
            table = new MyLinkedList[size];

            // Khởi tạo từng bucket
            for (int i = 0; i < size; i++)
            {
                table[i] = new MyLinkedList();
            }
        }

        // ========================
        // HÀM BĂM (HASH FUNCTION)
        // ========================
        private int Hash(string key)
        {
            int hash = 0;

            foreach (char c in key.ToLower())
            {
                hash = (hash * 31 + c) % size;
            }

            return hash;
        }

        // ========================
        // THÊM / CẬP NHẬT TỪ
        // ========================
        public void Add(string english, string vietnamese)
        {
            int index = Hash(english);
            table[index].Add(english, vietnamese);
        }

        // ========================
        // TÌM KIẾM
        // ========================
        public string Search(string english)
        {
            int index = Hash(english);
            return table[index].Search(english);
        }

        // ========================
        // XÓA TỪ
        // ========================
        public bool Remove(string english)
        {
            int index = Hash(english);
            return table[index].Remove(english);
        }

        // ========================
        // DUYỆT TOÀN BỘ TỪ (dùng để lưu file)
        // ========================
        public void Traverse(Action<string, string> action)
        {
            for (int i = 0; i < size; i++)
            {
                Node current = table[i].GetHead();
                while (current != null)
                {
                    action(current.EnglishWord, current.VietnameseMeaning);
                    current = current.Next;
                }
            }
        }
    }

}
