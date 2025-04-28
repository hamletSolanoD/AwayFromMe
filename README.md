# 🎮 Away From Me: Nightmare Simulator

![Status](https://img.shields.io/badge/Status-Completed-green)
![Engine](https://img.shields.io/badge/Engine-Unity-blue)
![Platform](https://img.shields.io/badge/Platform-Windows-green)
![Language](https://img.shields.io/badge/Language-C%23-purple)

## 💭 Development Story

"Away From Me" emerged during a 2020 pandemic Hackathon, completed in an intense development marathon of just 2 days and one night. As the lead programmer and level editor, my challenge was to integrate the work of all team members into a coherent and functional horror experience.

This game represents an early version of a broader psychological horror concept, where the player navigates through the corners of their own mind, facing nightmares that progressively intensify. A standout technical feature is the procedural room generation, ensuring a unique experience with each playthrough.

## 📸 Technical Showcase
![image](https://github.com/user-attachments/assets/7109c94f-c294-4c39-a664-12a7425a8dd7)
![image](https://github.com/user-attachments/assets/5e5e367f-46be-4469-8591-79c2890a45e0)
![image](https://github.com/user-attachments/assets/67e53cfc-d91d-4a3b-9c90-0a61601f897d)
![image](https://github.com/user-attachments/assets/93b8c60a-c353-43f8-89af-b3f7d11366d6)
![image](https://github.com/user-attachments/assets/e71a69d6-8048-4eff-be24-df52f258e0ce)



*The gameplay shows first-person navigation through procedurally generated labyrinths with a dynamic lighting system.*
### 🎮 [Watch Full Gameplay](https://www.youtube.com/watch?v=ccb8xPMYGmk)

## ✨ Key Features

- 🌓 **Day and Night System**: During nighttime, visibility drastically reduces and enemies become more aggressive, adding a strategic layer to gameplay.

- 🔦 **Flashlight Combat**: Your only weapon is a flashlight with limited energy, forcing resource management and unique survival strategies.

- 🧠 **Activatable Safe Zones**: Mechanism to activate safe areas that eliminate nearby enemies and provide temporary refuge through emerging walls.

- 🗺️ **Dynamic Minimap**: Real-time tracking system showing player position, enemies, objectives, and safe zones.

- 🧩 **Procedural Level Generation**: Each level is generated using a unique seed, ensuring that each playthrough offers a different gaming experience.

- 👻 **Custom Phobias**: Face enemies representing different phobias: ghosts, killer clowns, giant spiders, and more.

## 🔬 Technical Deep Dive

### Procedural Generation System

The heart of the game is a three-dimensional generation system that creates complex mazes with multiple floors. The modular architecture distinguishes between rooms and corridors, each with its own orientation and characteristics. Progressive difficulty is automatically managed through five levels (0-4) that determine:
- Number and type of enemies
- Distribution of rewards
- Presence of special elements

The system intelligently analyzes spatial relationships between rooms to generate walls and doors coherently, creating a navigable yet challenging structure.

### Advanced Safe Zones

Safety zones represent an innovative defensive system with:
- Dynamic enemy detection through trigger events
- Emerging walls in four cardinal directions
- Dual timer system for activation and recharge
- Environmental visual effects (intensified fog)
- Automatic elimination of enemies within the perimeter

### Enemy Artificial Intelligence

Each enemy features AI that manages four distinct states:
- **Tracking mode**: Direct pursuit of the player using NavMesh
- **Attack mode**: Includes "screamers" that position themselves in front of the camera
- **Surveillance mode**: Random patrols in the assigned territory
- **Evasion mode**: Specific behaviors when attacked with the flashlight

The specialized enemy hierarchy includes unique behaviors such as the Clown that creates temporary clones and the Skull that alternates between quick charges and teleportation.

## 💻 Core Systems

### Player System

- First-person control with integrated health and stamina management
- Combat mechanics through flashlight that detects enemies with Physics.SphereCast
- Power-up collection system to improve speed, energy, and health
- Dynamic energy resource management affecting light intensity

### Day-Night System

The temporal cycle completely modifies the gaming experience:
- Reduces visibility at night, limiting 3D view and minimap
- Increases enemy aggressiveness and danger
- Synchronizes fog effects with temporal states
- Adds environmental signaling through gradual lighting changes

### Enemy and Spawner System

- Contextual spawners that generate adversaries according to the difficulty of each room
- Timed respawn mechanism to maintain pressure on the player
- Gradual damage system by proximity, without requiring direct contact
- Integration with the day-night cycle that alters detection and pursuit patterns

## 🌱 Development Team

- **Hamlet Solano**: Lead programmer and level editor
- **Christian Kortright**: 2D and 3D Designer
- **Denzel Gonzalez**: 2D and 3D Designer
- **Lorenzo Varela**: Main designer of level 3 and enemy mechanics
- **Pablo Lopez**: Main designer of level 2 and Boss enemy mechanics

## 🎮 Controls

| Key | Function |
|-------|---------|
| WASD | Movement |
| Left Click / Ctrl | Activate flashlight |
| Q | Activate safe zones |
| Shift | Run |
| Space | Jump (not recommended) |

## 🚀 Play Now

[Download "Away From Me" on itch.io](https://christian-kortright.itch.io/indiesmx-awayfromme)

---

```
            ███████████████████████████
            ███████▀▀▀░░░░░░░▀▀▀███████
            ████▀░░░░░░░░░░░░░░░░░▀████
            ███│░░░░░░░░░░░░░░░░░░░│███
            ██▌│░░░░░░░░░░░░░░░░░░░│▐██
            ██░└┐░░░░░░░░░░░░░░░░░┌┘░██
            ██░░└┐░░░░░░░░░░░░░░░┌┘░░██
            ██░░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░██
            ██▌░│██████▌░░░▐██████│░▐██
            ███░│▐███▀▀░░▄░░▀▀███▌│░███
            ██▀─┘░░░░░░░▐█▌░░░░░░░└─▀██
            ██▄░░░▄▄▄▓░░▀█▀░░▓▄▄▄░░░▄██
            ████▄─┘██▌░░░░░░░▐██└─▄████
            █████░░▐█─┬┬┬┬┬┬┬─█▌░░█████
            ████▌░░░▀┬┼┼┼┼┼┼┼┬▀░░░▐████
            █████▄░░░└┴┴┴┴┴┴┴┘░░░▄█████
            ███████▄░░░░░░░░░░░▄███████
            ██████████▄▄▄▄▄▄▄██████████
            ███████████████████████████
         AWAY FROM ME - NIGHTMARE SIMULATOR
```

*This game was developed during a Hackathon in the 2020 pandemic. An intense look into the terrors of the human mind.*
