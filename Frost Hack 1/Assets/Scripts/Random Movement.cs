using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.AI;
public class RandomMovement : MonoBehaviour
{
    public float Timer;
    public int newTarget;
    public float speed;

    public NavMeshAgent nav;
    public Vector3 target;

    void Start()
    {
        nav = gameObject .GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if(Timer >= newTarget)
        {
            newtarget();
            Timer = 0;
        }
    }

    void newtarget()
    {
        float myX = gameObject.transform.position.x;
        float myz = gameObject.transform.position.z;

        float xPos = myX + Random.Range(myX - 100,myX + 100);
        float zPos = myz + Random.Range(myz - 100,myz + 100);

        target = new Vector3(xPos,gameObject.transform.position.y,zPos);

        nav.SetDestination(target);
    }
}

