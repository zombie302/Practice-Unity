using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-speed, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(speed, 0, 0);
        }
    }

    public void LButtonDown()
    {
        transform.Translate(-speed, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(speed, 0, 0);
    }
}
