using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using System.Text;


public class Game_manager : MonoBehaviour
{
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyImmediate(this);
        }
    }
 
    private static Game_manager instance;
    public static Game_manager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Game_manager();
            }
            return instance;
        }
    }

    protected Game_manager()
    {
        GameState = GameState.Start;
    }
 
    public GameState GameState { get; set; }
 
    public bool CanSwipe { get; set; }
 
    public void Die()
    {
        UIManager.Instance.SetStatus(Constants.StatusDeadTapToStart);
        this.GameState = GameState.Dead; 
    }

 
}
