using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Security.Cryptography;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rouletteSpeed = 0;
    readonly float minusSpeed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 마우스 입력
        if (Input.GetMouseButtonDown(0))
        {
            this.rouletteSpeed = 10;
            //if(this.rouletteSpeed != 0)
            //{
            //    this.rouletteSpeed = 0;
            //}
            //else
            //{
            //    this.rouletteSpeed = 10;
            //}
        }

        this.rouletteSpeed *= 0.99f;

        transform.Rotate(0, 0, this.rouletteSpeed);
    }
}
