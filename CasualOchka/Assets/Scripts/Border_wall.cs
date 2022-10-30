using UnityEngine;
using System.Collections;

public class Border_wall : MonoBehaviour
{

    // Use this for initialization
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == Constants.PlayerTag)
            Game_manager.Instance.Die();
    }
}