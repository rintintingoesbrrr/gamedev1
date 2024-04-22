using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardSpawner : MonoBehaviour
{
    int cardCount = 0;
    float x = 0f;
    public GameObject cardPrefab;

    // Update is called once per frame
    void Update()
    {
        cardCount += 1;
        if (cardCount < 5) {
            x += 1.3f;
            Vector2 position = new Vector2(cardPrefab.gameObject.transform.position.x + x, cardPrefab.gameObject.transform.position.y);
            Quaternion rotation = new Quaternion();
            Instantiate(cardPrefab, position, rotation);
        }
    }
}
