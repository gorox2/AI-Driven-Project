# AI Development Log

One entry per work session, newest at the bottom. From Lesson 3 on, commit it together with the work.
Claude may draft an entry from the session, but you check and correct it before you keep it.
It is judged on honesty and judgment, not length: what you kept, what you changed, what you rejected, and why.

## Template (copy it for each session)

```
## YYYY-MM-DD · Session N · [short title]
- Goal:
- Model:
- Key prompts:
- What the AI produced:
- Accepted:
- Changed (and why):
- Rejected (and why):
- How I verified it:
- Time spent:
```

## Entries

## Reconstruction note

These reviewed entries reconstruct the design work from the chats “Clarify game design ambiguities” and “Home Assignment 01 — Cave of Gold game pitch”, which the developer identified as the assignment work since Lesson 2. Dates come from chat timestamps in Asia/Jerusalem. The developer confirmed these session groupings and numbering, reviewed the entries, personally supplied verification and added approximate time estimates. Time estimates are developer recollections, not measurements from chat timestamps. Exact model identifiers were not established. The Lesson 2 date/class boundary has not been separately confirmed. No additional class activity is assumed.

## 2026-10-29 · Session 1 · Concept comparison and asset planning (reconstructed)
- Goal: Clarify two existing game concepts and compare their feasibility for a solo course demo.
- Model: Codex; exact model identifier not established from the reviewed chat.
- Key prompts: Read both design PDFs and ask about material ambiguities before comparing; compare effort and complexity without inventing features; explain existing free assets versus custom art and mechanics-specific animation needs. These are summaries of recorded prompts.
- What the AI produced: Clarification questions, a side-by-side comparison of Cave of Gold and You and I, a recommendation for Cave of Gold, and discussion of asset adaptation, custom production and animation risks.
- Accepted: Developer defined solo Unity 6.3 development from scratch, PC, zero asset budget and a 10–25-minute demo. Cave of Gold scope was limited to one shortened level, military enemy variety, at least one boss, hook traversal/swinging, object movement, enemy pulling, one weapon unlock and one skill unlock. The later chat confirms Cave of Gold as the selected concept; the exact selection moment is not explicit in this day's messages.
- Changed (and why): Reduced the full-game ideas to representative demo scopes to make comparison useful alongside other course commitments. Clarified that AI assists development rather than necessarily appearing as an in-game feature.
- Rejected (and why): Multiplayer, the military-to-monster transition and motorcycle section were excluded from the demo to contain scope. Crafting was optional. No blanket decision to use existing assets or create all art was made because permissions and production workflow were unresolved.
- How I verified it: after comparing i got the expected vision of the game and decided to go with Cave of Gold. read the devlog and confirmed that it matches the agreed upon decisions we made in chat.
- Time spent: approximatly 1 hr.

## 2026-11-10 · Session 2 · Presentation proposal and working agreement (reconstructed)
- Goal: Evaluate a 2.5D direction, understand HA01 and establish how the developer and agent should collaborate.
- Model: Codex; exact model identifier not established from the reviewed chat.
- Key prompts: Critique a 3D side-scrolling presentation with an orthographic camera; read HA01 and explain requirements; read the Docs templates and propose a workflow; create AGENTS.md; move HA01 work to a new chat. These are summaries of recorded prompts.
- What the AI produced: 2.5D tradeoff analysis and a proposed bounded experiment, assignment/template summaries, a collaboration workflow, AGENTS.md and a handoff carrying confirmed scope and open decisions.
- Accepted: Developer authorized creating the working agreement and opening this HA01 chat. The agreement assigns gameplay intent and acceptance to the developer, routine investigation/drafting/checking to the agent, and requires honest logs with developer-written verification.
- Changed (and why): Proposed 2.5D as a possible production direction, retaining planar gameplay; it remained undecided during this session. Established HLD, Backlog and DevLog as the design, scope and history records to maintain continuity.
- Rejected (and why): Did not treat asset production as proven or automatically commit to 2.5D. No gameplay implementation or automatic commit/push was authorized by the planning workflow.
- How I verified it: read the agreement to make sure everything is correct and accurate and preseves a good workflow invironment.
- Time spent: approximatly 30 - 40 mins.

## 2026-11-10 · Session 3 · HA01 design planning
- Goal: Resolve material demo design questions and prepare initial HLD and backlog drafts.
- Model: Codex; exact model identifier not recorded.
- Key prompts: Read the assignment and working agreement; refer to the previous design chat; use the first level; commit to 2.5D. Design answers were supplied conversationally throughout this chat.
- What the AI produced: Initial HLD and MoSCoW backlog drafts, proposed effort estimates, milestone allocation and hook fallback; removed the obsolete provisional-2.5D note from AGENTS.md.
- Accepted: Developer confirmed shortened Kroskow escape with rooftop/street/interior traversal and an end boss; powerful/resourceful target experience; revolver start, early hook pickup at car, SMG unlock; swing, rope climbing and object movement on pickup; fixed-point enemy-pull skill unlock; checkpoint retries preserving unlocks; firearm and shield soldiers; pull breaks shield guard; minigun boss resists pulling and is vulnerable during firing pauses; 2.5D presentation with 3D assets, side-on orthographic camera and planar movement. Developer also confirmed shooting while swinging to support the sense of power. Developer chose left-click shooting, right-click hook use held to maintain swinging, and keyboard aiming, later assigned to Left Ctrl. Movement is WASD, jumping is Space, and holding W while attached with right-click climbs up the rope; controls remain provisional for playtesting. Developer confirmed that the attached hook stays on its target while the mouse independently aims the gun. Developer approved the hook fallback after examples: designated anchors, selected movable objects and controlled enemy-pull reactions, preserving required hook uses. Developer clarified that 21 January 2027 was a personal estimate for Lesson 14, not a submission deadline; planning remains lesson-based. Developer approved the Lesson 7 target: a short placeholder route demonstrating starting combat, early hook pickup and its starting uses, shooting while swinging, both unlocks, shield guard breaking, a basic minigun boss, escape ending and checkpoint retry. Full 10–25-minute length and polish are deferred. Developer provisionally accepted the Lesson 10 gameplay expansion / Lesson 12 generative-asset division and will supply HA02–04 after lecturer release; the plan must then be checked against those instructions. The developer subsequently reported reviewing the HLD, Backlog and DevLog for alignment with the intended design; effort estimates remain planning estimates. The developer reported checking that the HLD fits one readable page with paper-layout adjustments. The agent added and checked a repository-root .gitignore excluding generated Unity/IDE files while retaining source and course documents. The developer confirmed final review of all three documents and inclusion of the initial Unity project in version control; gameplay will be built in later commits.
- Changed (and why): Enemy pulling moved from initially available to a fixed-point skill unlock. Hook availability moved to the early car pickup. These follow the developer's revised progression intent. HLD and backlog now explicitly require aiming/shooting while swinging; the proposed weapon effort estimate rose from M to L to account for this integration. Aiming moved from right-click to a keyboard key so right-click can maintain the hook while left-click fires.
- Rejected (and why): Pistol, grenade and hook launch were kept optional rather than required to contain demo scope. No implementation was performed in this session.
- How I verified it: verified the game design by answering questions regarding what to impliment and which mechanics would be done in the demo (musts and coulds...). read the HLD, Backlog and DevLog and made sure everything is aligned, and it matches the vision i have for the game. made sure the .gitignore is working properly, and that publishing to github is done as intended.
- Time spent: approximatly 2-3 hrs.

Agent check evidence (separate from developer verification): reviewed both identified chats and the current documents; reconstructed dated entries and checked document changes for whitespace errors. No gameplay testing was performed. The developer confirmed session grouping and supplied all three verification fields and approximate durations. Exact model identifiers remain unknown.

## 2026-11-12 · Session 4 · HA02 movement and jumping

- Goal: Define and prototype Token's 2.5D movement and jump for the Lesson 7 playable loop.
- Model: Codex. Exact model identifier was not recorded.
- Key prompts: “now lets write the AGENT.md file together”, “yes air steering”, and “lets do it” after approving the movement spec.
- What the AI produced: A draft AGENT.md, the movement and jumping spec, PlayerMovement.cs, a placeholder MovementTest scene, and a Play Mode measurement run.
- Accepted: The developer approved AGENT.md for now and approved A/D movement, Space jump, air steering, W/S reserved, the 5-unit-per-second and 1.5-unit starting targets, one jump per press, and cancellation when A and D are held together. Implementation review is pending.
- Changed (and why): Added Unity Pipeline so the agent could create the scene through the Editor. Routed the simulated keyboard to the Game view for the measurement run after the first run registered no input.
- Rejected (and why): Camera follow, hook movement, combat, animation, and checkpoints were left outside this movement spec.
- How I verified it: read the docs, made sure everything is aligned together. then play tested the movement and jump feature, made sure it works good and is aligned to what is written in its feature spec file.
- Time spent: 30-45 mins

Agent check evidence: All five numbered criteria passed with simulated keyboard input. Travel was 4.882 units in either direction, stopping displacement was 0.000, jump rise was 1.446, Token reversed direction in the air, W and S left Token stationary, and depth drift was 0.0000. The Editor logged a URP shader asset error during scene rendering.
