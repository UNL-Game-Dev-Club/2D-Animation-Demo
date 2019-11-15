using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShip : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -150 || transform.position.x > 150)
        {
            Destroy(gameObject);
        }       
    }
}
