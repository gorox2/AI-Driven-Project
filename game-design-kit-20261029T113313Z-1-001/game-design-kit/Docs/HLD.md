# Cave of Gold · One-page HLD

> Reviewed HA01 design; provisional controls and unresolved choices are explicit.

**One-line pitch:** Play Token, a retired treasure hunter, and combine firearms with a versatile hook to fight through the military and escape Kroskow town.

**Genre · view · platform:** Single-player action shooter/platformer · 2.5D: 3D characters and environments, side-on orthographic camera, movement constrained to a plane · PC · Unity 6.3.

## Target experience

Feel like a powerful, resourceful fighter whose experience with weapons and tools helps him overcome military opposition and traversal obstacles.

## Core loop

Traverse → engage → overcome → advance. Combat and traversal can overlap: Token can aim and shoot while swinging. Each obstacle or encounter brings him closer to escape; fixed progression points add an SMG and enemy pulling.

## Win and lose conditions

- **Win:** Defeat the minigun boss and leave town, ending the demo.
- **Lose:** On death, respawn at the last checkpoint with restored health and encounter state. Weapon and skill unlocks remain available.

## Controls

WASD: movement; Space: jump; mouse: free targeting; left-click: shoot; right-click: use hook (hold to maintain attachment/swing, release to detach); hold W while attached with right-click to climb up the rope; Left Ctrl: aim. The hook stays attached while the mouse aims the gun independently. These controls are provisional and may be refined through playtesting. Quickfire behaviour, whether shooting requires aiming, rope descent and pulling inputs remain open.

## Must-have features

- Main menu, playable start and clear escape ending.
- 2.5D movement, jumping and side-on camera.
- One shortened Kroskow level: rooftops, streets and building interiors; target 10–25 minutes.
- Starting revolver and fixed-point SMG unlock; aiming and shooting while swinging.
- Early hook pickup at Token's car; swinging, rope climbing and moving objects available on pickup.
- Fixed-point enemy-pull unlock; shield soldiers require pulling to break guard before damage.
- Firearm soldiers and a protected minigun boss that resists pulling and is vulnerable during firing pauses.
- Health, death and checkpoint retries preserving unlocks.

## Look and sound

Night-time town, dark blue sky and lit background windows; 3D presentation with modest visual demands. Detailed style and sound direction remain open. Initial placeholders are acceptable; HA04 calls for AI-made visuals, music, SFX and UI. Third-party asset permission is unresolved.

## Out of scope this semester

Multiplayer, military-to-monster transition, motorcycle section and levels beyond Kroskow. Optional additions are Could items in the backlog.
