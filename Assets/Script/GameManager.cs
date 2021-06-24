using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{ 
 

    Sprite[] cardsprites;

    List<int> cards;

    private Image secretImage;
    private Image playerImage;
    private Image enemyImage;


    public Camera camera_object;
    private RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        PlayerShffle();

        

        

        cardsprites = Resources.LoadAll<Sprite>("Trump");
    }

    // Update is called once per frame\\
    void Update()
    {
        playerImage.sprite = cardsprites[cards[0]];
        enemyImage.sprite = cardsprites[cards[1]];
    }

    public void OnOpenButton()
    {
        Destroy(secretImage);
    }

    private void PlayerShffle()
    {
        if (cards == null)
        {
            cards = new List<int>();
        }
        else
        {
            cards.Clear();
        }


        for (int i = 0; i < 55; i++)
        {
            cards.Add(i);
        }

        int n = cards.Count;

        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            int temp = cards[k];
            cards[k] = cards[n];
            cards[n] = temp;           
        }
    }

    void CheckTouch()
    {
        Ray ray = camera_object.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit))
        {
            string objName = hit.collider.gameObject.name;
            Debug.Log(objName);
        }
    }

    public void DestroyObj()
    {
        Destroy(gameObject);
    }
}
