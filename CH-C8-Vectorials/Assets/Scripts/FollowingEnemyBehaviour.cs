using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingEnemyBehaviour : MonoBehaviour
{
    [SerializeField]
    float movementSpeed;
    [SerializeField]
    GameObject objective;
    bool canMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DistanceToObjective() > 2f)
            canMove = true;
        else
            canMove = false;

        if (canMove)
            MoveTowardsObjective();
        //Si el jugador se acerca al enemigo, enemigo "se asusta" y  retrocede
        else
        {
            if (DistanceToObjective() < 1.99f)
                MoveBackwards();
        }
            
    }

    void MoveTowardsObjective()
    {
        transform.position = Vector3.MoveTowards(transform.position, objective.transform.position , movementSpeed * Time.deltaTime);
    }

    void MoveBackwards()
    {
        transform.Translate(Vector3.back * 2);
    }

    float DistanceToObjective()
    {
        return Vector3.Distance(transform.position, objective.transform.position);
    }
}
