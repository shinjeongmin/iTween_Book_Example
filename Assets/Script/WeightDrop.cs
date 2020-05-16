using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightDrop : MonoBehaviour
{
	public GameObject Camera; // 카메라 오브젝트
	public GameObject weightPendulum; // 무게추 오브젝트

	private float x; // 생성되는 무게추의 x좌표
	private float z; // 생성되는 무게추의 z좌표

	private float spawnTime = .5f; // 무게추를 생성할 수 있는 시간간격
	private float nowTime;

	void Start()
	{
		nowTime = Time.time;
	}

	public void OnClickButton()
	{
		if (Time.time - nowTime > spawnTime) // 시간간격 만큼 시간이 지나야만 재생성할 수 있음
		{
			// -4.5에서 4.5 까지의 좌표 중에 임의의 수로 x,z 좌표를 정함
			x = Random.Range(-4.5f, 4.5f);
			z = Random.Range(-4.5f, 4.5f);

			// 새로운 무게추를 생성
			GameObject weightPend = Instantiate(weightPendulum, new Vector3(x, 10f, z), Quaternion.Euler(0, 180f, 0));

			nowTime = Time.time;
		}
		
	}

	public void ShakeCamera()
	{
		// 카메라를 흔들어 충격에 의한 진동처럼 느껴지도록 하는 코드
		iTween.ShakePosition(Camera, iTween.Hash(
			"amount", new Vector3(1f, 1f, 1f),
			"time", .5f,
			"easetype", iTween.EaseType.easeOutElastic
			));
	}
}