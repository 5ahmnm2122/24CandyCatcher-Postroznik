using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    public GameObject[] candyPrefab;
    private float spawnDelay;
    public Timer timer;
    public GameObject tutorialScreen;

    public void StartSpanwerAndTimer()
    {
        StartCoroutine(CandyShower());
        timer.isPlaying = true;
        tutorialScreen.SetActive(false);
    }

    private void SpawnCandy()
    {
        int randomFood = Random.Range(0, candyPrefab.Length);
        GameObject a = Instantiate(candyPrefab[randomFood]) as GameObject;
        a.transform.position = new Vector2(Random.Range(-8, 8), 8);
    }

    IEnumerator CandyShower()
    {
        while (true)
        {
            spawnDelay = Random.Range(0.4f, 0.9f);
            yield return new WaitForSeconds(spawnDelay);
            SpawnCandy();
        }
    }
}
