using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCamera : MonoBehaviour
{
    public GameObject Jaskier;
    public float offsetY;
    void Start()
    {
        offsetY = 2;
    }

    void Update()
    {
        transform.position = new Vector3(Jaskier.transform.position.x,
                                         Jaskier.transform.position.y+offsetY,
                                         -10);
    }
}
