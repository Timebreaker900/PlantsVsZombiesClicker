## Pants vs Zombies Bungee Zombie Clicker

An automation tool to exploit the Bungee Zombie bug in [Plants vs. Zombies GOTY Edition](https://store.steampowered.com/app/3590/Plants_vs_Zombies_GOTY_Edition/) on Windows. This utility records two screen positions (the flower and the bungee zombie spawn) and then automates clicks to repeatedly trigger the glitch.

<hr>

### 📦 Releases
Download the latest executable from the Releases page.

<hr>

### ⚙️ Prerequisites

- Operating System: Windows 10 or later
- .NET Runtime: .NET 6.0 Runtime or newer (if running from source)


<hr>


### 🚀 Installation

1. Using the Prebuilt Executable
   1. Go to the Releases page.
   2. Download the latest PvZBungeeClicker.exe.
   3. Place it anywhere on your system and double-click to launch.

2. Building from Source
    ```
    # Clone the repo
   git clone https://github.com/<your-user>/pvz-bungee-clicker.git
   cd pvz-bungee-clicker

    # Restore and publish as self-contained Windows exe
    dotnet publish -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true

    # The EXE will be under:
    # bin/Release/net6.0/win-x64/publish/PvZBungeeClicker.exe
   ```
   <hr>

### ▶️ Usage

1. Launch PvZBungeeClicker.exe.
2. Move your mouse over the flower in-game and press ENTER to record its position.
3. Hover over the incoming bungee zombie and press ENTER to record that position.
4. Press ENTER again to start; the program will begin automatically clicking the two spots in sequence.
5. Press ESC at any time to exit.

<hr>

### 📝 Documentation

All documentation lives in this repository. Feel free to open issues or pull requests if anything is unclear.

<hr>

### 📄 License

This project is licensed under the MIT License – see the LICENSE file for details.