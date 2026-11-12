# Spec — 2.5D movement and jumping

## Goal

Give Token precise control on foot and in the air so crossing gaps and lining up landings feels deliberate. This supports the traversal part of the core loop in [HLD.md](../HLD.md).

## Acceptance criteria

Use a placeholder floor with room to move, a side-on orthographic test view, and a marked starting point. Start each ground test at rest. The first-pass targets are 5 Unity units per second on the ground and a 1.5-unit jump. Review both in Play Mode.

1. Hold D for 1 second on flat ground. Token moves 5 units right, within 0.5 units. Repeat from the start with A and get the same distance left.
2. Release the movement key while on flat ground. Token stops within 0.25 units of the release point.
3. Tap Space from rest on flat ground. Token rises 1.5 units above his starting position, within 0.15 units, and lands back on the floor.
4. Jump while moving right. Before landing, release D and hold A. Token starts moving left before touching the floor.
5. Run and jump using A, D, and Space. Token stays within 0.01 units of his starting depth. From rest, holding W or S for 1 second causes no movement.

## Edge cases

- If A and D are held together on flat ground, their inputs cancel.
- A fresh Space press in midair gives no extra jump. Holding Space through landing gives one jump per press.
- Walking off an edge makes Token fall. He can still steer in the air and can jump again after landing.

## Examples

- Token starts at horizontal position 0. Hold D for 1 second. He ends between 4.5 and 5.5 units to the right at the same depth.
- Token jumps while moving right. Switch from D to A near the top of the jump. He travels left before landing.

## Out of scope

Camera follow and framing, hook movement, combat, animation, and checkpoint behavior. The test camera only needs to show the movement clearly.

## Context for the agent

Read the movement Must in [Backlog.md](../Backlog.md). Use the new Input System. For this prototype, A and D are the on-foot movement inputs and Space jumps. W and S are reserved for later interactions.
