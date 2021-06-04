using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoadTrigger : MonoBehaviour
{
    [SerializeField] private Text TextScore;
    public float Score = 0;

    public void AddScore(float score)
    {
        Score += score;
        TextScore.text = Score.ToString();
    }
}
