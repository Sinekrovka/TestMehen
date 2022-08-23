using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[CreateAssetMenu(order = 52, fileName = "Palete", menuName = "Tools/Palete")]
public class LevelsPaleteColor : ScriptableObject
{
    [Serializable]
    public struct Palete
    {
        public Color color;
        public AudioClip audio;
    }

    [SerializeField] private List<Palete> _paleteList;

    public Palete GetRandomPaleteForString()
    {
        return _paleteList[Random.Range(0, _paleteList.Count)];
    }
}
