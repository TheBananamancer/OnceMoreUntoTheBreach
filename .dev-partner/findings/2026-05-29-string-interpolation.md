---
title: Use string interpolation for readability
date: 2026-05-29
tags: [clarity, readability, csharp]
type: technique
project: DapperBanana/OnceMoreUntoTheBreach
---

String concatenation with the `+` operator works, but using C#'s string interpolation (`$``) often makes the code more readable, especially when building strings with multiple variables. It clearly separates fixed strings from variable names.  Switching to interpolation can reduce errors and improve maintainability.
