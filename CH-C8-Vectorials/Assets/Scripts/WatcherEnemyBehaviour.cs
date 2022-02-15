using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatcherEnemyBehaviour : MonoBehaviour
{
    [SerializeField]
    float rotationSpeed;
    [SerializeField]
    GameObject objective;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookAtPlayer();
    }

    void LookAtPlayer()
    {
        Quaternion newRotation = Quaternion.LookRotation(objective.transform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, rotationSpeed + Time.deltaTime);
    }
}
