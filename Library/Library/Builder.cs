using System.Drawing;

namespace Library
{
    public class Builder
    {
        public static void Build()
        {  
            for(int k = 0; k < 3; k++)
            {
                var floor = new Floor();
                for(int j = 0; j < 30; j++)
                {
                    var closet = new Closet();
                    for(int i = 0; i < 6; i++)
                    {
                        closet.Shelfes[i] = new Shelf();
                    }
                    floor.Closetes[j] = closet;
                }
                LLibrary.Instance.floors[k] = floor;
            }
        }
    }
}
