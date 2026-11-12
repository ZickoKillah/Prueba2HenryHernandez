using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    [SerializeField] Gem gemPrefab;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float respawnDelay;
    
    
    
    void OnEnable()
    {
        GameEvents.OnTargetDestroyed += OnTargetDestroyed;
    }

    void OnDisable()
    {
        GameEvents.OnTargetDestroyed -= OnTargetDestroyed;
    }

    void OnTargetDestroyed(GameItem gameItem)
    {
        StartCoroutine(Start());

    }
    IEnumerator Start()
    {
        yield return new WaitForSeconds(respawnDelay);
        Gem gem = Instantiate(gemPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
