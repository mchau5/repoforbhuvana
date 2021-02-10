using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public GameObject doorObject;
    public int totalChips = 2;
    int currentChipCount;

    // Start is called before the first frame update
    void Start()
    {
        currentChipCount = 0;

    }

    // whenever the player collects a chip we will add a point
    public void AddChip()
    {
        currentChipCount++;


        if (currentChipCount == totalChips)
        {
            Destroy(doorObject);

        }
    }
}
