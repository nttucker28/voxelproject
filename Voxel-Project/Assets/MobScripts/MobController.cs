using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobController : MonoBehaviour
{
    public delegate void EnemyKilled();
    public static event EnemyKilled OnEnemyKilled;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

  
    public void die()
    {
        if (gameObject != null)
        {
            Destroy(gameObject, 3f);
        }
        if (OnEnemyKilled != null)
        {
            OnEnemyKilled();
        }
    }
}
