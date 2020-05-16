using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationOfAxis : MonoBehaviour
{
    void Start()
    {
        // 위성의 공전축을 7도 기울임
        iTween.RotateBy(gameObject, iTween.Hash(
            "z", 7 / 360f,
            "time", 1,
            "easetype", iTween.EaseType.easeOutExpo
            ));

        // 1초후 Rotation함수 실행
        Invoke("Rotation", 1);
    }
    void Rotation()
    {
        // 위성의 공전을 표현
        iTween.RotateBy(gameObject, iTween.Hash(
            "y", -1,
            "easetype", iTween.EaseType.linear,
            "looptype", iTween.LoopType.loop,
            "time", 3
            ));
    }
}
