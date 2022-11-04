using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == Constants.PlayerTag)
            Game_manager.Instance.CanSwipe = true;
    }
 
    void OnTriggerExit(Collider hit)
    {
        if (hit.gameObject.tag == Constants.PlayerTag)
            Game_manager.Instance.CanSwipe = true;
    }
}
