# SoftwareHero

2D simulation game about the journey to becoming a legendary software developer.

## Status

**Dormant**

## Overview

A Windows-only 2D simulation game where players experience the journey of becoming a successful software developer. Part of a shared game engine family with BadmintonHero and FatChampion.

### Game Concept

- Career progression from junior to legend
- Coding challenges, project decisions, and skill development
- Tech industry simulation with realistic scenarios

## Related Projects

| Game | Theme | Description |
|------|-------|-------------|
| BadmintonHero | Badminton | Journey to badminton championship |
| FatChampion | Weight Loss | Journey to health and fitness |
| **SoftwareHero** | Software Dev | Journey to becoming a dev legend |

These games share:
- Common 2D graphical style
- Core simulation engine components
- Windows desktop platform target

## Architecture

```
SoftwareHero/              # Main game/platform code
SoftwareHero.Core/         # Game logic, entities, systems (platform-independent)
SoftwareHero.Benchmark/    # Performance benchmarks
```

**Note:** Project uses flat structure rather than src/tests/ directories.

## Getting Started

### Prerequisites

- .NET 10 SDK
- Game engine TBD (MonoGame, Raylib, etc.)

### Build

```bash
dotnet build
```

### Run

```bash
dotnet run --project SoftwareHero
```

### Test

```bash
dotnet test
```

## Development

See [CLAUDE.md](CLAUDE.md) for development guidelines.
