using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookPoint : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green; // 색상 변경 : 초록

        // Scene 뷰에서 오브젝트의 좌표를 중심으로 초록색 동그라미를 그린다. 
        Gizmos.DrawWireSphere(transform.position, .5f);
    }
}