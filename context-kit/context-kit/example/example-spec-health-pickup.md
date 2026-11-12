# Spec: Health pickup

## Goal
Give the player a reason to take risks: a heart that heals one hit, placed where it's dangerous to reach.

## Acceptance criteria
1. Touching a heart heals the player by 1 HP. The amount lives in a config asset, not in code.
2. The heart disappears when it's picked up and doesn't come back.
3. Only the player can pick it up. Enemies pass over it.
4. The health bar updates through Health.Changed. The pickup never touches the UI.

## Edge cases
- Player at full health: nothing happens, and the heart stays.
- Player is dead: nothing happens.
- Two hearts touched in the same frame: each heals 1, up to the maximum.

## Examples
- 3/5 HP, touch a heart: 4/5, the heart is gone.
- 5/5 HP, touch a heart: still 5/5, the heart is still there.

## Out of scope
Respawning hearts, animation, sound, particles. They're later backlog items.
