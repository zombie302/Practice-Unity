using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 스와이프 길이 구하기
        if (Input.GetMouseButtonDown(0))
        {
            // 마우스 클릭한 좌표
            startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // 마우스 땐 좌표
            Vector2 endPos = Input.mousePosition;
            // 스와이프 된 거리
            float swipeLength = endPos.x - this.startPos.x;

            // 스와이프 된 거리를 속도로 변환
            this.speed = swipeLength / 1000.0f;

            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
    }
}
