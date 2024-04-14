using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{

    public static UnityEvent OnResetGame = new UnityEvent();

    public static void ResetGame()
    {
        OnResetGame.Invoke();
    }
}
