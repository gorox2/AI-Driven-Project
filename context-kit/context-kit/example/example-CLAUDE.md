# Ember Arena: notes for the agent

## Project
- Unity 6.3 LTS (6000.3), Universal 2D template, Input System only (the old Input Manager is off).
- Solo student project. The agent writes the code; I review it, test it in Play Mode and commit it.
- Design: Docs/HLD.md. Backlog: Docs/Backlog.md. Feature specs: Docs/Specs/.

## Architecture
- Game code lives in Assets/_Game/Scripts/<Area>/ with the namespace EmberArena.<Area>.
- Every gameplay number lives in a ScriptableObject config in Assets/_Game/Config/ (PlayerConfig, HealthConfig, ...). A MonoBehaviour references its config. No tuning numbers in [SerializeField] fields on MonoBehaviours.
- Health.cs is the only place HP changes: TakeDamage(int) and Heal(int). The player and enemies both have Health.
- Game code never references UI. UI listens to events such as Health.Changed.

## Conventions
- Recognise the player by its component: TryGetComponent<PlayerController>(). Never by tag or name.
- No singletons and no FindFirstObjectByType or other Find* calls at runtime. Get references from the Inspector or from the collision.
- Coin.cs and ScoreKeeper.cs are old style (tag check, Find, a number on the component). Don't copy them.

## Verified API notes (Unity 6.3 Scripting API, checked 2026-11-08)
- Rigidbody2D.linearVelocity, not velocity. linearDamping, not drag.
- Input: Keyboard.current (UnityEngine.InputSystem). Input.GetAxis throws in this project.
- OnTriggerEnter2D needs a Rigidbody2D on one of the two objects; the player has one.

## Never do
- Never edit .unity, .prefab or .asset files as text. Scene and asset changes go through Unity CLI commands. No Editor connection? List the steps for me instead.
- Never add features that aren't in the spec or my request. Suggest them at the end instead.
- Never commit or push. I do that.

## When you finish a task
Report: the files you changed, the assets and objects I need to create (or that you created), how each acceptance criterion is met, and what I should test in Play Mode.
