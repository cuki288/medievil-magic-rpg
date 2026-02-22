using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class CharacterUI : MonoBehaviour
{
    [Header("Character Info")]
    public Text characterNameText;
    public Text characterLevelText;
    public Text healthText;
    public Text manaText;
    
    [Header("Stats")]
    public Text strengthText;
    public Text magicText;
    public Text agilityText;
    public Text staminaText;
    
    [Header("Inventory")]
    public Text inventoryCountText;
    public Transform itemContainer;
    public GameObject itemPrefab;
    
    private Character playerCharacter;
    private InventoryManager inventory;
    
    void Start()
    {
        // Initialize UI elements
        if (characterNameText == null) characterNameText = GameObject.Find("CharacterNameText").GetComponent<Text>();
        if (characterLevelText == null) characterLevelText = GameObject.Find("CharacterLevelText").GetComponent<Text>();
        if (healthText == null) healthText = GameObject.Find("HealthText").GetComponent<Text>();
        if (manaText == null) manaText = GameObject.Find("ManaText").GetComponent<Text>();
        
        if (strengthText == null) strengthText = GameObject.Find("StrengthText").GetComponent<Text>();
        if (magicText == null) magicText = GameObject.Find("MagicText").GetComponent<Text>();
        if (agilityText == null) agilityText = GameObject.Find("AgilityText").GetComponent<Text>();
        if (staminaText == null) staminaText = GameObject.Find("StaminaText").GetComponent<Text>();
        
        if (inventoryCountText == null) inventoryCountText = GameObject.Find("InventoryCountText").GetComponent<Text>();
        
        inventory = FindObjectOfType<InventoryManager>();
    }
    
    public void SetCharacter(Character character)
    {
        playerCharacter = character;
        UpdateUI();
    }
    
    public void UpdateUI()
    {
        if (playerCharacter != null)
        {
            // Update character info
            if (characterNameText != null) characterNameText.text = playerCharacter.characterName;
            if (characterLevelText != null) characterLevelText.text = "Level: " + playerCharacter.level;
            if (healthText != null) healthText.text = "HP: " + playerCharacter.health;
            if (manaText != null) manaText.text = "MP: " + playerCharacter.mana;
            
            // Update stats
            if (strengthText != null) strengthText.text = "STR: " + playerCharacter.strength;
            if (magicText != null) magicText.text = "MAG: " + playerCharacter.magic;
            if (agilityText != null) agilityText.text = "AGI: " + playerCharacter.agility;
            if (staminaText != null) staminaText.text = "STA: " + playerCharacter.stamina;
            
            // Update inventory
            if (inventoryCountText != null) inventoryCountText.text = "Items: " + inventory.GetItemCount();
            
            // Update item display
            UpdateItemDisplay();
        }
    }
    
    void UpdateItemDisplay()
    {
        // Clear existing items
        foreach (Transform child in itemContainer)
        {
            Destroy(child.gameObject);
        }
        
        // Display items
        if (inventory != null)
        {
            for (int i = 0; i < Mathf.Min(inventory.GetItemCount(), 5); i++) // Show max 5 items
            {
                Item item = inventory.GetItem(i);
                if (item != null)
                {
                    GameObject itemObject = Instantiate(itemPrefab, itemContainer);
                    Text itemText = itemObject.GetComponentInChildren<Text>();
                    if (itemText != null)
                    {
                        itemText.text = item.name + " (x" + item.quantity + ")";
                    }
                }
            }
        }
    }
}