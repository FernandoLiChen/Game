
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public GameObject bulletSpawner; // Assign this in the Unity editor
    public GameObject bulletSpawner2;
    public GameObject bulletSpawner3;
    public GameObject bulletSpawner4;
    public Image enemyHealthBar;
    public float ehealth;
    private float maxHealth;

    void Start()
    {
        maxHealth = ehealth;
        // Optionally, ensure the spawner is active at start if it's supposed to shoot immediately
        if (bulletSpawner != null)
            bulletSpawner.SetActive(true);
    }

    void Update()
    {
        enemyHealthBar.fillAmount = Mathf.Clamp(ehealth / maxHealth, 0, 1);
        
        if (ehealth <= 0)
        {
            Destroy(gameObject);
        }

        // Deactivate bullet spawner when health drops below 250
        if (ehealth <= 250 && bulletSpawner != null)
        {
            bulletSpawner.SetActive(false);
            bulletSpawner2.SetActive(true);
            bulletSpawner3.SetActive(false);
            bulletSpawner4.SetActive(false);
        }
        
    }
}
