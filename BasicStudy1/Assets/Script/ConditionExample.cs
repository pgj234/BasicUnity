using UnityEngine;

public class ConditionExample : MonoBehaviour
{
    // �����ڿ� ���ǹ�
    public int health = 100;

    void Update()
    {
        health -= 1;
        Debug.Log(string.Format("hp : {0}", health));

        // ���ǹ�
        if (health <= 0)
        {
            Debug.Log("Game Over!");
        }
    }
}
