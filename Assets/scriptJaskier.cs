using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptJaskier : MonoBehaviour
{
    private Rigidbody2D rbd;
    private Animator anim;
    public float vel;
    public float jump;
    private bool floor;
    public GameObject foot;
    public LayerMask mascara;
    private bool direita = true;
    private bool isSleeping = false;



    // Start is called before the first frame update
    void Start()
    {
        vel = 5;
        jump = 300;
        rbd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    //private void OnCollisionEnter2D(Collision2D collision) {
    //    floor = true;
    //}

    private void OnCollisionExit2D(Collision2D collision) {
        floor = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ghost" || collision.gameObject.tag == "Damage")
        {
            
            
            isSleeping = true;
            anim.SetBool("sleeping", true);
            //Destroy(gameObject, 2f);
            
        }
        else
        {
            floor = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (isSleeping)
        {
            rbd.velocity = Vector2.zero;
            return;
        }


        float x = Input.GetAxis("Horizontal");
        rbd.velocity = new Vector2(x * vel, rbd.velocity.y);

        anim.SetBool("moving", Mathf.Abs(x) > 0);

        
        //direction detection
        if (x<0 && direita || x>0 && !direita) {
            transform.Rotate(new Vector2(0,180));
            direita = !direita;
        } 



        if (Input.GetKeyDown(KeyCode.Space) && floor)
        {
            anim.SetBool("jumping", true);
            rbd.AddForce(new Vector2(0, jump));
        }else
        {
            anim.SetBool("jumping", rbd.velocity.y > 0);
        }
    }

}
