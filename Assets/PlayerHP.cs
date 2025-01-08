using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Text HPText = GetComponent<Text>();
        HPText.text = "100";
        HPText.color = new Color(1f, 0f, 0f/1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
