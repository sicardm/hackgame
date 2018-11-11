using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coffeeBehave : MonoBehaviour {

    private int count = 0;
	
	// Update is called once per frame
	void Update () {

        if (count % 2 == 0)
        {
            transform.Rotate(new Vector3(0, 0, 30)*(float).2);
            count++;
        }
        else
        {
            count++;
        }
	}
}
