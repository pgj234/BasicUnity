using UnityEngine;

public class LoopExample : MonoBehaviour
{
    void Start()
    {
        // for�� : 1���� 10���� ���
        //for (int i=0; i<10; i++)
        //{
        //    Debug.Log(string.Format("Count : {0}", i+1));
        //}

        // while �� : ������ ���� �� ����
        int counter = 0;
        while (counter < 5)
        {
            Debug.Log(string.Format("While Count : {0}", counter));
            counter++;
        }
    }
}
