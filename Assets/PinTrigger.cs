using UnityEngine;

public class PinTrigger : MonoBehaviour
{
    [SerializeField]
    private PlayerController player;


    void OnTriggerEnter2D(Collider2D obj)
    {
        player.UpdateHealth(5);
        Destroy(gameObject);
    }
}