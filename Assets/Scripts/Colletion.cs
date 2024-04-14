using UnityEngine;
using TMPro;

public class CoinCollector : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score = 0;

    void Start()
    {
        score = 0;
        UpdateScoreText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            score += 1;
            Destroy(other.gameObject);
            UpdateScoreText();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            score += 1;
            Destroy(collision.gameObject);
            UpdateScoreText();
        }
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Keys: " + score.ToString();
        }
    }

    public void ResetCollection()
    {
        score = 0;
        UpdateScoreText();
    }
}
