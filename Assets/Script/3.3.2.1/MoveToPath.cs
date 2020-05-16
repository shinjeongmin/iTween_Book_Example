using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPath : MonoBehaviour
{
    public Transform[] movePath; // 오브젝트가 움직일 경로좌표들이 담긴 배열

    void OnDrawGizmos()
    {
        iTween.DrawPath(movePath, Color.blue); // Scene뷰에서 경로 좌표들을 선으로 연결
    }

    void Start()
    {
        iTween.MoveTo(gameObject, iTween.Hash(
            "path", movePath, // 오브젝트가 이동할 경로
            "time", 3,
            "easetype", iTween.EaseType.easeInOutQuad,
            "looptype", iTween.LoopType.pingPong,
            "movetopath", false // true로 설정되어있으면 게임오브젝트의 현재위치부터 이동이 시작
            ));

    }
}
