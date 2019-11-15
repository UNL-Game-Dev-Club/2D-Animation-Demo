using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Transform camera;
    public float speedCoefficient;
    Vector3 lastpos;

    void Start()
    {
        lastpos = camera.position;
    }

    void Update()
    {
        transform.position -= new Vector3((lastpos.x - camera.position.x) * speedCoefficient, (lastpos.y - camera.position.y), 0);
        lastpos = camera.position;
    }
}
