using Library;

class Program
{
    static void Main()
    {
        Builder.Build();

        Builder.Build();
        string author = Console.ReadLine();
        string title = Console.ReadLine();
        int floor = int.Parse(Console.ReadLine()) -1;
        int closet = int.Parse(Console.ReadLine()) -1;
        int shelf = int.Parse(Console.ReadLine()) - 1;

        Book book = new Book();

        //Console.WriteLine(LLibrary.Instance.contains(floor, closet, shelf));

        //Console.WriteLine(Shelf.getBooks(floor,closet));
       
        Console.WriteLine(Book.getFloor(book));
        Console.WriteLine(Book.getCloset(book));

        LLibrary.Instance.add(floor, closet, shelf, book);

        Console.WriteLine(Book.getFloor(book));
        Console.WriteLine(Book.getCloset(book));

        Console.WriteLine(LLibrary.Instance.find(book));
    }
}