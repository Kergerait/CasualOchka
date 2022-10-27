using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_falls : MonoBehaviour
{

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
      if (Physics.Raycast (transform.position, Vector3.down, out hit, 5f) && hit.transform.gameObject.tag == "Ground") {
         rb.useGravity = false;
      } 
      else {
         rb.useGravity = true;
      }
    }
}
