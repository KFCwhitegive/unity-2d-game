
# **Project Name**

## **Introduction**
Welcome to the `Project Name`! This is a collaborative Unity 2D game project developed by Austin, Aki and Jackey. The goal of this project is to create an engaging and fun game while learning and applying game development concepts.

## **Table of Contents**
1. [Getting Started](#getting-started)
2. [Project Structure](#project-structure)
3. [Contributing Guidelines](#contributing-guidelines)
4. [Code Commenting Standards](#code-commenting-standards)
5. [Update and Version Control](#update-and-version-control)
6. [Detailed Change Logs](#detailed-change-logs)
7. [Contacts](#contacts)

## **Getting Started**
### Prerequisites
- Unity Version: [Specify the version you're using, e.g., Unity 2021.3.8f1]
- Git and GitHub account.
- Basic knowledge of Unity 2D development.

### Setup
1. Clone the repository:
    ```bash
    git clone https://github.com/KFCwhitegive/unity-2d-game.git
    ```
2. Open the project in Unity.
3. Ensure all dependencies and assets are properly loaded.

## **Project Structure**
- **Assets/**: Contains all game assets, including scripts, sprites, and audio.
- **Scenes/**: Unity scenes for different levels or menus.
- **Scripts/**: C# scripts for game logic and mechanics.
- **Prefabs/**: Prefabricated game objects for easy reuse.
- **Documentation/**: Contains project documentation and additional resources.

## **Contributing Guidelines**
We welcome contributions to improve this project! Please adhere to the following guidelines:

### Branching
- **main**: Stable and production-ready code.
- **feature/branch-name**: Use this format for adding new features.
- **bugfix/branch-name**: Use this format for fixing bugs.

### Pull Requests
1. Make sure your branch is up to date with `main` before creating a pull request.
2. Provide a clear description of the changes made, why they are necessary, and any potential impact they may have.
3. Request a review from another team member before merging.

## **Code Commenting Standards**
To maintain code readability and ease of collaboration, please follow these commenting guidelines:

### Single-Line Comments
Use `//` to provide context for individual lines of code.
```csharp
// This function handles player movement based on input
```

### Multi-Line Comments
Use `/* ... */` for more detailed explanations, especially for complex logic.
```csharp
/*
 This method calculates the score multiplier
 based on the player's current level and streak.
*/
```

### XML Documentation Comments
For public methods and classes, use XML comments for better auto-documentation.
```csharp
/// <summary>
/// Moves the player to the specified position.
/// </summary>
/// <param name="targetPosition">The position to move the player to.</param>
public void MovePlayer(Vector3 targetPosition) { ... }
```

## **Update and Version Control**
### Regular Updates
- Update the repository frequently to keep everyone up to date.
- Always pull the latest changes from the `main` branch before starting new work.

### Versioning
- We use Semantic Versioning (2022.3.47f1) to track the project's development stage.
- Increment version numbers appropriately:
  - Major version (2022) for significant changes or milestones.
  - Minor version (3) for feature additions.
  - Patch version (47f1) for bug fixes or minor improvements.

## **Detailed Change Logs**
For each commit, provide a detailed message following this format:
1. **Short Summary**: Brief description of the change.
2. **Detailed Explanation**: Elaborate on the changes made, including any new functionality or bug fixes.
3. **Related Issues/Tasks**: Reference any GitHub Issues or Trello tasks.

**Example Commit Message:**
```
Added player health system

- Implemented a health system for the player.
- Added health bar UI to display current health.
- Updated enemy attack script to damage the player.

Closes #15, Task: Add Health System
```

## **Contacts**
For any questions or suggestions, feel free to reach out:
- [Austin] - [austinzhao5404@gmail.com]

