# CLAUDE.md - SoftwareHero Development Protocol

> Guidelines for Claude when working on this game codebase.

---

## Project Overview

<!-- One-line description of the game -->

---

## Architecture

- **SoftwareHero.Core** - Platform-independent game logic
  - Entities, components, systems
  - Game state, rules, AI
  - No rendering or input code

- **SoftwareHero** - MonoGame platform layer
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
- Keep Core free of MonoGame dependencies
- Test game logic in Core with unit tests
- Keep rendering code separate from game logic
- Use explicit state machines for game states

### DON'T:
- Mix rendering with game logic
- Add dependencies without approval
- Make sweeping changes without a plan
- Ignore performance in hot paths

---

## Commands

```bash
dotnet build          # Build all
dotnet test           # Run tests
dotnet run --project SoftwareHero  # Run game
```
