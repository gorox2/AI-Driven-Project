# Feature backlog and scope plan

> Reviewed HA01 backlog. Feature decisions reflect the conversation. Effort estimates are planning estimates. The Lesson 10/12 division is provisionally agreed, subject to the released assignments. The Lesson 7 prototype scope and hook fallback have developer approval. S/M/L express relative effort, not durations.

## Backlog (MoSCoW)

- **Must:** required for the complete demo from main menu to ending.
- **Should:** important, but the game works without it; none assigned yet.
- **Could:** optional, after Musts are secure.
- **Won't (this semester):** explicitly excluded.

| Feature | MoSCoW | Why | Effort (S/M/L) |
|---|---|---|---|
| Main menu, playable start and clear escape ending | Must | Complete demo from entry to completion | S |
| 2.5D movement, jumping and side-on camera | Must | Agreed presentation and basic traversal | M |
| Shortened Kroskow level: rooftops, streets and building interiors; 10–25-minute target | Must | Agreed setting and playtime | L |
| Starting revolver and fixed-point SMG unlock; aim and shoot while swinging | Must | Contrasting weapons and combined combat/traversal support the powerful, resourceful experience | L |
| Early hook pickup at car; swinging, rope climbing and moving objects | Must | Versatile tool and traversal identity | L |
| Fixed-point enemy-pull unlock and shield guard breaking | Must | Required skill unlock with a combat purpose | L |
| Firearm soldiers | Must | Ordinary opposition; firearm still undecided | M |
| Shield soldiers | Must | Pulling breaks their guard before damage | M |
| Protected minigun boss | Must | Escape finale; resists pulling, vulnerable during firing pauses | L |
| Health, death and checkpoint retries preserving unlocks | Must | Retries restore health and encounter state | M |
| Pistol | Could | Additional weapon feel | M |
| Grenade | Could | Optional combat variety | M |
| Hook launch toward an anchor | Could | Additional traversal; XP unlock is a future possibility, not a required XP system | L |
| Crafting | Could | Only if time remains; scope undefined | L |
| Multiplayer | Won't | Single-player demo | L |
| Military-to-monster transition | Won't | Later full-game progression | L |
| Motorcycle section | Won't | Separate gameplay outside demo | L |
| Levels beyond Kroskow | Won't | One shortened first level | L |

## Scope plan

Lesson 7 scope is agreed. The Lesson 10/12 division is provisionally agreed: expand and refine gameplay by Lesson 10, integrate required generative assets by Lesson 12. HA02–04 have not yet been supplied; the developer will share them after lecturer release, then we will check and revise this plan against their actual requirements. Calendar dates remain unresolved.

| Deadline | What must be playable | Backlog items |
|---|---|---|
| Home Assignment 02 · Prototype · Lesson 7 | Small placeholder route from start to ending: movement, combat including shooting while swinging, hook pickup and its three starting uses, both unlocks, shield guard breaking, basic boss and death retry | Simplified Musts; full length and polish deferred |
| Home Assignment 03 · Agentic Workflow · Lesson 10 | Expanded Kroskow route with integrated encounters, unlocks, checkpoints and boss; pacing tested toward 10–25 minutes | Level, enemies, progression, checkpoints and boss |
| Home Assignment 04 · Generative Assets · Lesson 12 | AI-made visuals, music, SFX and UI in the game; complete route stays playable | Presentation pass across Musts; detailed asset scope pending |
| Final Project · 3 days before Lesson 14 | Every Must done; complete PC demo from main menu to ending with gameplay duration checked | All Musts |

**Riskiest Must, and my plan B:** Making the hook's traversal and combat functions work reliably together in 2.5D, including shooting while swinging. Test these early in a later bounded prototype. Agreed fallback: designated swing/climb anchor points, selected movable objects and controlled enemy-pull reactions rather than unrestricted environmental interactions or fully dynamic enemy physics. Preserve swinging, climbing up/down the attached rope, object movement and enemy pulling that breaks shield guard; the boss remains pull-resistant. Optional launch can be omitted. Exact interaction tuning remains for playtesting.

**Control decision:** WASD movement, Space jump, Left Ctrl aim, left-click shooting, right-click hook use (hold to maintain attachment/swing, release to detach); hold W while attached with right-click to climb up the rope. The attached hook stays on its target while the mouse independently aims the gun. Controls are provisional and may be refined through playtesting.

**Open decisions:** rope descent and pulling inputs, whether shooting requires aiming, and quickfire behaviour; soldier firearm; art/audio detail and permitted asset sources; checkpoint placement and exact encounter reset boundaries. 21 January 2027 is only the developer's estimate for Lesson 14, not an official date or deadline. Final submission is three days before Lesson 14 per the template; retain lesson-based milestones until official dates are confirmed.
