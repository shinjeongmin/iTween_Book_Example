using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform lookFor;

    public void OnClickMove(GameObject position)
    {
        gameObject.transform.position = position.transform.position; // 매개변수로 받는 오브젝트의 위치로 이동

        transform.LookAt(lookFor.transform); // lookFor 변수에 담긴 오브젝트의 위치를 바라봄
    }
}
