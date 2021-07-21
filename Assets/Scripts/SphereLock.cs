using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereLock : MonoBehaviour
{
    public GameObject sphere;
    public float time=0f;
    public int enemyCount;
    public GameObject enemyGroup;
    int enemyct;
    float timePassed;
    bool isEnter;
    void Start()
    {
        sphere.SetActive(false);
        enemyGroup.SetActive(false);
    }
    void Update()
    {
        if(isEnter)
        {
            timePassed+=Time.deltaTime;
            if(timePassed>time)
            {
                sphere.SetActive(true);
            }
        }
        if(enemyct==enemyCount+1)
        {
            sphere.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other) 
    {
        enemyGroup.SetActive(true);
        if(other.tag=="fps")
        {
            isEnter=true;
        }
    }
    public void UpdateEnemyNumber()
    {
        enemyct++;
    }
}