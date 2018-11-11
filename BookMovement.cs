using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookMovement : MonoBehaviour {

    //Transform person;
    private Rigidbody2D rb2d;
    private BoxCollider2D boxCollider;
    public Vector2 direction; 
    public int n;
    public bool move = true;
    public Vector2 lastPlace;
   


    public void Start()
    {
        //person = GameObject.FindGameObjectWithTag ("Player").transform;
        rb2d = GetComponent<Rigidbody2D>();
        direction = new Vector2(-1, 0);

       
    }

    private void Update()
    {
        //boxCollider.enabled = true;

        if (move == true) {
            
            transform.Translate(direction * Time.smoothDeltaTime * 3);
            
         
        }  
        
    }
  
    public void OnCollisionEnter2D(Collision2D collision){

      

        if (collision.gameObject.tag == "Collider" || collision.gameObject.tag == "textBook")
        {
            move = false;
            //yield return new WaitForSeconds(0.25f);

           

                if (Random.value < 0.5f)
                {
                    n = -1;
                }
                else
                {
                    n = 1;
                }


                if (direction.Equals(Vector2.up))
                {
                //transform.position = new Vector2(transform.position.x, transform.position.y- 0.3f);
                direction.Set(n, 0);
                }
                else
                {
                    if (direction.Equals(Vector2.down))
                    {
                    

                        //transform.position = new Vector2(transform.position.x, transform.position.y+ 0.3f);
                        direction.Set(n, 0);
                    }
                    else
                    {
                        if (direction.Equals(Vector2.left))
                        {
                        
                        //transform.position = new Vector2(transform.position.x- 0.3f, transform.position.y);
                        direction.Set(0, n);
                        }
                        else
                        {
                            if (direction.Equals(Vector2.right))
                            {
                            
                            //transform.position = new Vector2(transform.position.x+ 0.3f, transform.position.y);
                            direction.Set(0, n);
                            }
                            else
                            {
                                move = false;
                            }
                        }
                    }

                }
            transform.Translate(direction * Time.smoothDeltaTime * 3);
            transform.Translate(direction * Time.smoothDeltaTime * 3);
            move = true;

        }
        
    }

}
