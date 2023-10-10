using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAttack : MonoBehaviour
{
    public float maxDistance = 0.25f;
    public string cactusTag = "Cactus";
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (animator != null)
        {
            if (Input.GetKey(KeyCode.W))
            {
                animator.SetTrigger("TrWalk");
                Debug.Log("mergi fa");
            }

            GameObject[] cactuses = GameObject.FindGameObjectsWithTag(cactusTag);
            for (int i = 0; i < cactuses.Length - 1; i++)
            {
                for (int j = i + 1; j < cactuses.Length; j++)
                {
                    float distance = Vector3.Distance(cactuses[i].transform.position, cactuses[j].transform.position);
                    if (distance < maxDistance)
                    {
                        animator.SetTrigger("TrAttack");
                    }
                }
            }
        }
    }
}
