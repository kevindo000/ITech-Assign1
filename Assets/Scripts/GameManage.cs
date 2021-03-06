using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManage : MonoBehaviour
{
    public int points = 0;
    public List<Transform> spawnPoints;
    public GameObject templateObjective;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        spawnObjective();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void obtainPoints(int x)
    {

        points = points + x;
        updateScore();
        Debug.Log(points);
    }
    public void spawnObjective()
    {
        foreach (var spawnPoint in spawnPoints)
        {
            GameObject cubePoint = Instantiate(templateObjective);
            cubePoint.transform.position = spawnPoint.position;
            cubePoint.GetComponent<Objective>().point = Random.Range(1, 1000);
        }

    }
    public void updateScore()
    {

        score.text = points.ToString();

    }



}
