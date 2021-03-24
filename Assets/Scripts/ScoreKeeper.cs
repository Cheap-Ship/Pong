using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI leftScoreTxt;
    [SerializeField] TextMeshProUGUI rightScoreTxt;
    int leftScore = 0, rightScore = 0;

    public void Goal(Wall.WallName collision)
    {
        if(collision == Wall.WallName.Right)
        {
            leftScore++;
            leftScoreTxt.text = leftScore.ToString();
        } else if(collision == Wall.WallName.Left) {
            rightScore++;
            rightScoreTxt.text = rightScore.ToString();
        }
    }
}
