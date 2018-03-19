using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class круговерть : MonoBehaviour
{

    public float x = 0;
    public float y = 0;
    public float z = 0;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // в перед
        if (global.levo == true)
        {
            
            if (x >= -90)
            {
                transform.Rotate(0, -1.7f, 0);
                x -= 1.7f;
            }
        }

		if (global.niz == true) {
           
			if (y <= 90) {
				transform.Rotate (1.7f, 0, 0);
				y += 1.7f;
				Debug.Log (y);
			}
		}
			
        if (global.pravo == true)
        {
           
            if (z <= 90)
            {

                transform.Rotate(0, 1.7f, 0);
                z += 1.7f;
				Debug.Log (z);
            }
        }
			
        // назад 
        if (global.levo1 == true)
        {
            
            
            if (x <= 0)
            {
                transform.Rotate(0, 1.7f, 0);
                x += 1.7f;

            }
            
        }

		if (global.niz1 == true)
		{

			if (y >= 0)
			{

				transform.Rotate(-1.7f, 0, 0);
				y -= 1.7f;
				Debug.Log (y);
			}

		}
        if (global.pravo1 == true)
        {
            
            if (z >= 0)
            {

                transform.Rotate(0, -1.7f, 0);
                z -= 1.7f;
            }
            
        }
			
    }
}
    

