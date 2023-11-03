namespace GameCore.Characters;
public class Inventory {
    public List<Item> items;

    public Inventory() {
        items = new List<Item>(0);
    }

    public static void TranferItem(Inventory FromInventory, Item FromItem, Inventory ToInventory) {
        ToInventory.items.Add(FromItem);
        FromInventory.items.Remove(FromItem);
        return;
    }
}