using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rave : MonoBehaviour
{

    public SpriteRenderer [] shipSprite;

    // Update is called once per frame
    void Update()
    {
        //for (loopar något)
        if (Input.GetKey(KeyCode.Space))
        {
            for(int i = 0; i < shipSprite.Length; i++)
            {
            shipSprite[i].color = Random.ColorHSV(0, 1, 0, 1, 1, 1);
            }
        }

    }
}

