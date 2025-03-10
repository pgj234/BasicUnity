using UnityEngine;

public class LoopExample : MonoBehaviour
{
    void Start()
    {
        // for문 : 1부터 10까지 출력
        //for (int i=0; i<10; i++)
        //{
        //    Debug.Log(string.Format("Count : {0}", i+1));
        //}

        // while 문 : 조건이 참일 때 실행
        int counter = 0;
        while (counter < 5)
        {
            Debug.Log(string.Format("While Count : {0}", counter));
            counter++;
        }
    }
}
