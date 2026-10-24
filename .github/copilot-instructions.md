# GitHub Copilot Instructions for Torches and Braziers (Continued)

## Mod Overview and Purpose
Torches and Braziers (Continued) is an update and continuation of the Sovereign,Elseuds mod for RimWorld. The mod adds various torches and braziers that are dependent on active mods. It introduces three different kinds of fires and integrates with several other mods for additional functionality.

## Key Features and Systems
- **Royal Braziers**: Activated by the Royalty mod, providing a unique brazier.
- **Biotech Variants**: Adds Blood and Tox variant braziers with Biotech mod.
- **Lag-Free Torches**: Torches that do not require fuel by default but are compatible with fuel.
- **Nephilim Xenotype**: Unlocks the holy flame.
- **Vanilla Expanded Framework**: Adds mood buffs based on genes.
- **Vanilla Factions Expanded - Empire**: Makes braziers compatible with custom royalty titles.
- **Vanilla Races Expanded - Waster**: Provides mood buff.
- **Vanilla Races Expanded - Sanguophage**: Provides mood buff.

## Coding Patterns and Conventions
- **C# Files**: Two C# files are included in the mod.
  - `CompSanguophageMeetingFire.cs`: Contains the `CompSanguophageMeetingFire` class with members such as `Building`, `CompPreventClaimingBy`, `PostDraw`, and `Props`.
  - `CompProperties_SanguophageMeetingFire.cs`: Contains the `CompProperties_SanguophageMeetingFire` class.

- **XML Files**: Eight XML files define various aspects of the mod.
  - `Designators.xml`: Contains `DesignatorDropdownGroupDef`.
  - `Thoughts.xml`: Contains `ThoughtDef`.
  - `TorchBase.xml`: Contains `minifiedDef`, `statDef`, and `ThingDef`.
  - `TorchNew.xml`: Contains `ThingDef`.

## XML Integration
The mod uses XML to define various elements such as designs, thoughts, and torch definitions. Each XML file plays a crucial role in defining the properties and behaviors of the mod's features.

## Harmony Patching
Harmony patching is not explicitly mentioned in the provided summary, but it is a common practice in RimWorld modding. Harmony allows for modifying existing game code without altering the original files, enabling the integration of new features and behaviors seamlessly.

## Suggestions for Copilot
To enhance the modding experience with GitHub Copilot, here are some suggestions:

1. **XML Definition Templates**: Create templates for common XML definitions such as `ThingDef`, `DesignatorDropdownGroupDef`, and `ThoughtDef` to help with quick setup and error reduction.

2. **C# Class Templates**: Develop templates for C# classes like `CompSanguophageMeetingFire` and `CompProperties_SanguophageMeetingFire` to ensure consistency and efficiency in coding.

3. **Integration Snippets**: Provide snippets for integrating with other mods (e.g., Vanilla Expanded Framework, Vanilla Factions Expanded - Empire) to assist with mod compatibility and functionality.

4. **Debugging and Error Handling**: Include snippets for logging and error reporting to help with debugging and maintaining the mod.

5. **Documentation and Examples**: Offer documentation and examples for common tasks, such as creating new torches and braziers, to assist developers in understanding and implementing new features.

By following these guidelines, Copilot can be a valuable tool for modding in RimWorld, enhancing productivity and reducing errors.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

