# Design Meeting 1/22/25 @7:30 MT


Classes:
- Scripture -> Hold the whole scripture that will be show. Pick words randomly to pass to "Word".
- Reference -> Deal with and display the scripture reference (John 3:16)
- Word -> Will calculate the number of letters in each word and replace them with "_"


# Class: Scripture
## Attributes:
- _scripture: List<Word>
- _reference: string

## Constructor:
- Break apart string into list of Word objects.
- Scripture(Reference: Obj-Reference, text: string)

## Behaviors:
- hideWords(numberToHide: int) -> void
- GetDisplayText() -> string
- IsCompletelyHidden -> bool

- GetLetterCount()


# Class: Reference
## Attributes:
- _book: string
- _chapter: int
- _startVerse: int
- _endVerse: int

## Constructor:
- Single Verse components (book, chapter, verse,)
   OR
- Multiple Verse components (book, chapter, startVerse, endVerse)
## Behaviors:
- GetReference()



 [Word(For) Word(God)] so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.



# Class: Word
## Attributes:
- _word: string
- _isHidden: bool

## Constructor:
- Accept Word, determine visibility.
- Word(text)

## Behaviors:
- ShowWord() -> void
- HideWord() -> void
- IsHidden() -> bool
- GetDisplayText() -> string

