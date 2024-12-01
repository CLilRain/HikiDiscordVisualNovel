using System;
using UnityEngine;

namespace HikiNeetVisualNovel
{
    public enum TransitionTypes
    {
        CrossFade = 0,
        FadeOut = 1,
        CutToNext = 2,
    }

    [Serializable]
    public class DialogueEvent : MonoBehaviour
    {
        // Identifier of the dialogue event
        public int ID;

        // File for the background image to load
        public string BG;

        // Sound effect to play at the start of a dialogue.
        public string SFX;

        // Background music to play at the start of a dialogue.
        public string BGM;

        public CharacterToShow[] CharactersToShow;

        public ButtonOption[] ButtonOptions;

        // If empty, will not trigger a new dialogue, will return to previous game scene
        public int DialogueIDToOpen;

        // The event played if no button event is triggered
        public EventEffect DefaultOnEndEffect;

        public TransitionTypes BGTransitionType;
    }
}