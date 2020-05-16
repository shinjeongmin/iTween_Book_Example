using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightPendulum : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Ground")
        {
            // 무게추가 Ground라는 태그와 충돌하면 카메라를 흔드는 함수를 실행함
            GameObject.Find("DropManager").GetComponent<WeightDrop>().ShakeCamera();

            // 3초 후 무게추를 파괴함
            Destroy(gameObject, 3.0f);
        }
    }
}
