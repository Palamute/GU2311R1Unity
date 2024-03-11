using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    
    [SerializeField]private int Maxhealth=100;
    [SerializeField] private int currentHealth;
    [SerializeField] private int _coin = 0;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = Maxhealth;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Damager"))
        {
            currentHealth -= 80;
            Destroy(other.gameObject);
            EventManagerGame.onHealth?.Invoke(currentHealth);
        }
        if (other.gameObject.CompareTag("Coin"))
        {
            _coin += 1;
            Destroy(other.gameObject);
            EventManagerGame.onCoin?.Invoke(_coin);
        }
    }
}
