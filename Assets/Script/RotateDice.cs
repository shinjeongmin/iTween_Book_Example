using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDice : MonoBehaviour
{
    Rigidbody Gravity;
    void Start()
    {
        Gravity = GetComponent<Rigidbody>();
        Gravity.useGravity = false; //주사위의 중력을 제거
    }

    public void OnClickUP()
    {
        iTween.RotateBy(gameObject, iTween.Hash(
            "x", .25, // x축을 기준으로 90도 회전
            "time", 1,
            "easetype", iTween.EaseType.easeOutElastic,
            "space", Space.World
            ));
    }

    public void OnClickDown()
    {
        iTween.RotateBy(gameObject, iTween.Hash(
            "amount", new Vector3(-.25f, 0, 0), // x축을 기준으로 -90도 회전
            "time", 1,
            "easetype", iTween.EaseType.easeOutElastic,
            "space", Space.World
            ));
    }

    public void OnClickLeft()
    {
        iTween.RotateBy(gameObject, iTween.Hash(
            "y", .25, // y축을 기준으로 90도 회전
            "time", 1,
            "easetype", iTween.EaseType.easeOutElastic,
            "space", Space.World
            ));
    }

    public void OnClickRight()
    {
        iTween.RotateBy(gameObject, iTween.Hash(
            "amount", new Vector3(0, -.25f, 0), // y축을 기준으로 -90도 회전
            "time", 1,
            "easetype", iTween.EaseType.easeOutElastic,
            "space", Space.World
            ));
    }
}
