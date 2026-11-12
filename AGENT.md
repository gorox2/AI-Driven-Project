# Cave of Gold — notes for the agent

## Project

- Open `AI_Driven_CaveOfGold/` in Unity 6.3 LTS (`6000.3.28f1`). The project uses URP and the new Input System only.
- The game is a single-player Windows demo with 3D characters and environments, a side-on orthographic camera, and movement constrained to a plane.
- I plan, direct, review, playtest, and commit. The agent writes the code. Read `AGREEMENT.md` for our working process.
- The course docs live in `game-design-kit-20261029T113313Z-1-001/game-design-kit/Docs/`. Read `HLD.md` for design, `Backlog.md` for scope, and `DevLog.md` for prior decisions.
- For HA02, use the Lesson 7 scope in the backlog. The core loop must be playable from start to end. Placeholder art and sound are fine.

## Architecture

- The project currently has Unity starter assets and no gameplay scripts.
- [?] Start gameplay code under `Assets/_Game/Scripts/`, with folders by feature and namespaces under `CaveOfGold`.
- [?] Start with Inspector fields for tuning. Use a ScriptableObject config when multiple objects need to share the same values.
- [?] Give each gameplay state one owner. Define the owner and how other components interact with it in the relevant feature spec.

## Conventions

- Write and review one spec per feature under the course docs' `Specs/` folder before implementing it. Use the context-kit template and numbered acceptance criteria I can test in Play Mode.
- If a spec leaves gameplay behavior open, ask me and record my decision in the spec before implementing that behavior.
- Keep the hook attachment independent of gun aim so the player can aim and shoot while swinging.
- Treat `Assets/TutorialInfo/` as Unity onboarding material. Keep gameplay code out of it.
- Verify unfamiliar Unity APIs against the project's Unity and package versions before using them.

## Never do

- Never hand-edit `.unity`, `.prefab`, or `.asset` files as text. Make scene and asset changes through the Unity Editor using Unity CLI. If the Editor is unavailable, give me the steps to apply.
- Never add gameplay outside the agreed spec or my request.
- Never commit or push. I do that after reviewing and playtesting the work.
- Never put passwords or API keys in the repository.

## When you finish a task

- Report the files, scene objects, and assets you changed or that I still need to set up.
- For each numbered criterion, report what you verified and what I should test in Play Mode. Include any Console errors or warnings you observed.
- Record significant AI contributions in the Dev Log for the session. The agent may draft the entry. I review it and write “How I verified it” myself.
