using UnityEngine;
using UnityEngine.UI;

public class PlayerHPSlider : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Slider hpSlider = GetComponent<Slider>();
        hpSlider.value = 50;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
