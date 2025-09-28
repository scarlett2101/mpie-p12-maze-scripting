using UnityEngine;

public class tiltingScript : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotationVertical = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * speed;
        rotationVertical *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Rotate(rotation, 0, 0);
        transform.Rotate(0, 0, rotationVertical);

        
    }
}
