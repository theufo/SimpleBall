using UnityEngine.UI;
using UnityEngine;

public class HealthBarController : MonoBehaviour
{
    [SerializeField]
    private GameObject bar;

    [SerializeField]
    private Text text;


    private int currentHealth;
    private int maxHealth;

    void Start()
    {
        bar.transform.localScale = new Vector3(currentHealth / 10 *20, 8f, 1f);
        text.text = currentHealth.ToString();
    }

    public void Initialize(int max, int current)
    {
        maxHealth = max;
        currentHealth = current;
        UpdateHealth(currentHealth);
    }
     
    public void UpdateHealth(int newHealth)
    {
        if (newHealth <= maxHealth && newHealth >= 0)
        {
            currentHealth = newHealth;
            bar.transform.localScale = new Vector3(currentHealth / 10 * 20, 8f, 1f);
            text.text = currentHealth.ToString();
        }
    }
}