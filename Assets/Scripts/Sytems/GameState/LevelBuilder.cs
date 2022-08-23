using System.Collections;
using System.Collections.Generic;
using Kuhpik;
using UnityEngine;

public class LevelBuilder : GameSystem, IUpdating, IIniting
{
    [SerializeField] private GameObject _ballPrfeb;
    [SerializeField] private GameObject _platformPrefab;
    [SerializeField] private LevelConfigFiles _file;
    [SerializeField] private LevelsPaleteColor _palete;
    public void OnInit()
    {
        
    }

    public void OnUpdate()
    {
        
    }
}
