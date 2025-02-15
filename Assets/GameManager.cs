using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    private FallTrigger[] pins;
    private void Start(){
        pins = FindObjectsOfType<FallTrigger>(true);
       //pins = FindObjectsByType<FallTrigger>(FindObjectsInactive.Include); (this line was causing errors)
        foreach(FallTrigger pin in pins){
            pin.OnPinFall.AddListener(IncrementScore);
        }
    }
    private void IncrementScore(){
        score++;
        scoreText.text = $"Score: {score}";
    }
}
