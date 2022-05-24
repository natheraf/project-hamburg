using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    private const float offsetX = -1.5f;
    private const float startX = 10.33f;
    private const float startY = -4.41f;
    private const float startZ = 1f;
    private static int numberOfActiveDice = 0;

    [SerializeField] Dice dicePrefab;
    private Dice newDice;
    private List<Dice> diceList = new List<Dice>();

    public void addNewDice() {
        // Create a new dice
        newDice = Instantiate(dicePrefab) as Dice;
        // Set random face
        newDice.SetRandomFace();
        // Add the dice to the list
        diceList.Add(newDice);
        // Set the position of the dice
        newDice.transform.position = new Vector3(startX + offsetX * numberOfActiveDice++, startY, startZ);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
