# CLAUDE.md — SoftwareHero

<!-- AUTO-GENERATED: Do not edit directly. Modify CLAUDE.project.md instead. -->
<!-- Template: archived | Generated: 2026-01-05 -->

> ⚠️ **ARCHIVED PROJECT** - This project is no longer actively maintained.

## Project Overview

2D simulation game about a software developer career. Windows desktop.

## Related Projects

Part of a family of 2D simulation games:
- BadmintonHero - Badminton career simulation
- FatChampion - Weight loss journey simulation
- SoftwareHero - Software developer career simulation

## Architecture

- **SoftwareHero.Core** - Platform-independent game logic
- **SoftwareHero.Game** - Platform layer (Windows)

## Status

Archived - no longer actively maintained.

---

## Plans & Reference Materials

### Plans Workflow

All implementation plans follow this lifecycle:

1. **Create**: `.claude/plans/<description>-<YYYYMMDD>.md`
2. **Execute**: Update task checkboxes as work progresses
3. **Complete**: Add completion summary
4. **Archive**: Move to `.claude/plans/archive/`

### Reference Materials

When implementing features, consult:
- `reference/design/` — Architecture diagrams, UI mockups, specs
- `reference/code/` — Code samples, patterns from other projects

---

## CRITICAL: File Editing on Windows

### ⚠️ MANDATORY: Always Use Backslashes on Windows for File Paths

**When using Edit or MultiEdit tools on Windows, you MUST use backslashes (`\`) in file paths, NOT forward slashes (`/`).**

#### ❌ WRONG - Will cause errors:
```
Edit(file_path: "D:/repos/project/file.tsx", ...)
MultiEdit(file_path: "D:/repos/project/file.tsx", ...)
```

#### ✅ CORRECT - Always works:
```
Edit(file_path: "D:\repos\project\file.tsx", ...)
MultiEdit(file_path: "D:\repos\project\file.tsx", ...)
```
