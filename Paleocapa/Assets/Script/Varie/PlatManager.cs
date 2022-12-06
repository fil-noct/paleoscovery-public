using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatManager : MonoBehaviour
{
    public static PlatManager Instance = null;

    [SerializeField]
    GameObject platformPrefab = null;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else if (Instance != this)
            Destroy(gameObject);

    }

    IEnumerator SpawnPlatform(Vector2 spawnPosition)
    {
        yield return new WaitForSeconds(3f);
            Instantiate(platformPrefab, spawnPosition, platformPrefab.transform.rotation);
    }
}