using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class PowerUps : MonoBehaviour
{
    [SerializeField]
    private float speedIncrease = 4;
    [SerializeField]
    private float powerupDuration = 3;

    [SerializeField]
    private GameObject artToDisable = null;

    private Collider2D collider2D;

    private void Awake()
    {
        collider2D = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerControler player = other.gameObject.GetComponent<PlayerControler>();
        if (player != null)
        {
            StartCoroutine(PowerupSequence(player));
        }
    }

    public IEnumerator PowerupSequence(PlayerControler player)
    {
        collider2D.enabled = false;
        artToDisable.SetActive(false);
        ActivatePowerup(player);
        yield return new WaitForSeconds(powerupDuration);
        DeactivatePowerup(player);
        Destroy(gameObject);
    }

    private void ActivatePowerup(PlayerControler player)
    {
        player.SetMoveSpeed(speedIncrease);
    }

    private void DeactivatePowerup(PlayerControler player)
    {
        player.SetMoveSpeed(-speedIncrease);
    }
}
