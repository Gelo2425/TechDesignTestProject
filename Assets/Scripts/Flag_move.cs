using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag_move : MonoBehaviour
{
    public GameObject Flag = null;

    private Animator _moveFlagAnimator = null;
    
    void Start()
    {
        _moveFlagAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool flag = false;

        if (Input.GetMouseButton(0))
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            PolygonCollider2D coll = Flag.GetComponent<PolygonCollider2D>();

            if (coll.OverlapPoint(wp))
            {
                flag = true;
            }
        }

        _moveFlagAnimator.SetBool("flag", flag);
    }
}
