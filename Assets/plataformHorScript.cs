using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformHorScript : MonoBehaviour
{
    private Vector2 initPosition;
    public float displacement = 4f;
    public float cont = 0;
    public float speed = 0.6f;

    // Start is called before the first frame update
    void Start()
    {
        initPosition = transform.position;        
    } 

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Cos(cont) * displacement;

        transform.position = new Vector2(initPosition.x + x, initPosition.y);
        cont += speed * Time.deltaTime;

        if (cont > 2 * Mathf.PI)
        {
            cont -= 2 * Mathf.PI;
        }
        
    }
}
