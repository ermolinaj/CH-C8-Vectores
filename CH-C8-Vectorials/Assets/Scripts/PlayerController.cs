using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float rotationYAxisVariation;
    [SerializeField] float speed;
    [SerializeField] float rotationSpeed;
    public bool moving;

    // Start is called before the first frame update
    void Start()
    {
        rotationYAxisVariation = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            Move(Vector3.forward);
        if (Input.GetKey(KeyCode.S))
            Move(Vector3.back);
        if (Input.GetKey(KeyCode.D))
            Move(Vector3.right);
        if (Input.GetKey(KeyCode.A))
            Move(Vector3.left);
        if (Input.GetKey(KeyCode.Q))
            Rotate(-0.1f);
        if (Input.GetKey(KeyCode.E))
            Rotate(0.1f);
        
    }

    void Move(Vector3 direction)
    {
        moving = true;
        transform.Translate(speed * Time.deltaTime * direction);
        moving = false;
    }

    void Rotate(float variation)
    {
        rotationYAxisVariation += variation;
        
        // Quaternion newRotation = Quaternion.LookRotation((transform.position - direction));
        transform.rotation = Quaternion.Euler(0f, rotationYAxisVariation * rotationSpeed, 0f);
    }
}
