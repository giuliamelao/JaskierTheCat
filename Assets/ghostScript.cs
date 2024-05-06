using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostScript : MonoBehaviour
{

    public float speed = 2;
    private Rigidbody2D rbd;


    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        transform.Rotate(new Vector2(0,180));
    }

    void Update()
    {
        rbd.velocity = new Vector2(speed, 0);
    }

    private void OnCollisionEnter2D(Collision2D obj){
        if(obj.gameObject.tag == "floor"){
            speed = speed * -1;
            transform.Rotate(new Vector2(0,180));
        }

    }
}
