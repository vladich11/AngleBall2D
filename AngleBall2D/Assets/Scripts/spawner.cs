using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject coin;
    public GameObject badCoin;
    public GameObject ballprefab;
    public GameObject skillCoin;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ballprefab,Vector3.zero, Quaternion.identity);
        InvokeRepeating("spawnCoin", 2f,5f);
        InvokeRepeating("spawnbadCoing", 2f, 5f);
        InvokeRepeating("spawnSkillCoin", 2f, 5f);
       // old place Instantiate(ballprefab, Vector3.zero, Quaternion.identity);
    }
    private void spawnCoin()
    {
        Vector2 spawnpoint = Random.insideUnitCircle * 1.88f;
        Instantiate(coin, new Vector3(spawnpoint.x, spawnpoint.y, 0),Quaternion.identity);
    }
    private void spawnbadCoing()
    {
        Vector2 spawnpoint = Random.insideUnitCircle * 1.88f;
        Instantiate(badCoin, new Vector3(spawnpoint.x, spawnpoint.y, 0), Quaternion.identity);
    }
    private void spawnSkillCoin()
    {
        Vector2 spawnpoint = Random.insideUnitCircle * 1.88f;
        Instantiate(skillCoin, new Vector3(spawnpoint.x, spawnpoint.y, 0), Quaternion.identity);
    }
}
