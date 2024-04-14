using UnityEngine;
using UnityEngine.Events;

public class ResettableObject : MonoBehaviour
{
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private bool originalActiveState;
    private PlayerHealth playerHealth;
    private CoinCollector coinCollector;

    private void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
        originalActiveState = gameObject.activeSelf;
        playerHealth = GetComponent<PlayerHealth>();
        coinCollector = GetComponent<CoinCollector>();
    }

    private void OnEnable()
    {
        GameManager.OnResetGame.AddListener(ResetObject);
    }

    private void OnDisable()
    {
        GameManager.OnResetGame.RemoveListener(ResetObject);
    }

    private void ResetObject()
    {
        gameObject.SetActive(originalActiveState);
        transform.position = originalPosition;
        transform.rotation = originalRotation;

        if (playerHealth != null)
        {
            playerHealth.ResetHealth();
        }

        if (coinCollector != null)
        {
            coinCollector.ResetCollection();
        }

        Debug.Log("Object reset: " + gameObject.name);
    }
}
