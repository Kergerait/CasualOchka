using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class Coin : MonoBehaviour
{
  void OnTriggerEnter(Collider col)
    {
        UIManager.Instance.IncreaseScore(ScorePoints);
        Destroy(this.gameObject);
    }

    public int ScorePoints = 1;
}
