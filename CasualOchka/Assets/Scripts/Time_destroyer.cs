using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyObject", LifeTime);
    }

    void DestroyObject()
    {
        if (Game_manager.Instance.GameState != GameState.Dead)
            Destroy(gameObject);
    }

    public float LifeTime = 10f;
}
