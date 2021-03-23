using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int leftScore = 0, rightScore = 0;

    public void Goal()
    {
        leftScore++;
        rightScore++;
    }
}
