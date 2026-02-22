using UnityEngine;
using System.Collections.Generic;

public class QuestSystem : MonoBehaviour
{
    public List<Quest> activeQuests;
    public List<Quest> completedQuests;
    
    void Start()
    {
        activeQuests = new List<Quest>();
        completedQuests = new List<Quest>();
    }
    
    public void AddQuest(Quest quest)
    {
        activeQuests.Add(quest);
        Debug.Log("Quest added: " + quest.title);
    }
    
    public void CompleteQuest(Quest quest)
    {
        if (activeQuests.Contains(quest))
        {
            activeQuests.Remove(quest);
            completedQuests.Add(quest);
            quest.isCompleted = true;
            Debug.Log("Quest completed: " + quest.title);
            
            // Reward player
            if (quest.reward != null)
            {
                GiveReward(quest.reward);
            }
        }
    }
    
    public void UpdateQuestProgress(Quest quest, string objective, bool isComplete)
    {
        if (activeQuests.Contains(quest))
        {
            foreach (QuestObjective obj in quest.objectives)
            {
                if (obj.description == objective)
                {
                    obj.isCompleted = isComplete;
                    Debug.Log("Objective updated: " + objective);
                    CheckQuestCompletion(quest);
                    break;
                }
            }
        }
    }
    
    void CheckQuestCompletion(Quest quest)
    {
        bool allCompleted = true;
        foreach (QuestObjective obj in quest.objectives)
        {
            if (!obj.isCompleted)
            {
                allCompleted = false;
                break;
            }
        }
        
        if (allCompleted && !quest.isCompleted)
        {
            CompleteQuest(quest);
        }
    }
    
    void GiveReward(QuestReward reward)
    {
        Debug.Log("Reward given: " + reward.gold + " gold, " + reward.experience + " experience");
        // In a full implementation, this would update player stats
    }
    
    public bool IsQuestActive(Quest quest)
    {
        return activeQuests.Contains(quest);
    }
    
    public bool IsQuestCompleted(Quest quest)
    {
        return completedQuests.Contains(quest);
    }
}

[System.Serializable]
public class Quest
{
    public string title;
    public string description;
    public bool isCompleted;
    public List<QuestObjective> objectives;
    public QuestReward reward;
    
    public Quest(string title, string description)
    {
        this.title = title;
        this.description = description;
        this.objectives = new List<QuestObjective>();
        this.isCompleted = false;
    }
    
    public void AddObjective(string description)
    {
        objectives.Add(new QuestObjective(description));
    }
}

[System.Serializable]
public class QuestObjective
{
    public string description;
    public bool isCompleted;
    
    public QuestObjective(string description)
    {
        this.description = description;
        this.isCompleted = false;
    }
}

[System.Serializable]
public class QuestReward
{
    public int gold;
    public int experience;
    public List<Item> items;
    
    public QuestReward(int gold, int experience)
    {
        this.gold = gold;
        this.experience = experience;
        this.items = new List<Item>();
    }
}