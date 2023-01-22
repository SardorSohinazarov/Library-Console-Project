namespace Library;

public class Book
{
    public string Author { get; set; }
    public string Title { get; set; }

    public string toString()
        =>$"{Author} {Title}";


    public static int getFloor(Book book) //(nechanchi qavatda ekanligi),
    {
        for(int i = 0; i < 3; i++)
        {
            var closets = LLibrary.Instance.floors[i];
            for(var j = 0; j < 30; j++)
            {
                var shelves = closets.Closetes[j];
                for(int k = 0; k < 6; k++)
                {
                    var books = shelves.Shelfes[k].Books;
                    foreach(Book b in books)
                    {
                        if(b.Author == book.Author && b.Title == book.Title)
                            return i+1;
                    }
                }
            }
        }
        return -1;
    }

    public static int getCloset(Book book) //(qaysi shkafda ekanligi),
    {
        for (int i = 0; i < 3; i++)
        {
            var closets = LLibrary.Instance.floors[i];
            for (var j = 0; j < 30; j++)
            {
                var shelves = closets.Closetes[j];
                for (int k = 0; k < 6; k++)
                {
                    var books = shelves.Shelfes[k].Books;
                    foreach (Book b in books)
                    {
                        if (b.Author == book.Author && b.Title == book.Title)
                            return j + 1;
                    }
                }
            }
        }
        return -1;
    }

    public static int getShelf(Book book)  //(nechanchi javonda ekanligi)
    {
        for (int i = 0; i < 3; i++)
        {
            var closets = LLibrary.Instance.floors[i];
            for (var j = 0; j < 30; j++)
            {
                var shelves = closets.Closetes[j];
                for (int k = 0; k < 6; k++)
                {
                    var books = shelves.Shelfes[k].Books;
                    foreach (Book b in books)
                    {
                        if (b.Author == book.Author && b.Title == book.Title)
                            return k + 1 ;
                    }
                }
            }
        }
        return -1;
    }
}
