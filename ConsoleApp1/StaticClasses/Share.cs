using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    #region Bookクラス
    public class Book
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Publisher { get; set; }
        public DateTime Published { get; set; }

        public override string ToString()
        {
            return $"{Title}({Publisher}){Price}円 {Published:d}刊行";
        }
    }
    #endregion

    #region Reviewクラス
    public class Review
    {
        public string Isbn { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
    }
    #endregion

    #region データ情報
    public static class AppTables
    {
        public static IEnumerable<Book> Books { get; private set; }
        public static IEnumerable<Review> Reviews { get; private set; }

        static AppTables()
        {
            Books = new List<Book>
            {
                #region Bookインスタンス
                new Book
                {
                    Isbn = "978-4-7981-3547-2",
                    Title = "独習PHP",
                    Price = 3200,
                    Publisher = "翔泳社",
                    Published = new DateTime(2016, 4, 8)
                },
                new Book
                {
                    Isbn = "978-4-7981-4402-3",
                    Title = "独習ASP.NET",
                    Price = 3200,
                    Publisher = "翔泳社",
                    Published = new DateTime(2016, 1, 21)
                },
                new Book
                {
                    Isbn = "978-4-7741-9130-0",
                    Title = "Angularアプリケーションプログラミング",
                    Price = 3200,
                    Publisher = "技術評論社",
                    Published = new DateTime(2017, 8, 4)
                },
                new Book
                {
                    Isbn = "978-4-7741-9030-3",
                    Title = "C#ポケットリファレンス",
                    Price = 1640,
                    Publisher = "技術評論社",
                    Published = new DateTime(2016, 6, 20)
                },
                new Book
                {
                    Isbn = "978-4-8222-5355-4",
                    Title = "アプリを作ろう! Visual C#入門",
                    Price = 2000,
                    Publisher = "日経BP社",
                    Published = new DateTime(2017, 8, 24)
                }
            #endregion
            };

            Reviews = new List<Review>
            {
                #region レビューインスタンス
                new Review
                {
                    Isbn = "978-4-7981-3547-2",
                    Name = "山田太郎",
                    Body = "PHP開発に役立っています。"
                },
                new Review
                {
                    Isbn = "978-4-7981-3547-2",
                    Name = "鈴木花子",
                    Body = "急に仕事で扱うことになり、慌てて読み始めたら、～"
                },
                new Review
                {
                    Isbn = "978-4-7981-4402-3",
                    Name = "山田太郎",
                    Body = "あやふやだったデータの操作が、～"
                },
                new Review
                {
                    Isbn = "978-4-7981-4402-3",
                    Name = "佐藤久美",
                    Body = "サンプルが作りたいものとマッチしていて、～"
                },
                new Review
                {
                    Isbn = "978-4-7981-4402-3",
                    Name = "加藤次郎",
                    Body = "コンパクトにきちんと情報がまとまっていて、～"
                }
                #endregion
            };
        }
    }
    #endregion
}
