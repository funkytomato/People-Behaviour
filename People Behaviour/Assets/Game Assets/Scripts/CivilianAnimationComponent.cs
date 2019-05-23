using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Pathfinding;

public class CivilianAnimationComponent : MonoBehaviour
{
    public GameObject parent;
    private AIPath aiPath;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        if (parent != null) 
        {
            aiPath = parent.GetComponent<AIPath>();
        }
        else
        {
            Debug.Log("CivilianAnimationComponent Parent GameObject not set");
        }


        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (animator != null)
        {
            if (aiPath != null)
            {
                animator.SetFloat("Speed", aiPath.maxSpeed);
            }
            else
            {
                Debug.Log("CivilianAnimationComponent aiPath not found");
            }
        }
        else
        {
            Debug.Log("CivilianAnimationComponent animator not found");
        }

    }

    private void FixedUpdate()
    {

    }
}
