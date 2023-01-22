namespace Library;

public sealed class LLibrary
{
    public Floor[] floors = new Floor[3];
    
    private LLibrary(){}

    private static LLibrary instance = new LLibrary();
    public static LLibrary Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new LLibrary();
            }
            return instance;
        }
    }

    public string add(int  floorNumber , int closetNumber ,  int shelfNumber,  Book book)
    {
        int listofBooks = Instance
            .floors[floorNumber]
            .Closetes[closetNumber]
            .Shelfes[shelfNumber]
            .Books.Count;

        if (listofBooks < 10)
        {
            Instance
                .floors[floorNumber]
                .Closetes[closetNumber]
                .Shelfes[shelfNumber]
                .Books.Add(book);

            var books = Instance
                .floors[floorNumber]
                .Closetes[closetNumber]
                .Shelfes[shelfNumber]
                .Books;

            Console.WriteLine("Succesfully added");
        }
        return "Filed";
    }

    public bool contains(
        int floorNumber,
        int closetNumber,
        int shelfNumber
        )
    {
        return  Instance.floors[floorNumber]
            .Closetes[closetNumber]
            .Shelfes[shelfNumber]
            .Books.Count > 0;
    }

    public string find(Book book)
    {
        return $"{Book.getFloor(book)} - floor " +
            $"{Book.getCloset(book)} - closet" +
            $"{Book.getShelf(book)} - shelf"; 
    }
}
