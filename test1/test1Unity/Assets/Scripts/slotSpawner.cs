using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotSpawner : MonoBehaviour
{
    int slotCount = 0;
    float x = 0f;
    public GameObject slotPrefab;
    // Update is called once per frame
    void Update()
    {
        slotCount += 1;
        if (slotCount < 3) {
            x += 1.3f;
            Vector2 position = new Vector2(slotPrefab.gameObject.transform.position.x + x, slotPrefab.gameObject.transform.position.y);
            Quaternion rotation = new Quaternion();
            Instantiate(slotPrefab, position, rotation);
        }
        
    }
}
