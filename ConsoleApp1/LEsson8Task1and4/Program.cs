using Lesson8Task1and4;

internal class Program
{
    private static void Main(string[] args)
    {
        Bag myBag = new Bag();

        //open the bag
        myBag.ToggleBag();

        Item myItem = new Item();
        myItem.SetName("Keys");

        //add item to the bag
        myBag.AddItem(myItem);

        //close the bag
        myBag.ToggleBag();

        //add item to closed bag
        myBag.AddItem(new Item());

        //open the bag
        myBag.ToggleBag();

        Item removedItem = myBag.RemoveItem(0);

    }
}