using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject spawnLocation;
    public GameObject player;
    public Vector3 respawnLocation;
    // Start is called before the first frame update
    void Start()
    {
        player = (GameObject)Resources.Load("PlayerCapsule", typeof(GameObject));
        spawnLocation = GameObject.FindGameObjectWithTag("Spawnpoint");
        respawnLocation = player.transform.position;
        SpawnCharacter();

    }
        
    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnCharacter()
    {
        GameObject.Instantiate(player, spawnLocation.transform.position, Quaternion.identity);
    }
}
