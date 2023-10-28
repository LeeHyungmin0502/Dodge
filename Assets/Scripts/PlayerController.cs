using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigid;     // 이동에 사용할 rigidbody 컴포넌트
    public float speed = 8f;     // 이동 속력

    void Start()     // Start() 메서드 : 게임 실행시 처음 한번만 실행
    {
        playerRigid = GetComponent<Rigidbody>();     // 게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 playerRigid에 할당    
    }

    void Update()     // Update() 메서드 : 한 프레임에 한번, 매 프레임마다 반복 실행
    {
        float xInput = Input.GetAxis("Horizontal");     // 수평축의 입력값을 감지하여 저장
        float zInput = Input.GetAxis("Vertical");     // 수직축의 입력값을 감지하여 저장

            // 실제 이동 속도를 입력값과 이동 속력을 사용해 결정
        float xSpeed = speed * xInput;
        float zSpeed = speed * zInput;

        Vector3 newVelocity = new Vector3 (xSpeed, 0f, zSpeed);     // Vector3 속도를 (xSpeed, 0f, zSpeed)로 생성

        playerRigid.velocity = newVelocity;     // 리지드바디의 속도에 newVelocity 할당
    }

    public void Die()     // 플레이어 사망 메서드
    {
        gameObject.SetActive(false);     // 자신의 게임 오브젝트를 비활성화
    }
}
