using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public GameObject hpGameObject;
    void Start()
    {
        Text text = hpGameObject.GetComponent<Text>();
        text.text = "50";
    }
}
