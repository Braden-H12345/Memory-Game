using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomPattern : MonoBehaviour
{
    [SerializeField] Image redImage;

    private List<string> strList;
    private List<string> gamePatternList;
    private int numberGenerated;

    private float currTime = 0;
    private float lastTime = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        strList = new List<string>();
    }

    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime;
        if(currTime - lastTime > 5)
        {
            numberGenerated = Random.Range(1, 100);

            //red if less than 25
            if (numberGenerated <= 25)
            {
                addToList("red");
                StartCoroutine(blinkRed());
                StopCoroutine(blinkRed());
                //UserInput();
            }
            //green if between 25 and 50
            else if (numberGenerated > 25 && numberGenerated <= 50)
            {
                addToList("green");
                //blinkGreen();
                //UserInput();
            }
            //blue if between 50 and 75
            else if (numberGenerated > 50 && numberGenerated <= 75)
            {
                addToList("blue");
                //blinkBlue();
                //UserInput();
            }
            //yellow if greater than 75
            else
            {
                addToList("yellow");
                //blinkYellow();
                //UserInput();
            }
        }

        lastTime = Time.deltaTime;
        
    }

    public void addToList(string s)
    {
        strList.Add(s);
    }

    public void addRed()
    {
        gamePatternList.Add("red");
    }

    public void addGreen()
    {
        gamePatternList.Add("green");
    }

    public void addBlue()
    {
        gamePatternList.Add("blue");
    }

    public void addYellow()
    {
        gamePatternList.Add("yellow");
    }

    IEnumerator blinkRed()
    {
        Color baseColor = redImage.color, tempColor = redImage.color;
        tempColor.a = 0.5f;
        redImage.color = tempColor;
        yield return new WaitForSeconds(1f);
        redImage.color = baseColor;
    }

}
