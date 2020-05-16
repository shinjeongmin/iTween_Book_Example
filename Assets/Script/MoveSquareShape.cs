using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSquareShape : MonoBehaviour
{
    void Start()
    {
        gameObject.transform.position = new Vector3(0, 0, 0); // 큐브의 처음 위치를 (0,0,0)으로 지정.
        iTween.MoveBy(gameObject, iTween.Hash( //MoveBy함수
            "x", 2, // x축 방향으로 2만큼 이동
            "time", 1 // 이동하는데 걸리는 시간은 1초
            ));
        iTween.MoveBy(gameObject, iTween.Hash(
            "y", 4, // y축 방향으로 4만큼 이동
            "delay", 1, // 함수가 1초를 지연하고 시작
            "time", 1
            ));
        iTween.MoveBy(gameObject, iTween.Hash(
            "amount", new Vector3(-4,0,0), // 벡터의 값만큼 현재위치에서 이동
            "delay", 2,
            "time", 1
            ));
        iTween.MoveTo(gameObject, iTween.Hash( //MoveTo함수
            "position", new Vector3(-2, 0,0), //MoveTo 함수는 MoveBy와 달리 amount 대신 position을 사용
            "delay", 3,
            "time", 1
            )); ;
        iTween.MoveTo(gameObject, iTween.Hash(
            "x", 0, // x축 위치가 0인 곳으로 이동
            "delay", 4,
            "time", 1
            ));
    }
}
