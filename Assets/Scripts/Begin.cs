using UnityEngine;
using TMPro;

public class Begin : MonoBehaviour
{
    public TextMeshProUGUI tmpText;
    private bool isPlayerInside = false;

    private void Start()
    {
        if (tmpText != null)
        {
            tmpText.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInside = true;
            if (tmpText != null)
            {
                tmpText.gameObject.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInside = false;
            if (tmpText != null)
            {
                tmpText.gameObject.SetActive(false);
            }
        }
    }

    private void Update()
    {
        if (isPlayerInside && tmpText != null)
        {
            tmpText.gameObject.SetActive(true);
        }
    }
}
