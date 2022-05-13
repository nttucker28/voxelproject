using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverTimeStuff : MonoBehaviour
{
    private TextMeshProUGUI textMesh;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = gameObject.GetComponent<TextMeshProUGUI>();
        textMesh.text = PlayerHealth.timer.ToString();
        //
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
