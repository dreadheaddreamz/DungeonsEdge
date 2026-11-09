# ⚔️ Dungeons Edge

**A turn-based RPG built with C# and .NET.**

Dungeons Edge is a console-based RPG project I'm building to strengthen my C# skills and explore object-oriented programming through hands-on development.

The goal is to build a small but expandable RPG featuring different character classes, unique abilities, and a turn-based combat system.

---

## 🎮 Current Features

- **Object-Oriented Design** – Uses classes, inheritance, properties, constructors, and method overriding.
- **Player Base Class** – Shared character attributes and damage handling.
- **Unique Character Classes** – Each class has its own stats and abilities.
- **Character Abilities** – Abilities consume resources and return damage values.
- **Damage Handling** – Character-specific damage behavior through method overriding.

## 🛡️ Character Classes

| Class | Starting Health | Special Resource | Ability |
|---|---:|---:|---|
| Tank | 300 | 100 Armor | Shield Bash |
| Mage | 200 | 100 Mana | Fireball |
| Rogue | 200 | 50 Stealth | Backstab |

### Character Abilities

- **Tank – Shield Bash:** Deals 20 damage. Armor reduces incoming damage.
- **Mage – Fireball:** Deals 40 damage and consumes 15 Mana.
- **Rogue – Backstab:** Deals 30 damage and consumes 10 Stealth.

## 🧰 Tech Stack

- C#
- .NET
- Visual Studio Code
- Git & GitHub

## 🚀 Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://code.visualstudio.com/)

### Run Locally

1. Clone the repository:

   ```bash
   git clone https://github.com/dreadheaddreamz/DungeonsEdge.git
   ```

2. Navigate into the project directory:

   ```bash
   cd DungeonsEdge
   ```

3. Run the application:

   ```bash
   dotnet run
   ```

## 📁 Project Structure

```text
DungeonsEdge/
│
├── Characters/
│   ├── Character.cs
│   ├── Player.cs
│   ├── Tank.cs
│   ├── Mage.cs
│   └── Rogue.cs
│
├── Enemies/
│   ├── Enemy.cs
│   ├── GobGuardian.cs
│   ├── GobNecro.cs
│   └── GobWarrior.cs
│
├── Combat/
│   └── Combat.cs
│
├── Program.cs
└── DungeonsEdge.csproj
```

## 🗺️ Roadmap

- [x] Create the Player base class
- [x] Implement Tank class
- [x] Implement Mage class
- [x] Implement Rogue class
- [x] Add character-specific abilities
- [ ] Build the turn-based combat system
- [ ] Implement enemy classes
- [ ] Add player and enemy turns
- [ ] Introduce character progression and leveling
- [ ] Add inventory and equipment
- [ ] Build a playable game loop

---

## 🎯 Project Goal

This project is an opportunity to learn by building rather than just following tutorials. I'm using it to practice writing clean C# code, understanding object-oriented programming, and gradually building a more complete application.

**More adventures to come.**# ⚔️ Dungeons Edge

**A turn-based RPG built with C# and .NET.**

Dungeons Edge is a console-based RPG project I'm building to strengthen my C# skills and explore object-oriented programming through hands-on development.

The goal is to build a small but expandable RPG featuring different character classes, unique abilities, and a turn-based combat system.

---

## 🎮 Current Features

- **Object-Oriented Design** – Uses classes, inheritance, properties, constructors, and method overriding.
- **Player Base Class** – Shared character attributes and damage handling.
- **Unique Character Classes** – Each class has its own stats and abilities.
- **Character Abilities** – Abilities consume resources and return damage values.
- **Damage Handling** – Character-specific damage behavior through method overriding.

## 🛡️ Character Classes

| Class | Starting Health | Special Resource | Ability |
|---|---:|---:|---|
| Tank | 300 | 100 Armor | Shield Bash |
| Mage | 200 | 100 Mana | Fireball |
| Rogue | 200 | 50 Stealth | Backstab |

### Character Abilities

- **Tank – Shield Bash:** Deals 20 damage. Armor reduces incoming damage.
- **Mage – Fireball:** Deals 40 damage and consumes 15 Mana.
- **Rogue – Backstab:** Deals 30 damage and consumes 10 Stealth.

## 🧰 Tech Stack

- C#
- .NET
- Visual Studio Code
- Git & GitHub

## 🚀 Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://code.visualstudio.com/)

### Run Locally

1. Clone the repository:

   ```bash
   git clone https://github.com/dreadheaddreamz/DungeonsEdge.git
   ```

2. Navigate into the project directory:

   ```bash
   cd DungeonsEdge
   ```

3. Run the application:

   ```bash
   dotnet run
   ```

## 📁 Project Structure

```text
DungeonsEdge/
├── Program.cs
├── Player.cs
├── Tank.cs
├── Mage.cs
├── Rogue.cs
└── DungeonsEdge.csproj
```

## 🗺️ Roadmap

- [x] Create the Player base class
- [x] Implement Tank class
- [x] Implement Mage class
- [x] Implement Rogue class
- [x] Add character-specific abilities
- [ ] Build the turn-based combat system
- [ ] Implement enemy classes
- [ ] Add player and enemy turns
- [ ] Introduce character progression and leveling
- [ ] Add inventory and equipment
- [ ] Build a playable game loop

---

## 🎯 Project Goal

This project is an opportunity to learn by building rather than just following tutorials. I'm using it to practice writing clean C# code, understanding object-oriented programming, and gradually building a more complete application.

**More adventures to come.**
