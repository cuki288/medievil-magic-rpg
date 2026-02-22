using UnityEngine;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour
{
    public List<Item> items;
    public int maxSlots;
    
    void Start()
    {
        items = new List<Item>();
        maxSlots = 20;
    }
    
    public bool AddItem(Item item)
    {
        if (items.Count < maxSlots)
        {
            items.Add(item);
            Debug.Log("Added " + item.name + " to inventory");
            return true;
        }
        else
        {
            Debug.Log("Inventory is full!");
            return false;
        }
    }
    
    public bool RemoveItem(Item item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            Debug.Log("Removed " + item.name + " from inventory");
            return true;
        }
        else
        {
            Debug.Log("Item not found in inventory");
            return false;
        }
    }
    
    public Item GetItem(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            return items[index];
        }
        return null;
    }
    
    public bool IsInventoryFull()
    {
        return items.Count >= maxSlots;
    }
    
    public int GetItemCount()
    {
        return items.Count;
    }
}

[System.Serializable]
public class Item
{
    public string name;
    public string description;
    public int value;
    public ItemType type;
    public int quantity;
    
    public Item(string name, string description, int value, ItemType type, int quantity = 1)
    {
        this.name = name;
        this.description = description;
        this.value = value;
        this.type = type;
        this.quantity = quantity;
    }
}

public enum ItemType
{
    Weapon,
    Armor,
    Consumable,
    QuestItem,
    Material
}