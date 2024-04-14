using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    public Button resetButton;
    void Start()
    {
        resetButton.onClick.AddListener(ResetGame);
    }

    void ResetGame()
    {    
        Debug.Log("Reset button clicked.");
        GameManager.ResetGame();
    }
}
