# Architecture - Medievil Magic RPG

## Overview
Medievil Magic RPG is a Unity-based medieval fantasy RPG game that implements core RPG mechanics including character progression, combat systems, quests, and inventory management.

## System Architecture
The game follows a modular architecture with the following main components:

1. **Character System**
   - Character stats (health, mana, strength, magic, agility, stamina)
   - Character classes (Warrior, Mage, Rogue, Cleric)
   - Level progression and stat scaling
   - Equipment and inventory management

2. **Combat System**
   - Turn-based combat mechanics
   - Spell casting and damage calculation
   - Status effects and buffs
   - Enemy AI

3. **Inventory and Skills**
   - Item management system
   - Skill tree and spell system
   - Equipment system with stat bonuses

4. **User Interface**
   - Character screen display
   - Skill menus
   - Inventory system
   - Quest tracking

## Code Structure
```
Assets/
├── Scripts/
│   ├── Character/
│   │   ├── Character.cs
│   │   ├── CharacterClass.cs
│   │   └── Equipment.cs
│   ├── Combat/
│   │   └── BattleSystem.cs
│   ├── Inventory/
│   │   └── InventoryManager.cs
│   ├── UI/
│   │   └── CharacterUI.cs
│   └── Quest/
│       └── QuestSystem.cs
├── Resources/
│   ├── Data/
│   └── Prefabs/
├── Scenes/
└── Materials/
```

## Technology Stack
- Unity 2022 LTS
- C# for game logic
- Git for version control