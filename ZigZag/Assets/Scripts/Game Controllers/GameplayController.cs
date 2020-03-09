using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayController : MonoBehaviour
{
    public static GameplayController instance;

    [HideInInspector]
    public bool gamePlaying;

    void Awake()
    {
        MakeSingleton();
    }

    private void OnDisable()
    {
        instance = null;
    }

    void MakeSingleton()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
}
