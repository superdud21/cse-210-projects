# Journal Planning Meeting - Wednesday 1/15/25 @ 7:30 MT

## Journal Design Plan:


Class: journal
Attributes:
_listOfEntries: list

Behaviors:
- SaveJournal()
- LoadJournal()
- DisplayEntries()
- AddNewEntry()


Class: prompts
Attributes:
_prompts: list

Behaviors:
 - GetPrompt() -> String


Class: entry
Attributes:
_prompt: string
_date: string
_entryText: string

Behaviors:
- Display() 


## Creativity Addition: