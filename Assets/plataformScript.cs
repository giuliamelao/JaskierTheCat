using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformScript : MonoBehaviour
{

    private Vector2 init;
    public float desloc = 1.2f;
    public float cont = 0;
    public float h = 1.5f;
    void Start()
    {
        init = transform.position;
    }

    void Update()
    {
        float y = Mathf.Cos(cont) * h;

        transform.position = new Vector2(init.x, init.y + y);
        cont = cont + desloc * Time.deltaTime;

        if (cont > 2 * Mathf.PI) {
            cont = cont - 2 * Mathf.PI;
        }
    }
}
