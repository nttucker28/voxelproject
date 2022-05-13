using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverStuff : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    //private int thisscore = PlayerHealth.score;
    // Start is called before the first frame update
    void Start()
    {
        textMesh = gameObject.GetComponent<TextMeshProUGUI>();
        textMesh.text = PlayerHealth.score.ToString();
        //
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
