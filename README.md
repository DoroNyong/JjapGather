# JjapGather


---


닉네임 화면
![image](https://github.com/DoroNyong/JjapGather/assets/62960758/612a14e3-298f-48a6-aeec-ac689283f3c1)

인게임 화면
![image](https://github.com/DoroNyong/JjapGather/assets/62960758/1ac2b648-b983-4ade-a245-43ef02d53b81)


---


닉네임 변경 패널 오브젝트를 가져와서 해당 오브젝트가 비활성 상태일때만 캐릭터 행동 코드가 실행되게 만드는 코드
````
[SerializeField] private GameObject Panel;

public void OnMove(InputValue value)
{
    if (!Panel.activeSelf)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }
}
````
