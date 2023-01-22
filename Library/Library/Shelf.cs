namespace Library;

public class Shelf
{
    public List<Book> Books = new List<Book>();

    public static string getBooks(
        int floorNumber,
        int closetNumber
        )
    {
        var javonlar = LLibrary.Instance
            .floors[floorNumber]
            .Closetes[closetNumber];

        string? listofBooks= "";

        for(int i = 0; i< 6; i++)
        {
            listofBooks += $"Shelf {i+1}\n";
            var kitoblar = javonlar.Shelfes[i].Books;
            foreach(Book book in kitoblar)
            {
                listofBooks = listofBooks + "\n" + book.toString();
            }
            listofBooks += "\n";
        }

        return listofBooks; 
    }
}