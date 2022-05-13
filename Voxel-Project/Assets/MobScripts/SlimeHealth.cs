using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SlimeHealth : MonoBehaviour
{

    public int health;
    public int maxHealth = 100;
    //public Slider slider;

    void Start()
    {
        if (MainMenu.difficulty == "EasyBtn") maxHealth = 100;
        if (MainMenu.difficulty == "NormalBtn") maxHealth = 200;
        if (MainMenu.difficulty == "HardBtn") maxHealth = 300;
        
        health = maxHealth;
        //slider.value = CalculateHealth();
    }
    void Update()
    {
        //slider.value = CalculateHealth();

        if (health <= 0)
        {
            PlayerHealth.score += maxHealth;
            Destroy(gameObject);
            //SceneManager.LoadScene("MainMenu");
        }
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
    float CalculateHealth()
    {
        return health / maxHealth;
    }
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.name == "HitboxAttack")
        {
            health -= 50;

        }
       

    }
}
