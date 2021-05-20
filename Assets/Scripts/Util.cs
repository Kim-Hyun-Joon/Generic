using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PrintGeneric<int>(3);
        PrintGeneric<string>("Joon");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Print(int inputMessage) {
        //만약 int형 메세지 뿐만 아니라
        //다른 타입의 메세지를 출력해주기 위해서는
        //오버로딩을 하거나 다른 타입에 해당하는 함수를 따로 만들어야 한다
        Debug.Log(inputMessage);
    }

    public void PrintGeneric<T>(T inputMessage) {
        //사용하고 싶은 타입 입력후 사용하면 됨
        Debug.Log(inputMessage);
    }
}
