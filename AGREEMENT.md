# Developer and agent working agreement

## Project and sources of truth
- Unity project: `AI_Driven_CaveOfGold/`.
- Course documents: `game-design-kit-20261029T113313Z-1-001/game-design-kit/Docs/`.
- `HLD.md` defines the agreed game and target experience. Keep it to one page.
- `Backlog.md` defines feature priorities, milestone commitments, and the riskiest Must with its fallback.
- `DevLog.md` records actual work sessions and decisions; append new entries at the bottom.
- Read these documents before planning or implementing work. Inspect relevant code, scenes, and current local changes before editing.
- The developer's current explicit instructions take precedence. Reconcile affected documents when a decision changes; flag contradictions instead of silently choosing a new design.

## Decisions and scope
- The developer owns gameplay intent, priorities, production direction, and final acceptance. The agent investigates, drafts, implements, checks, and explains the work.
- Proceed autonomously with routine details within an agreed task. Ask about unresolved decisions that materially affect gameplay, scope, production direction, or course commitments.
- Do not invent features, add optional systems, or promote suggestions into commitments. Record unresolved choices explicitly.
- Keep HLD Musts and out-of-scope items consistent with Backlog Musts and Won't items. Together the Musts must form a complete game from menu to ending.
- Prioritize the next course milestone and a complete playable experience. Address major technical risks early using bounded experiments.

## Work-session cycle
1. Select one concrete outcome from the current milestone and define observable acceptance criteria. If no next task is clear, propose one and clarify material uncertainty.
2. Inspect the project and preserve existing developer changes. Avoid simultaneous edits to the same scene or asset; coordinate overlapping work.
3. Implement a coherent, manageable change. Explain relevant choices so the developer can understand and defend them.
4. Run checks appropriate to the change. Distinguish implemented, technically checked, and developer-playtested work. Never claim checks that were not run.
5. Report the outcome, remaining issues, and concise instructions for developer playtesting when needed. Use the feedback to refine the work.
6. Update affected scope/progress records and draft an accurate session log. Keep related work and documentation together in version control.

## Verification and Unity editing
- Follow applicable Unity skills and project conventions when operating the Editor or changing Unity assets.
- Preserve Unity asset identities and references, including `.meta` files. Do not hand-edit generated `Library/`, `Temp/`, or `Obj/` contents.
- Verify compilation and relevant behaviour when possible. Report unavailable checks explicitly. Test playable changes in a build when appropriate to the milestone.
- Technical checks do not establish game feel. Developer playtesting determines whether movement, combat, readability, and pacing meet the intended experience.
- Do not mark a feature complete merely because code exists; use its agreed acceptance criteria and record any outstanding validation.

## Documentation and honest AI records
- Preserve the course templates and required sections. Keep documents concise and synchronize them with actual decisions and project state.
- Preserve required backlog columns: Feature, MoSCoW, Why, Effort (S/M/L). A progress/status column may be proposed separately; this agreement does not itself alter the template.
- Log each work session using the DevLog template: date, session number/title, goal, model, key prompts, AI output, accepted work, changes and reasons, rejections and reasons, verification, and time spent.
- The agent may draft factual entries. The developer checks/corrects them and personally writes `How I verified it`, as required by the assignment. Leave that field clearly pending until supplied; keep agent-run check evidence separate.
- Never invent dates, durations, prompts, class activity, acceptance, or test results. Reconstruct earlier sessions only from available evidence and developer recollection; label estimates and unknowns.
- From Lesson 3 onward, include the updated log with the corresponding work when committing. Inspect the diff and avoid staging unrelated changes. Follow the developer's authorization for commits and pushes; do not publish automatically.

## Course constraints
- Solo development, Unity 6.3, PC demo, zero asset budget; target gameplay duration is 10-25 minutes.
- Asset permissions remain unresolved until lecturer guidance is provided. Check relevant permissions before relying on third-party assets.
- HA02 / Lesson 7: core loop playable from start to end; placeholders are acceptable.
- HA03 / Lesson 10: deliver the agreed milestone; consult assignment instructions for specific requirements.
- HA04 / Lesson 12: the scope-plan template calls for AI-made visuals, music, SFX, and UI in the game.
- Final: every Must complete; the template says three days before Lesson 14. 21 January 2027 is only the developer's estimate for Lesson 14, not an official lesson date or submission deadline. Keep milestones lesson-based until official dates are confirmed.
