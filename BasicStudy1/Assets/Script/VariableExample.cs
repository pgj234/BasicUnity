using UnityEngine;

public class VariableExample : MonoBehaviour
{
    // 변수 선언
    public int playerScore = 0;
    public float speed = 5.5f;
    public string playerName = "Hero";
    public bool isGameOver = false;

    void Start()
    {
        // 변수 출력
        Debug.Log(string.Format("Player Name : {0}", playerName));
        Debug.Log(string.Format("Player Score : {0}", playerScore));
        Debug.Log(string.Format("Speed : {0}", speed));
        Debug.Log(string.Format("Is Game Over? : {0}", isGameOver));
    }
}
