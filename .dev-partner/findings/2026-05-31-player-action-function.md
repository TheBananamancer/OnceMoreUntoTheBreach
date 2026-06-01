---
title: Encapsulate player action logic in a function
date: 2026-05-31
tags: [refactoring, modularity]
type: pattern
project: DapperBanana/OnceMoreUntoTheBreach
---

The commit refactors the main game loop to extract the player action logic into a separate function. This significantly improves the readability and maintainability of the main loop. By isolating the input processing and action execution, it becomes easier to add new actions or modify existing ones without affecting the core game loop structure. This also sets the stage for potentially implementing more sophisticated action handling mechanisms later, such as command patterns or scripting.
