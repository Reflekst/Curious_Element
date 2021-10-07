using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item", order = 1)]

public class Item : ScriptableObject
{
    public string itemName = "New Item";
    public int itemId;
    public Sprite itemIcon;
}