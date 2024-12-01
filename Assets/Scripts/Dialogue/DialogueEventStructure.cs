/*
DialogueEvent
    ID
    Background (Image)

    BGM
    SFX
    Transition (loading transition 1.cross fade 2. wipe 3. FadeToWhite 4. FadeToBlack 5. CutToBlack)

    CharacterProfile
        ImageName 
        Position (1. left 2. middle left, 3. middle, 4. middle right 5. right) (default is 3)

    Options
        SFX
        DialogueEvent (to open)
        ShowCondition (for the button to be visible and not be grey)
            ConditionType (1. has variable 2. greater than variable)
            Variable
            Amount
        (Can have multiple show conditions)
        Effect (the effect of clicking on this button)
            EffectType (1. set boolean 2. set variable amount, 3. Set next dialogu event ID)
            Variable
            SetToTrue
            SetAmount
            BGM
            SFX
            VFX 

    SceneEndEffect (See above)
        ConditionType (1. set boolean 2. set variable amount, 3. Set next dialogu event ID)
        Variable
        SetToTrue
        SetAmount
        ConnectingDialogueEvent
        OpenScene (will override "ConnectingDialogueEvent")

  Notes:
  * When loading the next dialogue event, it it belongs to another scene, go to that scene
 */

