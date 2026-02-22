using UnityEngine;
using System.Collections.Generic;

public class Character : MonoBehaviour
{
    public string characterName;
    public int level;
    public int health;
    public int mana;
    public int strength;
    public int magic;
    public int agility;
    public int stamina;
    
    public List<string> inventory;
    public List<string> skills;
    
    public CharacterClass characterClass;
    
    void Start()
    {
        InitializeCharacter();
    }
    
    void InitializeCharacter()
    {
        // Initialize character stats based on class
        switch (characterClass)
        {
            case CharacterClass.Warrior:
                health = 100;
                mana = 50;
                strength = 15;
                magic = 5;
                agility = 8;
                stamina = 12;
                break;
            case CharacterClass.Mage:
                health = 70;
                mana = 100;
                strength = 5;
                magic = 15;
                agility = 10;
                stamina = 8;
                break;
            case CharacterClass.Rogue:
                health = 80;
                mana = 60;
                strength = 8;
                magic = 10;
                agility = 15;
                stamina = 10;
                break;
            case CharacterClass.Cleric:
                health = 90;
                mana = 80;
                strength = 10;
                magic = 12;
                agility = 7;
                stamina = 11;
                break;
        }
        
        inventory = new List<string>();
        skills = new List<string>();
    }
    
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health < 0)
            health = 0;
    }
    
    public void Heal(int amount)
    {
        health += amount;
    }
    
    public void UseMana(int amount)
    {
        mana -= amount;
        if (mana < 0)
            mana = 0;
    }
}

public enum CharacterClass
{
    Warrior,
    Mage,
    Rogue,
    Cleric
}