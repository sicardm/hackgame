using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startButton : MonoBehaviour {

    public GameObject player;
    public GameObject startScreen;
    public GameObject money;
    public GameObject book;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            player.SetActive(true);
            startScreen.SetActive(false);
            gameObject.SetActive(false);
            money.SetActive(true);
            book.SetActive(true);
        }
        else
        {
           /* if ((int)Time.time == 0)
            {
                transform.Rotate(new Vector3(0, 0, 20)*Time.deltaTime);
             
            }
            else */if((int)Time.time%2==0)
            {
                transform.Rotate(new Vector3(0, 0, -40)*Time.deltaTime);
            }
            
            else if((int)Time.time%2==1)
            {
                transform.Rotate(new Vector3(0, 0, 40)*Time.deltaTime);
            }
            
        }
	}
}
