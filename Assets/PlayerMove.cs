using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Transform tf;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tf.position += new Vector3(0.1f, 0, 0);
    }
}
