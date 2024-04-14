using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;

    public GameObject deathPanel;
    private bool hasTakenDamage = false;

    private void Start()
    {
        currentHealth = maxHealth;
        if (deathPanel != null)
        {
            deathPanel.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap") && !hasTakenDamage)
        {
            TakeDamage(1);
            hasTakenDamage = true;
            Invoke("ResetDamageFlag", 1f);
        }
    }

    private void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (deathPanel != null)
        {
            deathPanel.SetActive(true);
        }
    }

    private void ResetDamageFlag()
    {
        hasTakenDamage = false;
    }

    public void ResetHealth()
    {
        currentHealth = maxHealth; // Reset health to maxHealth
        hasTakenDamage = false;
        if (deathPanel != null)
        {
            deathPanel.SetActive(false);
        }
    }
}
