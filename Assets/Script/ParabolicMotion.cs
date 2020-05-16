using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolicMotion : MonoBehaviour
{
    public GameObject subMove;

    public float height; // 올라갈 높이
    public Vector3 goal; // 도착지점좌표
    void Start()
    {
        // y축방향 가속운동
        iTween.MoveBy(subMove, iTween.Hash(
            "y", height,
            "time", 1,
            "easetype", iTween.EaseType.easeOutQuad
            ));
        iTween.MoveBy(subMove, iTween.Hash(
            "y", -height,
            "delay", 1,
            "time", 1,
            "easetype", iTween.EaseType.easeInCubic
            ));

        // x,z축방향 등속운동
        iTween.MoveTo(gameObject, iTween.Hash(
            "x", goal.x,
            "z", goal.z,
            "time", 2,
            "easetype", iTween.EaseType.linear
            ));
    }
}
