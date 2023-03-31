namespace PhotoBook
{
    public class PhotoBook
    {
        static int pages ;
        public PhotoBook() {
            Console.WriteLine("\nPhotoBook created");
            pages = 16;

        }
        public PhotoBook(int totalPages) {
            Console.WriteLine("\nPhotoBook created");
            pages = totalPages;
        }
        public int GetNumberPages()
        {
            return pages;
        }
    }

    public class AddPhotoBook
    {
        static int pages;
        public AddPhotoBook()
        {
            pages = 64;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {


            

            

        }
    }
}