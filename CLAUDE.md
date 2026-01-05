# CLAUDE.md - SoftwareHero Development Protocol

> Guidelines for Claude when working on this game codebase.

---

## Project Overview

2D simulation game about the journey to becoming a legendary software developer. Windows-only desktop game sharing engine components with BadmintonHero and FatChampion.

---

## Related Projects

This game is part of a family of 2D simulation games:
- **BadmintonHero** - Badminton career simulation
- **FatChampion** - Weight loss journey simulation
- **SoftwareHero** - Software developer career simulation

When making architectural decisions, consider reusability across all three games.

---

## Architecture

- **SoftwareHero.Core** - Platform-independent game logic
  - Entities, components, systems
  - Game state, rules, AI
  - Simulation engine (shareable with sibling projects)
  - No rendering or input code

- **SoftwareHero** - Platform layer (Windows)
  - Rendering, sprites, audio
  - Input handling
  - Game loop integration

- **SoftwareHero.Benchmark** - Performance testing

---

## Workflow

1. **Understand** - Read existing code and game design before changing
2. **Plan** - Propose changes for approval
3. **Implement** - Keep changes minimal and focused
4. **Validate** - Build, test, and playtest

---

## Rules

### DO:
- Keep Core free of rendering/platform dependencies
- Design Core components for reuse across sibling games
- Test game logic in Core with unit tests
- Keep rendering code separate from game logic
- Use explicit state machines for game states
- Target Windows desktop only

### DON'T:
- Mix rendering with game logic
- Add dependencies without approval
- Make sweeping changes without a plan
- Ignore performance in hot paths
- Add mobile/web compatibility concerns

---

## Commands

```bash
dotnet build          # Build all
dotnet test           # Run tests
dotnet run --project SoftwareHero  # Run game
```
