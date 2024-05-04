using UnityEngine;
using UnityEngine.UI;

public class ChestScripts : MonoBehaviour
{
    public PotionScript Potion;
    public Sprite SpriteButton;

    private void Start()
    {
        
    }
    private void Update()
    {
        UseChest();
        
    }

    private void UseChest()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Potion.Potion += Random.Range(3, 5);
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        
        if(other.gameObject.tag == "Potion")
        {
            UseChest();
        }
    }
}
