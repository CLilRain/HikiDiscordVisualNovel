using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HikiNeetVisualNovel
{
    public enum ProfilePosition // The position of the character profile image on screen
    {
        Left = 0,
        MiddleLeft = 1,
        Middle = 2,
        MiddleRight = 3,
        Right = 4,
    }

    [Serializable]
    public class CharacterToShow
    {
        public string ProfilePath; // The image for the character
        public string ProfileName; // The name of the character to display
        public ProfilePosition ProfilePosition; // 0 = left, 1 = middleLeft ... 4 = Right
    }
}