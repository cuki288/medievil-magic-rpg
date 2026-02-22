using UnityEngine;
using System.Collections.Generic;

public class BattleSystem : MonoBehaviour
{
    public List<Character> party;
    public List<Character> enemies;
    
    public enum BattlePhase
    {
        PlayerTurn,
        EnemyTurn,
        CombatEnd
    }
    
    public BattlePhase currentPhase;
    
    void Start()
    {
        InitializeBattle();
    }
    
    void InitializeBattle()
    {
        currentPhase = BattlePhase.PlayerTurn;
        party = new List<Character>();
        enemies = new List<Character>();
    }
    
    public void AddPartyMember(Character character)
    {
        party.Add(character);
    }
    
    public void AddEnemy(Character enemy)
    {
        enemies.Add(enemy);
    }
    
    public void PlayerAttack(Character attacker, Character target, int damage)
    {
        if (currentPhase == BattlePhase.PlayerTurn)
        {
            target.TakeDamage(damage);
            Debug.Log(attacker.characterName + " attacks " + target.characterName + " for " + damage + " damage!");
            
            // Check if target is defeated
            if (target.health <= 0)
            {
                Debug.Log(target.characterName + " has been defeated!");
                enemies.Remove(target);
            }
            
            // Switch to enemy turn
            currentPhase = BattlePhase.EnemyTurn;
            StartCoroutine(EnemyTurn());
        }
    }
    
    System.Collections.IEnumerator EnemyTurn()
    {
        yield return new WaitForSeconds(1f);
        
        if (enemies.Count > 0 && party.Count > 0)
        {
            // Simple enemy AI - attack a random party member
            int randomIndex = Random.Range(0, party.Count);
            Character target = party[randomIndex];
            
            int damage = Random.Range(5, 15);
            target.TakeDamage(damage);
            Debug.Log("Enemy attacks " + target.characterName + " for " + damage + " damage!");
            
            // Check if target is defeated
            if (target.health <= 0)
            {
                Debug.Log(target.characterName + " has been defeated!");
                party.Remove(target);
            }
            
            // Switch back to player turn
            currentPhase = BattlePhase.PlayerTurn;
        }
    }
    
    public bool IsBattleOver()
    {
        return (party.Count == 0 || enemies.Count == 0);
    }
}