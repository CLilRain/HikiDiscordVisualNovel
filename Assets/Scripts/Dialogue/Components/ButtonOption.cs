using System;

namespace HikiNeetVisualNovel
{
    public enum ConditionType
    {
        None = 0,
        IsEqualTo = 1,
        IsLessThan = 2,
        IsGreaterThan = 3,
    }

    [Serializable]
    public class ConditionToShow
    {
        public ConditionType ConditionType;
        public string VarName;
        public int greaterThanAmount;
    }

    [Serializable]
    public class ButtonOption
    {
        // The condition required to show this button
        public ConditionToShow[] ShowConditions;

        // What happens after click on the button
        public EventEffect[] OnClickEffects;

        // If empty, will fall back to DialogueEvent's default DialogueIDToOpen
        public int DialogueIDToOpen; 
    }
}