---
title: Sequential Scenario Execution
date: 2026-05-26
tags: [game loop, control flow]
type: pattern
project: DapperBanana/OnceMoreUntoTheBreach
---

The main game loop now executes scenarios sequentially. This is a straightforward control flow pattern suitable for narrative-driven games where the order of events matters. While simple, it can become unwieldy as the number of scenarios grows. Future refactoring might consider a more event-driven or state machine-based approach to scenario management, allowing for non-linear progression or branching narratives based on player choices or game state.
