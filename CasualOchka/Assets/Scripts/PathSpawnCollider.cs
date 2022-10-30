using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathSpawnCollider : MonoBehaviour
{
    public float positionY = 0.81f;
    public Transform[] PathSpawnPoints;
    public GameObject Path;
    public GameObject DangerousBorder;

    void OnTriggerEnter(Collider hit)
    {
      //player has hit the collider
      if (hit.gameObject.tag == Constants.PlayerTag)
        {
          //find whether the next path will be straight, left or right
          int randomSpawnPoint = Random.Range(0, PathSpawnPoints.Length);
          for (int i = 0; i < PathSpawnPoints.Length; i++)
            {
              //instantiate the path, on the set rotation
              if (i == randomSpawnPoint)
                  Instantiate(Path, PathSpawnPoints[i].position, PathSpawnPoints[i].rotation);
            }
        }
    }
}
