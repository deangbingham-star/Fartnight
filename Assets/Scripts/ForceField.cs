/*
using UnityEngine;

public class ForceField : MonoBehaviour
{

    public float shrinkWaitTime;
    public float shrinkAmount;
    public float shrinkDuration;
    public float minShrinkAmount;
    public int playerDamage;
    private float lastShrinkEndTime;
    private bool shrinking;
    private float targetDiameter;
    private float lastPlayerCheckTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    //shrink
    void Shrink()
    {
        shrinking = true;

        if(transform.localScale.x - shrinkAmount > minShrinkAmount)
        {
            targetDiameter -= shrinkAmount;
        }
        else
        {
            targetDiameter = minShrinkAmount;
        }
        lastShrinkEndTime = shrinkWaitTime.time + shrinkDuration;
    }

    void Start()
    {
     lastShrinkEndTime = shrinkWaitTime.time;
     targetDiameter = transform.localScale.x;   
    }

    // Update is called once per frame
    void Update()
    {
        if(shrinking)
        {
            transform.localScale = Vector3.MoveTowards(transform.localScale, Vector3.one * targetDiameter, (shrinkAmount/shrinkDuration)*shrinkWaitTime.deltaTime);

            if(transform.localScale.x == targetDiameter)
            {
                shrinking = false;
            }
            else
            {
                //can shrink again?
                if(Time.time - lastShrinkEndTime >= shrinkWaitTime && transform.localScale.x > minShrinkAmount)
                {
                    shrinkAmount();
                }
            }
        }
    }
}

*/