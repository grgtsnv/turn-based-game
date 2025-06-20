# ⚔️ Turn-Based Combat Console App in C#

A simple and fun turn-based battle simulator in the console! Built with C#, this app lets a player fight against an enemy mage in a loop of attacks and healing actions until one unit falls. 🎮🧙

## 📋 Description

This is a basic console application that demonstrates object-oriented programming, control flow, and random decision-making. The player and the enemy take turns choosing actions (attack or heal). The game ends when either the player or the enemy's health reaches zero.

## 🧠 How It Works

- The **Player** and **Enemy Mage** start with different HP, attack power, and defense stats.
- On each turn, the player can:
  - **Attack** (`a`) – deal damage based on stats
  - **Heal** – restore a portion of HP
- The **Enemy** chooses randomly to attack or heal.
- The game ends when one unit is defeated (HP ≤ 0).

## 🎯 Features

- ✅ Turn-based combat system  
- 💥 Attack and healing mechanics  
- 🧮 Basic stats: HP, attack, defense  
- 🎲 Random enemy actions  
- 🚫 Ends when one unit dies

## 🕹️ Sample Gameplay

```
Player HP = 100. Enemy Mage HP = 75
Player turn! What will you do?
a
You attack Enemy Mage for 13 damage!
Player HP = 100. Enemy Mage HP = 62
Enemy's turn!
Enemy Mage heals for 5 HP.
...
```

## 🛠️ How to Run

1. **Clone the repository**  
   ```bash
   git clone https://github.com/your-username/turn-based-combat.git
   ```

2. **Navigate to the project directory**  
   ```bash
   cd turn-based-combat
   ```

3. **Run the app**  
   ```bash
   dotnet run
