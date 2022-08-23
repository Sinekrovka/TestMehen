using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(order = 51, fileName = "LevelsConfig", menuName = "Tools/LevelsConfigurate")]
public class LevelConfigFiles : ScriptableObject
{
    [Serializable]
    public struct LevelParams
    {
        public int countStrings;
        public int countRows;
    }

    [SerializeField] private List<LevelParams> levels;

    public LevelParams GetCurrentLevel(int levelIndex)
    {
        return levels[levelIndex];
    }
}
