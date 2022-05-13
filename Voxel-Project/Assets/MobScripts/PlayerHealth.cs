using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public static int score = 0;
    public static int timer = 0;

    //public static HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        //HealthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {   
            timer = (int)Time.timeSinceLevelLoad;
            SceneManager.LoadScene("GameOver");
        }

    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        //healthBar.SetHealth(currentHealth);
    }
    void OnCollisionEnter(Collision collision)
    {
        //if (collision.collider.gameObject.CompareTag("Enemy"))
        //{          
        //    TakeDamage(20);
        //}
        if (collision.gameObject.name == "SlimeAtPlayer(Clone)")
        {
            TakeDamage(20);
        }


        //if (collision.gameObject.tag == "Enemy")
        //{
        //    SceneManager.LoadScene("MainMenu");
        //    //TakeDamage(20);
        //}
    }

}
