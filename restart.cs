using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart : MonoBehaviour {

    public GameObject player;
    public GameObject book;
    public GameObject endPage;
    public GameObject exitButton;
    public GameObject textThings;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            player.SetActive(true);
            book.SetActive(true);
            endPage.SetActive(false);
            exitButton.SetActive(false);
            textThings.SetActive(true);
            gameObject.SetActive(false);


        }
		
	}
}
