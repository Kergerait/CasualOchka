using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controls : MonoBehaviour
{

    private Rigidbody rb;
    private float speed = 1f;   // Скорость движения объекта тут
    private bool isMovingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody> ();
    }

    void changeDirection ()
    {
        isMovingRight = !isMovingRight;       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            changeDirection();
        }

        if (isMovingRight) {
            rb.velocity = new Vector3 (speed, 0f, 0f);    
        }
        else {
            rb.velocity = new Vector3 (0f, 0f, speed);
        }
        
    }
}
