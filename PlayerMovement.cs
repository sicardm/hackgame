using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

    public const float SPEED = 5;
    public const float POWERUPSPEED = 10;
    private Vector2 move = new Vector2(1, 0);
    public Text moneyCountText;
    private float powerupTime = 0;
    private Rigidbody2D rd2d;
    private int moneyCount;
    private int coinsGathered;
    public GameObject coins;
    public GameObject coffee;
    public GameObject screen;
    public GameObject win;
    public AudioClip blip;
    public AudioClip wave;
    private AudioSource source;

    // Use this for initialization
    void Start () {
        rd2d = GetComponent<Rigidbody2D>();
        moneyCount = 0;
        coinsGathered = 0;
        moneyCountText.text = "Money:    " + moneyCount.ToString();
        //source = GetComponent<AudioSource>();
        
    }
	
	// Update is called once per frame
	void Update () {

        if (gameObject.activeInHierarchy)
        {
            screen.SetActive(false);
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {

                move.Set(-1, 0);
                if (powerupTime != 0 && Time.time - powerupTime < 5)
                {
                    rd2d.velocity = move * POWERUPSPEED;
                }
                else
                {
                    rd2d.velocity = move * SPEED;
                }



            }

            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                move.Set(1, 0);
                if (powerupTime != 0 && Time.time - powerupTime < 5)
                {
                    rd2d.velocity = move * POWERUPSPEED;
                }
                else
                {
                    rd2d.velocity = move * SPEED;
                }

            }

            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {

                move.Set(0, 1);
                if (powerupTime != 0 && Time.time - powerupTime < 5)
                {
                    rd2d.velocity = move * POWERUPSPEED;
                }
                else
                {
                    rd2d.velocity = move * SPEED;
                }

            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {

                move.Set(0, -1);
                if (powerupTime != 0 && Time.time - powerupTime < 5)
                {
                    rd2d.velocity = move * POWERUPSPEED;
                }
                else
                {
                    rd2d.velocity = move * SPEED;
                }

            }
            else
            {
                if (powerupTime != 0 && Time.time - powerupTime < 5)
                {
                    rd2d.velocity = move * POWERUPSPEED;
                }
                else
                {
                    rd2d.velocity = move * SPEED;
                }
            }

            /*if (coinsGathered % 136 == 0)
            {

                for(int i=0; i< coins.transform.childCount; i++)
                {
                    coins.transform.GetChild(i).gameObject.SetActive(true);
                }

                for(int j=0; j < coffee.transform.childCount; j++)
                {
                    coffee.transform.GetChild(j).gameObject.SetActive(true);
                }

            }*/

        }
       
        

	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            //source.PlayOneShot(blip, 1F);
            other.gameObject.SetActive(false);
            moneyCount += 1;
            coinsGathered += 1;
            //print(coinsGathered);
            SetMoneyText();
            //source.PlayOneShot(blip, 1F);

            if (coinsGathered == 136) {
                // put up winning screen
                moneyCountText.text = "";
                win.SetActive(true);
            }
        }
        else if (other.gameObject.CompareTag("coffee"))
        {
            //source.PlayOneShot(wave, 1F);
            other.gameObject.SetActive(false);
            powerupTime = Time.time;
        }
        else if (other.gameObject.CompareTag("textBook"))
        {
            other.gameObject.SetActive(false);
            moneyCount -= 10;
        }
    }

    void SetMoneyText()
    {
        if (moneyCount > 0)
        {
            moneyCountText.text = "Money:   " + moneyCount.ToString();
        }
        else
        {
            moneyCountText.text = "You broke.";
            gameObject.SetActive(false);
            moneyCountText.text = "";
            moneyCount = 0;
            coinsGathered = 0;
            screen.SetActive(true);


        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("textBook"))
        {
            moneyCount -= 50;
            SetMoneyText();
        }
    }

  }
