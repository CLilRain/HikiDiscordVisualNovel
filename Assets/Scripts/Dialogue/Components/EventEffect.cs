using System;

namespace HikiNeetVisualNovel
{
    public enum EventEffectType
    {
        None = 0,
        SetToTrue = 1,
        SetToFalse = 2,
        SetAmount = 3,
        SetNextDialogueID = 4,
    }

    [Serializable]
    public class EventEffect
    {
        public EventEffectType EffectType;
        public string variableName;
        public int amount;

        public string SFX;

        public string VFX; // For triggering visual effects later on

        public string BGM; // Set to empty or null or 0 to fade out the BGM.
        public TransitionTypes BGMTransitionType;
    }
}