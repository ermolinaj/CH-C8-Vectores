using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizableEnemy : MonoBehaviour
{
    //Siempre asumimos que el gameobject que tenga asignado este script tiene componentes Moving/FollowingEnemyBehaviour
    enum EnemyTypes { Watcher, Follower }
    [SerializeField] EnemyTypes enemyType;

    // Start is called before the first frame update
    void Start()
    {
        switch (enemyType)
        {
            case EnemyTypes.Watcher:
                TurnIntoWatcher();
                break;
            case EnemyTypes.Follower:
                TurnIntoFollower();
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TurnIntoWatcher()
    {
        GetComponent<WatcherEnemyBehaviour>().enabled = true;
    }

    void TurnIntoFollower()
    {
        GetComponent<FollowingEnemyBehaviour>().enabled = true;
        GetComponent<WatcherEnemyBehaviour>().enabled = true;
    }
}
