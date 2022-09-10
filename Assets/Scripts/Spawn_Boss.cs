using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Boss : MonoBehaviour
{
    //Define variables 
    public GameObject BadBoss;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while (true)
        {
            Vector3 noise = new Vector3(Random.Range(-7f, 7f), Random.Range(-7f, 7f), 0f);
            GameObject new_BadBoss = Instantiate(BadBoss, transform.position + noise, Quaternion.identity); // spawns bullet at the boss's position
            new_BadBoss.GetComponent<Bad_Boss_Manager>().Target = player;
            yield return new WaitForSeconds(20.0f); //Interval between different bosses, current set at 2 seconds
        }
    }
    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, Destination, movementSpeed);
    }
}
