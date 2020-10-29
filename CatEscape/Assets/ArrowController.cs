using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;
    float dropSpeed = -0.05f;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, dropSpeed, 0);

        // 화면에서 화살이 나가면 삭제
        if(transform.position.y < -5)
        {
            Destroy(gameObject);
        }

        #region 화살 충돌 판정
        // 화살 위치
        Vector2 p1 = transform.position;
        // 플레이어 위치
        Vector2 p2 = this.player.transform.position;
        // 플레이어와 화살 사이의 백터
        Vector2 dir = p1 - p2;
        // 화살과 플레이어의 거리
        float d = dir.magnitude;
        // 화살 범위
        float r1 = 0.5f;
        // 플레이어 범위
        float r2 = 1.0f;

        // 화살과 플레이어의 거리가 두 판정 범위보다 작으면 충돌로 판정
        if(d < r1 + r2)
        {
            // 감독 스크립트에 충돌했다고 전달
            GameObject gameDirector = GameObject.Find("GameDirector");
            gameDirector.GetComponent<GameDirector>().DecreaseHp();

            Destroy(gameObject);
        }
        #endregion
    }
}
