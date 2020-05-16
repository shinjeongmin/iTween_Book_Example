using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationOfEarth : MonoBehaviour
{
    void Start()
    {
        // 지구의 자전축을 23.5도 회전
        iTween.RotateBy(gameObject, iTween.Hash(
            "z", 23.5 / 360,
            "time", 1,
            "easetype", iTween.EaseType.easeOutExpo
            ));

        // 1초후 Rotation함수 실행
        Invoke("Rotation", 1);
    }

    void Rotation()
    {
        // 지구의 자전을 표현
        iTween.RotateBy(gameObject, iTween.Hash(
            "y", 1,
            "easetype", iTween.EaseType.linear,
            "looptype", iTween.LoopType.loop,
            "time", 4
            ));
    }
}