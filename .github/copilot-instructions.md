# GitHub Copilot Instructions for Torches and Braziers (Continued)

## Mod Overview and Purpose

**Torches and Braziers (Continued)** is a mod for RimWorld that expands the game's lighting options by adding various torches and braziers. It enhances the aesthetic and functional aspects of lighting depending on other active mods. The mod aims to provide players with diverse options for illuminating their colonies while integrating seamlessly with other popular RimWorld mods.

## Key Features and Systems

- **Multiple Fire Variants**: The mod introduces three different types of fires, each catering to different gameplay or thematic needs. 
- **Mod Integrations**:
  - **Royalty DLC**: Introduces a Royal Brazier for enhancing the royal gameplay experience.
  - **Biotech DLC**: Adds the Blood & Tox variant for a thematic complement to biotech-themed gameplay.
  - **Nephilim Xenotype**: Unlocks a unique "Holy Flame" variant for players using this xenotype.
- **Lag-Free Implementation**: Torches and braziers do not require fuel by default, ensuring minimal performance impact.
- **Mood Buff Mechanics**: Integrated with the Vanilla Expanded Framework, the mod provides mood buffs based on the colonists' genes, with specific interactions for:
  - **Vanilla Factions Expanded - Empire**
  - **Vanilla Races Expanded - Waster**
  - **Vanilla Races Expanded - Sanguophage**

## Coding Patterns and Conventions

- **Class Naming**: Employs descriptive nouns that reflect the function or purpose of the class, such as `CompProperties_SanguophageMeetingFire` and `CompSanguophageMeetingFire`.
- **Method Structure**: Methods within these classes adhere to clear and purposeful naming, following the pattern of action-focused verbs.
- **Modular Code**: Ensures each component is self-contained and purpose-driven, maintaining a single responsibility wherever possible.

## XML Integration

- XML is utilized to define various properties and settings for the torches and braziers, allowing for easy customization and integration with RimWorld's modding environment.
- Configuration files include definitions for new objects, mood buffs, and integration triggers with other DLCs and mods.

## Harmony Patching

- Harmony is employed to apply patches that extend or modify the behavior of the base game, ensuring compatibility with other mods and enhancing functionality.
- Patches focus on adding new behaviors when specific conditions, such as the presence of a certain mod, are met.

## Suggestions for Copilot

1. **Class and Method Complementation**: When generating code, ensure consistency with existing class and method patterns. Leverage action verbs for methods and nouns for classes.
2. **XML Snippets**: Provide examples or skeletons for XML definitions used to integrate or modify existing game features.
3. **Patch Modularity**: Suggest maintaining a separation of concern by modularizing Harmony patches, ensuring each patch targets a specific aspect of the game.
4. **Error Handling Code**: Recommend implementing try-catch blocks where applicable, especially in areas interacting directly with interfaces or complex integrations.
5. **Descriptive Comments**: Encourage inline comments that describe the purpose and functionality of complex code blocks to enhance readability and maintainability.

By adhering to the above guidelines, GitHub Copilot will be more effective in aiding the development and expansion of the Torches and Braziers mod for RimWorld, ensuring smooth integration with various DLCs and popular mods.
