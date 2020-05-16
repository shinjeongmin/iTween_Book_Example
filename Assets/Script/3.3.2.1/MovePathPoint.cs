using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePathPoint : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue; // 색상 변경 : 파랑

        // Scene 뷰에서 오브젝트의 좌표를 중심으로 파란색 동그라미를 그린다. 
        Gizmos.DrawWireSphere(transform.position, 0.25f);
    }
}
