using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private Transform horseTransform;
    [SerializeField] private TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText.text = "Score : " + horseTransform.position.z.ToString("0");
    }
}