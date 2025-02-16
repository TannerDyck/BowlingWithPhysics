using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    private FallTrigger[] pins;

    private void Start()
    {
        //We find all objects of type FallTrigger
        pins = FindObjectsByType<FallTrigger>((FindObjectsSortMode)FindObjectsInactive.Include);

        //We then loop over our array of pins and add the
        // IncrementScore function as their listener
        foreach (FallTrigger pin in pins)
        {
            pin.OnPinFall.AddListener(IncrementScore);
        }
    }

    private void IncrementScore()
    {
        score++;
        scoreText.text = $"Score: {score}";
    }
}