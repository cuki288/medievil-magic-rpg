# Medievil Magic RPG

A medieval fantasy RPG game built with Unity. This project implements a full RPG experience with character progression, combat systems, quests, and inventory management.

## Project Structure

```
Assets/
├── Scripts/
│   ├── Character/
│   │   ├── Character.cs
│   │   ├── CharacterClass.cs
│   │   ├── Item.cs
│   │   ├── Equipment.cs
│   │   └── Skill.cs
│   ├── Combat/
│   │   └── BattleSystem.cs
│   └── UI/
│       └── CharacterUI.cs
├── Resources/
│   ├── Data/
│   └── Prefabs/
├── Scenes/
└── Materials/
```

## Features Implemented

1. **Character System**
   - Character stats (health, mana, strength, magic, etc.)
   - Character classes (Warrior, Mage, Rogue, Cleric)
   - Equipment and inventory management
   - Level progression and stat scaling

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

5. **Documentation**
   - Complete architecture design
   - API specifications
   - Test plan
   - Release plan

## Development Tools

- Unity 2022 LTS
- C# for game logic
- Git for version control

## Setup Instructions

1. Create a new Unity project
2. Import this codebase into the Assets folder
3. Build and run the game

## Documentation

- `docs/BRIEF.md`: Project overview and goals
- `docs/USER_STORIES.md`: User stories and acceptance criteria
- `docs/RISKS.md`: Risk analysis and mitigation
- `docs/ARCH.md`: System architecture
- `docs/ADR/`: Architecture decision records
- `docs/API.md`: API specifications
- `TEST_PLAN.md`: Testing strategy
- `RELEASE_PLAN.md`: Release planning

## Contributing

This project follows the standard OpenClaw development protocol.