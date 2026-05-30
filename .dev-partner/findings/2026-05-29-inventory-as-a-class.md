---
title: Consider using a class for the inventory
date: 2026-05-29
tags: [design, object-oriented, csharp]
type: pattern
project: DapperBanana/OnceMoreUntoTheBreach
---

The current inventory is implemented using basic lists. As the game grows, consider encapsulating this into an `Inventory` class. This would allow adding inventory-specific methods, like `AddItem`, `RemoveItem`, `HasItem`, and enforce constraints (max items, item types) within the class.  It provides a single, well-defined interface for interacting with the player's inventory.
