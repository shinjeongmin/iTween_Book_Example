using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovePathPoint : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red; // 색상 변경 : 빨강

        // Scene 뷰에서 오브젝트의 좌표를 중심으로 빨간색 동그라미를 그린다. 
        Gizmos.DrawWireSphere(transform.position, 1f);
    }
}
