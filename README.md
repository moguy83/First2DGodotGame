# FirstGodotGame
## 🕹️ 2D Platformer Game (Godot 4.x, C#)

A simple but polished 2D platformer made in **Godot 4** using **C#**, originally based on the [Brackeys YouTube tutorial](https://www.youtube.com/watch?v=LOhfqjmasi0), and extended with original features and improvements. Built as a personal learning project and portfolio piece.

![Screenshot](screenshots/gameplay.png)

---

## 🎯 Features

- 2D platformer character controller (movement & jump)
- Collectable coins with sound and UI counter
- Game win and game over states
- UI menus (HUD, pause, level complete)
- Parallax background
- Sound effects and background music
- Hazard collisions and level reset
- Modular scene structure using Godot's node system
- Entirely coded in C# (Godot .NET)

---

## 🛠 Tech Stack

- **Engine**: [Godot 4.x (C#)](https://godotengine.org/download/windows/)
- **Language**: C# (.NET 6+ compatible)
- **Tools**: Visual Studio / VS Code, Git
- **Target Platforms**: Desktop (Windows), Web (HTML5)

---

## 📁 Project Structure

<pre>
├── Scenes/
│   ├── Player.tscn
│   ├── Coin.tscn
│   ├── Level1.tscn
│   └── UI/
│       ├── HUD.tscn
│       └── MainMenu.tscn
│
├── Scripts/
│   ├── Player.cs
│   ├── Coin.cs
│   ├── GameManager.cs
│   └── UIManager.cs
│
├── assets/
│   ├── sprites/
│   ├── audio/
│   ├── tiles/
│   └── fonts/
│
├── screenshots/
│   └── gameplay.png
│
├── project.godot
└── README.md
</pre>

---

## 🚀 Getting Started

### Requirements

- [Godot 4.x (C# version)](https://godotengine.org/download/windows/)
- [.NET SDK 6.0 or newer](https://dotnet.microsoft.com/en-us/download)

### Run the Game

1. Clone or download this repo.
2. Open the project in **Godot 4 (C#)**.
3. Press **Play** to launch the main scene.

---

## 🎓 Roadmap

| Feature                         | Status         | Priority | ETA    | Notes                                 |
|---------------------------------|----------------|----------|--------|---------------------------------------|
| Core movement + jumping         | ✅ Done        | Low      | —      | Base tutorial implementation          |
| Coin collection + SFX           | ✅ Done        | Low      | —      | Fully functional                      |
| Win & Game Over screens         | 🟡 In Progress | High     | 1 day  | Polish UI transitions & animations    |
| Enemy AI & Hazards              | 🟡 In Progress | High     | 3 days | Patrol, chase, damage feedback        |
| Level transitions & selection   | 🟡 In Progress | Medium   | 2 days | Hub scene + unlock logic              |
| Power‑ups (double jump, dash)   | ⬜ Planned     | Medium   | 1 wk   | Add gameplay depth                    |
| Multiple levels + difficulty    | ⬜ Planned     | Medium   | 1 wk   | Design and balance 3 unique levels    |
| UI Settings (audio, controls)   | ⬜ Planned     | Medium   | 2 days | Settings menu + persistence           |
| Save system & high scores       | ⬜ Planned     | Medium   | 2 days | JSON save file for progress & scores  |
| VFX & particle effects          | ⬜ Planned     | Low      | 3 days | Jump dust, coin pickup, damage FX     |
| Audio settings & soundtrack     | ⬜ Planned     | Low      | 2 days | Background music + volume controls    |
| Export builds & deploy          | ⬜ Planned     | High     | 1 day  | HTML5 + desktop builds → Itch.io      |
| Documentation & portfolio       | ⬜ Planned     | Medium   | 3 days | README updates + dev diary            |

## 🧩 Feature Breakdown

### Core movement + jumping
- Implement basic horizontal movement using `Input.GetActionStrength`.
- Add a jump mechanic with a configurable jump height.
- Use a `RayCast2D` to check for ground collision before allowing jumps.

### Coin collection + SFX
- Add an `Area2D` node to coins for detection.
- Play a sound effect when a coin is collected.
- Update a UI counter in the HUD when coins are picked up.

### Win & Game Over screens
- Create separate scenes for Win and Game Over screens.
- Add buttons for "Retry" and "Main Menu" navigation.
- Trigger these screens based on game state (e.g., all coins collected or player death).

### Enemy AI & Hazards
- Use a `Path2D` for enemy patrol routes.
- Add a `KinematicBody2D` for enemies with basic chase behavior.
- Implement damage feedback (e.g., flashing sprite or knockback).

### Level transitions & selection
- Create a hub scene with level selection buttons.
- Use `PackedScene` to load levels dynamically.
- Add logic to unlock levels after completing the previous one.

### Power-ups (double jump, dash)
- Add a `PowerUp` node with a trigger area.
- Implement double jump by tracking jump count.
- Add a dash mechanic with a cooldown timer.

### Multiple levels + difficulty
- Design 3 levels with increasing difficulty.
- Use different tilemaps and hazards for variety.
- Balance enemy placement and coin distribution.

### UI Settings (audio, controls)
- Create a settings menu with sliders for audio volume.
- Add keybinding options for controls.
- Save settings using `File` or `ConfigFile`.

### Save system & high scores
- Use JSON to save player progress and high scores.
- Load saved data on game start.
- Display high scores in the main menu.

### VFX & particle effects
- Add a `Particles2D` node for jump dust and coin pickup effects.
- Use animated sprites for damage feedback.
- Create simple shaders for visual polish.

### Audio settings & soundtrack
- Add background music to levels.
- Use an `AudioStreamPlayer` for sound effects.
- Implement volume controls in the settings menu.

### Export builds & deploy
- Export the game as an HTML5 build.
- Test the build in a browser for compatibility.
- Deploy the game to Itch.io or similar platforms.

### Documentation & portfolio
- Write a development diary in the README.
- Add GIFs or videos showcasing gameplay.
- Include links to the deployed game and source code.

---

## 📸 Screenshots

> Todo : Add `.png` screenshots to the `/screenshots/` folder and link them here:
- Gameplay
- Menus
- Effects

---

## 📚 Learning Resources

- [Brackeys Tutorial (Godot 4 C#)](https://www.youtube.com/watch?v=LOhfqjmasi0)
- [Godot C# Docs](https://docs.godotengine.org/en/stable/tutorials/scripting/c_sharp/)
- [GDScript vs C# in Godot](https://docs.godotengine.org/en/stable/tutorials/scripting/c_sharp/c_sharp_differences.html)

---

## 📜 License

This project is released under the **MIT License**. See `LICENSE` file for details.  
**Note**: Some assets may have their own licenses. Check the `/assets` folder.
