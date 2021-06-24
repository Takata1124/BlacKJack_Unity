using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateObject : MonoBehaviour
{
    [SerializeField]
    GameObject deckitextObj;

    Text deckiText;

    string afterText = "枚";
    int totalCards = 54;

    [SerializeField]
    GameObject scoretextObj;
    Text scoreText;

    string ScoreText = "Total Score：";
    int score = 0;

    [SerializeField]
    GameObject turnTextObj;

    string preTurnText = "ターン：";
    Text turnText;

    int turn = 0;

    [SerializeField]
    GameObject playerScoreText;
    Text pScoreText;
    int pScore = 0;

    //enemyScoretext is created;
    [SerializeField]
    GameObject enemyScoreText;
    Text eScoreText;
    int eScore = 0;

    [SerializeField]
    GameObject winTextObj;

    [SerializeField]
    GameObject loseTextObj;

    [SerializeField]
    GameObject drawtextObj;

    [SerializeField]
    GameObject bustTextObj;

    [SerializeField]
    GameObject deckObj;

    GameObject Obj;
    GameObject Obj2;
    GameObject Obj3;
    GameObject Obj4;
    GameObject Obj5;

    RectTransform oPos;
    RectTransform oPos2;
    RectTransform oPos3;
    RectTransform oPos4;

    public GameObject card;
    public GameObject cardsObject;

    public GameObject playereCard;
    public GameObject enemyCard;

    GameObject enemyObj;
    GameObject enemyObj2;

    private Image enemyImage;
    private Image enemyImage2;

    private GameObject playerObj;
    private GameObject playerObj2;
    private GameObject playerObj3;
    private GameObject playerObj4;

    private Image playerImage;
    private Image playerImage2;
    private Image playerImage3;
    private Image playerImage4;

    private Sprite sprite;

    Sprite[] cardsprites;
    List<int> cards;

    int eNumber;
    int pNumber;
    int iniNumber;

    List<int> numbers = new List<int>();

    int eNum;
    int enum1;
    int pNum;
    int pnum;

    List<int> nums = new List<int>();

    bool otransPressed = false;
    bool setPressed = false;
    bool plusPressed = false;
    bool plusPressed2 = false;

    bool pressed01 = true;
    bool pressed02 = true;
    bool pressed03 = true;
    bool pressed04 = true;

    public AudioClip sound01;
    public AudioClip soundOpen;
    AudioSource sound;
    AudioSource soundO;

    [SerializeField]
    GameObject dealerObj;

    [SerializeField]
    GameObject openObj;

    Button openObjB;

    [SerializeField]
    GameObject passObj;

    Button passObjB;

    int passN = 1;

    [SerializeField]
    GameObject changeObj;

    Button changeObjB;

    [SerializeField]
    GameObject lifeTextObj;

    [SerializeField]
    GameObject graveObj;

    Text lifeText;
    int life;

    string lifeImage;

    [SerializeField]
    GameObject BetTextObj;

    Text betText;
    int bet;

    [SerializeField]
    GameObject gameOverTextObj;

    int pushNum = 1;
    int iniPushNum;
    int transNum = 85;

    int ePushNum = 1;
    int iniEpushNum;
    int eTransNum = -85;

    int cardNum = 0;

    GameObject objA;
    GameObject objX;
    GameObject objY;
    GameObject objZ;
    GameObject objV;

    GameObject pObjA;

    RectTransform oPosA;
    Image ImageA;

    float transPosX;
    float etransPosX;

    bool checkEScorePressed = false;
    bool addEnemyPressed = false;
    bool addPushed = false;
    bool addfirst;

    bool score21 = false;

    string addressStart = "進行｢ディーラーアイコンを押してください｣";
    string addressWarning = "進行｢手札が17以上になるようカードを追加してください or ゲームを降りてください｣";
    string addressBetting = "ハートをベットしてください";
    string addressSelecting = "進行｢次の行動を選択してください｣";

    int cardNumE;


    // Start is called before the first frame update
    void Start()
    {
        CardSplites();

        IniCreatePlayer();
        IniCreateEnemy();

        deckiText = deckitextObj.GetComponent<Text>();
        scoreText = scoretextObj.GetComponent<Text>();
        turnText = turnTextObj.GetComponent<Text>();

        lifeText = lifeTextObj.GetComponent<Text>();
        life = 5;

        betText = BetTextObj.GetComponent<Text>();
        bet = 0;

        pNum = 0;

        pScoreText = playerScoreText.GetComponent<Text>();
        eScoreText = enemyScoreText.GetComponent<Text>();

        winTextObj.SetActive(false);
        loseTextObj.SetActive(false);
        drawtextObj.SetActive(false);
        bustTextObj.SetActive(false);

        gameOverTextObj.SetActive(false);

        openObj.SetActive(false);
        openObjB = openObj.GetComponent<Button>();

        passObjB = passObj.GetComponent<Button>();
        passObjB.interactable = false;

        changeObjB = changeObj.GetComponent<Button>();
        changeObjB.interactable = false;

        sound = GetComponent<AudioSource>();
        soundO = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        deckiText.text = totalCards.ToString() + afterText;
        scoreText.text = ScoreText + score.ToString();
        turnText.text = preTurnText + turn.ToString();
        pScoreText.text = pScore.ToString();
        eScoreText.text = eScore.ToString();

        betText.text = bet.ToString();

        CheckLife();
        CheckBetting();

        JudgingScore();

        ObjTrans();
        AddTransObj();

        EnemyPointCheck();
        AddTransEObj();
    }

    void CardSplites()
    {
        cardsprites = Resources.LoadAll<Sprite>("Trump");

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
    }

    public void GameStartButton()
    {
        pScore = 0;
        eScore = 0;
        score21 = false;

        turn = turn + 1;

        if (turn >= 2)
        {
            DestroyObj();
        }
        else
        { 

        }

        winTextObj.SetActive(false);
        loseTextObj.SetActive(false);
        drawtextObj.SetActive(false);
        bustTextObj.SetActive(false);

        deckObj.SetActive(true);
        deckitextObj.SetActive(true);

        graveObj.SetActive(true);

        otransPressed = false;
        setPressed = false;
        plusPressed = false;
        plusPressed2 = false;

        checkEScorePressed = false;

        pushNum = 1;
        transNum = 85;

        ePushNum = 1;
        eTransNum = -85;

        checkEScorePressed = false;

        CreateSamples();
    }

    void DestroyObj()
    {
        Destroy(Obj);
        Destroy(Obj2);
        Destroy(Obj3);
        Destroy(Obj4);

        Destroy(playerObj);
        Destroy(playerObj2);
        Destroy(enemyObj);
        Destroy(enemyObj2);

        for(int a = 2; a <= iniPushNum; a++)
        {
            GameObject objZ = Instantiate(cardsObject, new Vector3(0, 0, 0), Quaternion.identity);
            objZ = GameObject.Find("player" + a.ToString());
            Destroy(objZ);
        }

        for (int a = 2; a <= iniEpushNum; a++)
        {
            GameObject objZ = Instantiate(cardsObject, new Vector3(0, 0, 0), Quaternion.identity);
            objZ = GameObject.Find("eplayer" + a.ToString());
            Destroy(objZ);
        }

        IniCreatePlayer();
        IniCreateEnemy();
    }

    void CreateSamples()
    {
        dealerObj.SetActive(false);

        openObj.SetActive(true);
        openObjB.interactable = false;

        winTextObj.SetActive(false);
        loseTextObj.SetActive(false);
        drawtextObj.SetActive(false);

        Obj4 = Instantiate(cardsObject, new Vector3(0, 0, 0), Quaternion.identity);
        Obj4.transform.SetParent(card.transform, false);
        Obj4.name = "Sample4";

        Obj3 = Instantiate(cardsObject, new Vector3(0, 0, 0), Quaternion.identity);
        Obj3.transform.SetParent(card.transform, false);
        Obj3.name = "Sample3";

        Obj2 = Instantiate(cardsObject, new Vector3(0, 0, 0), Quaternion.identity);
        Obj2.transform.SetParent(card.transform, false);
        Obj2.name = "Sample2";

        Obj = Instantiate(cardsObject, new Vector3(0, 0, 0), Quaternion.identity);
        Obj.transform.SetParent(card.transform, false);
        Obj.name = "Sample";
        Obj.tag = "sample";

        oPos = Obj.GetComponent<RectTransform>();
        oPos2 = Obj2.GetComponent<RectTransform>();
        oPos3 = Obj3.GetComponent<RectTransform>();
        oPos4 = Obj4.GetComponent<RectTransform>();

        otransPressed = true;
        setPressed = false;
    }

    void IniCreateEnemy()
    {
        for (int i = 0; i < 2; i++)
        {
            switch (i)
            {
                case 0:
                    enemyObj = Instantiate(cardsObject, new Vector3(0, 500, 0), Quaternion.identity);
                    enemyObj.transform.SetParent(enemyCard.transform, false);
                    enemyObj.name = "eplayer" + i.ToString();

                    enemyImage = enemyObj.GetComponent<Image>();

                    eNumber = Random.Range(0, 55);

                    while (numbers.Contains(eNumber))
                    {
                        eNumber = Random.Range(0, 55);
                    }

                    enemyImage.sprite = cardsprites[cards[eNumber]];

                    CheckENumber();

                    enemyObj.SetActive(false);
                    goto default;

                case 1:
                    enemyObj2 = Instantiate(cardsObject, new Vector3(-85, 500, 0), Quaternion.identity);
                    enemyObj2.transform.SetParent(enemyCard.transform, false);
                    enemyObj2.name = "eplayer" + i.ToString();

                    enemyImage2 = enemyObj2.GetComponent<Image>();

                    eNumber = Random.Range(0, 55);

                    while (numbers.Contains(eNumber))
                    {
                        eNumber = Random.Range(0, 55);
                    }

                    enemyImage2.sprite = cardsprites[cards[eNumber]];

                    CheckENumber();

                    enemyObj2.SetActive(false);
                    goto default;

                default:
                    break;
            }
        }
    }

    void AddEnemy()
    {
        ePushNum = ePushNum + 1;

        cardNum = cardNum + 1;

        Obj5 = Instantiate(cardsObject, new Vector3(0, 0, 0), Quaternion.identity);
        Obj5.transform.SetParent(card.transform, false);
        Obj5.name = "ESample" + ePushNum.ToString();

        objA = GameObject.Find("ESample" + ePushNum.ToString());
        oPosA = objA.GetComponent<RectTransform>();

        etransPosX = eTransNum * ePushNum;

        playerObj3 = Instantiate(cardsObject, new Vector3(etransPosX, 500, 0), Quaternion.identity);
        playerObj3.transform.SetParent(enemyCard.transform, false);
        playerObj3.name = "eplayer" + ePushNum.ToString();

        pObjA = GameObject.Find("eplayer" + ePushNum.ToString());
        ImageA = pObjA.GetComponent<Image>();

        eNumber = Random.Range(0, 55);

        while (numbers.Contains(eNumber))
        {
            eNumber = Random.Range(0, 55);
        }

        ImageA.sprite = cardsprites[cards[eNumber]];

        CheckENumber();

        pObjA.SetActive(false);

        etransPosX = etransPosX / 50;

        checkEScorePressed = false;

        addEnemyPressed = true;
    }

    void CheckENumber()
    {
        if (eNumber == 0)
        {
            if (eScore < 11)
            {
                eNum = 11;
            }
            else
            {
                eNum = 1;
            }          
        }
        if (eNumber <= 9)
        {
            eNum = eNumber + 1;
        }
        else if (10 <= eNumber && eNumber <= 13)
        {
            eNum = 10;
        }
        else if (eNumber == 14)
        {
            if (eScore < 11)
            {
                eNum = 11;
            }
            else
            {
                eNum = 1;
            }
        }
        else if (15 <= eNumber && eNumber <= 23)
        {
            eNum = eNumber - 13;
        }
        else if (24 <= eNumber && eNumber <= 27)
        {
            eNum = 10;
        }
        else if (eNumber == 28)
        {
            if (eScore < 11)
            {
                eNum = 11;
            }
            else
            {
                eNum = 1;
            }
        }
        else if (29 <= eNumber && eNumber <= 37)
        {
            eNum = eNumber - 27;
        }
        else if (38 <= eNumber && eNumber <= 41)
        {
            eNum = 10;
        }
        else if (eNumber == 42)
        {
            if (eScore < 11)
            {
                eNum = 11;
            }
            else
            {
                eNum = 1;
            }
        }
        else if (43 <= eNumber && eNumber <= 51)
        {
            eNum = eNumber - 41;
        }
        else
        {
            eNum = 10;
        }
        numbers.Add(eNumber);
        nums.Add(eNum);

        iniEpushNum = ePushNum;
    }

    void IniCreatePlayer()
    {
        for (pnum = 0; pnum < 2; pnum++)
        {
            switch (pnum)
            {
                case 0:
                    playerObj = Instantiate(cardsObject, new Vector3(0, -500, 0), Quaternion.identity);
                    playerObj.transform.SetParent(playereCard.transform, false);
                    playerObj.name = "player" + pnum.ToString();

                    playerImage = playerObj.GetComponent<Image>();

                    pNumber = Random.Range(0, 55);

                    while (numbers.Contains(pNumber))
                    {
                        pNumber = Random.Range(0, 55);
                    }

                    playerImage.sprite = cardsprites[cards[pNumber]];

                    CheckPNumber();

                    playerObj.SetActive(false);
                    goto default;

                case 1:
                    playerObj2 = Instantiate(cardsObject, new Vector3(85, -500, 0), Quaternion.identity);
                    playerObj2.transform.SetParent(playereCard.transform, false);
                    playerObj2.name = "player" + pnum.ToString();

                    playerImage2 = playerObj2.GetComponent<Image>();

                    pNumber = Random.Range(0, 55);

                    while (numbers.Contains(pNumber))
                    {
                        pNumber = Random.Range(0, 55);
                    }

                    playerImage2.sprite = cardsprites[cards[pNumber]];

                    CheckPNumber();

                    playerObj2.SetActive(false);
                    goto default;

                default:
                    break;
            }
        }
    }

    public void AddPlayer()
    {
        pushNum = pushNum + 1;

        cardNum = cardNum + 1;

        Obj5 = Instantiate(cardsObject, new Vector3(0, 0, 0), Quaternion.identity);
        Obj5.transform.SetParent(card.transform, false);
        Obj5.name = "pSample " + pushNum.ToString();

        objA = GameObject.Find("pSample " + pushNum.ToString());
        oPosA = objA.GetComponent<RectTransform>();

        transPosX = transNum * pushNum;

        playerObj3 = Instantiate(cardsObject, new Vector3(transPosX, -500, 0), Quaternion.identity);
        playerObj3.transform.SetParent(playereCard.transform, false);
        playerObj3.name = "player" + pushNum.ToString();

        pObjA = GameObject.Find("player" + pushNum.ToString());
        ImageA = pObjA.GetComponent<Image>();

        pNumber = Random.Range(0, 55);

        while (numbers.Contains(pNumber))
        {
            pNumber = Random.Range(0, 55);
        }

        ImageA.sprite = cardsprites[cards[pNumber]];

        CheckPNumber();

        pObjA.SetActive(false);

        transPosX = transPosX / 50;

        plusPressed = true;
    }

    void CheckPNumber()
    { 
        if (pNumber == 0)
        {
            if (pScore < 11)
            {
                pNum = 11;
            }
            else
            {
                pNum = 1;
            }
        }
        if (pNumber <= 9)
        {
            pNum = pNumber + 1;
        }
        else if (10 <= pNumber && pNumber <= 13)
        {
            pNum = 10;
        }
        else if (pNumber == 14)
        {
            if (pScore < 11)
            {
                pNum = 11;
            }
            else
            {
                pNum = 1;
            }
        }
        else if (15 <= pNumber && pNumber <= 23)
        {
            pNum = pNumber - 13;
        }
        else if (24 <= pNumber && pNumber <= 27)
        {
            pNum = 10;
        }
        else if (pNumber == 28)
        {
            if (pScore < 11)
            {
                pNum = 11;
            }
            else
            {
                pNum = 1;
            }
        }
        else if (29 <= pNumber && pNumber <= 37)
        {
            pNum = pNumber - 27;
        }
        else if (38 <= pNumber && pNumber <= 41)
        {
            pNum = 10;
        }
        else if (pNumber == 42)
        {
            if (pScore < 11)
            {
                pNum = 11;
            }
            else
            {
                pNum = 1;
            }
        }
        else if (43 <= pNumber && pNumber <= 51)
        {
            pNum = pNumber - 41;
        }
        else
        {
            pNum = 10;
        }
        numbers.Add(pNumber);
        nums.Add(pNum);

        iniPushNum = pushNum;
    }

    public void CheckBattleButton()
    {
        openObj.SetActive(false);
        dealerObj.SetActive(true);
        Obj3.SetActive(false);

        passObjB.interactable = false;

        if (turn < 2)
        {
            eScore = eScore + nums[3];

            Debug.Log("カード枚数は" + cardNum.ToString());
            Debug.Log(nums[cardNum]);
        }
        else
        {
            if (addPushed)
            {
                eScore = eScore + nums[cardNumE];
                addPushed = false;

                Debug.Log("カード枚数は" + cardNum.ToString());
                Debug.Log(nums[cardNum]);
            }
            else
            {
                cardNum = cardNum + 4;
                eScore = eScore + nums[cardNum];

                Debug.Log("カード枚数は" + cardNum.ToString());
                Debug.Log(nums[cardNum]);
            }
        }

        checkEScorePressed = true;

        //soundO.PlayOneShot(soundOpen);
    }

    void EnemyPointCheck()
    {
        if (checkEScorePressed && !score21 && eScore <= pScore && eScore < 17)
        {
            AddEnemy();
        }
        else if (checkEScorePressed && score21 && eScore < pScore)
        {
            AddEnemy();
        }
        else
        {

        }
    }

    //Moving some SampleObjects
    void ObjTrans()
    {
        if (otransPressed && oPos2.localPosition.y < 500)
        {
            oPos2.localPosition += new Vector3(0, 10.0f, 0);
            AudioSE();
        }

        if (otransPressed && oPos2.localPosition.y == 500 && oPos.localPosition.y > -500)
        {
            oPos.localPosition += new Vector3(0, -10.0f, 0);
            AudioSE2();
        }

        if (otransPressed && oPos.localPosition.y == -500 && oPos3.localPosition.y < 500)
        {
            oPos3.localPosition += new Vector3(-1.7f, 10.0f, 0);
            AudioSE3();
        }

        if (otransPressed && oPos3.localPosition.y == 500 && oPos4.localPosition.y > -500)
        {
            oPos4.localPosition += new Vector3(1.7f, -10.0f, 0);
            AudioSE4();
        }

        if (otransPressed && oPos4.localPosition.y == -500)
        {
            setPressed = true;
        }

        if (setPressed)
        {
            otransPressed = false;
   
            pressed01 = true;
            pressed02 = true;
            pressed03 = true;
            pressed04 = true;

            openObjB.interactable = true;

            passObjB.interactable = true;
            changeObjB.interactable = true;

            enemyObj.SetActive(true);
            enemyObj2.SetActive(true);

            playerObj.SetActive(true);
            playerObj2.SetActive(true);

            Obj.SetActive(false);
            Obj2.SetActive(false);
            Obj4.SetActive(false);

            int cardNumA = cardNum + 1;
            int cardNumB = cardNum + 2;
            int cardNumC = cardNum + 3;

            cardNumE = cardNum + 4;
            
            if (turn < 2)
            {
                pScore = nums[0] + nums[1];
                eScore = nums[2];
                cardNum = cardNum + 3;

                Debug.Log(nums[0]);
                Debug.Log(nums[1]);
                Debug.Log(nums[2]);
                Debug.Log("カード枚数は" + cardNum.ToString()) ;
                
            }
            else
            {
                pScore = nums[cardNumA] + nums[cardNumB];
                eScore = nums[cardNumC];
                addfirst = true;

                Debug.Log(nums[cardNumA]);
                Debug.Log(nums[cardNumB]);
                Debug.Log(nums[cardNumC]);

                Debug.Log("カード枚数は" + cardNum.ToString());
            }

            setPressed = false;
        }
    }

    void AddTransObj()
    {
        if (plusPressed && oPosA.localPosition.y > -500)
        {   
            oPosA.localPosition += new Vector3(transPosX, -10.0f, 0);
            AudioSE();
        }
        else
        {

        }

        if (plusPressed && oPosA.localPosition.y == -500)
        {
            if (turn > 1)
            {
                addPushed = true;

                if(addfirst)
                {
                    cardNum = cardNum + 4;
                    addfirst = false;
                }
                else
                {

                }
            }
            else
            {

            }

            pressed01 = true;

            objA.SetActive(false);
            pObjA.SetActive(true);

            pScore = pScore + nums[cardNum];
            plusPressed = false;

            Debug.Log("カード枚数は" + cardNum.ToString());
            Debug.Log(nums[cardNum]);
        }
        else
        {

        }    
    }

    void AddTransEObj()
    {
        if (addEnemyPressed && oPosA.localPosition.y < 500)
        {
            oPosA.localPosition += new Vector3(etransPosX, 10.0f, 0);
            AudioSE();
        }
        else
        {

        }

        if (addEnemyPressed && oPosA.localPosition.y == 500)
        {
            pressed01 = true;

            objA.SetActive(false);
            pObjA.SetActive(true);

            eScore = eScore + nums[cardNum];

            Debug.Log("カード枚数は" + cardNum.ToString());
            Debug.Log(nums[cardNum]);

            addEnemyPressed = false;

            checkEScorePressed = true;
        }
        else
        {

        }
    }

    public void Betting()
    {
        if (life > 0)
        {
            life = life - 1;
            bet = bet + 1;
        }
        else
        {

        }
    }

    void CheckBetting()
    {
        if (bet < 1)
        {
            openObjB.interactable = false;
            changeObjB.interactable = false;
            passObjB.interactable = false;
        }
        else
        {
            openObjB.interactable = true;
            changeObjB.interactable = true;
            passObjB.interactable = true;
        }
    }

    void CheckLife()
    {
        if (life > 5)
        {
            life = 5;
        }
        else
        {

        }

        if (life == 1)
        {
            lifeImage = "♥";
        }
        else if (life == 2)
        {
            lifeImage = "♥♥";
        }
        else if (life == 3)
        {
            lifeImage = "♥♥♥";
        }
        else if (life == 4)
        {
            lifeImage = "♥♥♥♥";
        }
        else if (life == 5)
        {
            lifeImage = "♥♥♥♥♥";
        }
        else
        {
            lifeImage = "";
            gameOverTextObj.SetActive(true);
            deckitextObj.SetActive(true);
        }

        lifeText.text = lifeImage;
    }

    void JudgingScore()
    {
        if (pScore < 17)
        {
            openObjB.interactable = false;
        }
        else if (17 <= pScore && pScore <= 21)
        {
            openObjB.interactable = true;
        }
        else
        {

        }

        if (pScore == 21)
        {
            score21 = true;
        }
        else
        {

        }

        if (pScore > 21)
        {
            deckitextObj.SetActive(false);
            deckObj.SetActive(false);
            graveObj.SetActive(false);
            bustTextObj.SetActive(true);

            changeObjB.interactable = false;
            openObj.SetActive(false);
            dealerObj.SetActive(true);
        }

        if (eScore > 21)
        {
            deckitextObj.SetActive(false);
            deckObj.SetActive(false);
            graveObj.SetActive(false);
            bustTextObj.SetActive(true);
            openObj.SetActive(false);
            dealerObj.SetActive(true);
        }
    }

    public void PassButton()
    {
        DestroyObj();

        openObj.SetActive(false);
        dealerObj.SetActive(true);

        numbers.Add(pNumber);
        numbers.Add(eNumber);

        passN = passN + 1;

        passObjB.interactable = false;
    }

    void AudioSE()
    {
        if (pressed01)
        {
            sound.PlayOneShot(sound01);
            totalCards = totalCards - 1;
            pressed01 = false;
        }
    }

    void AudioSE2()
    {
        if (pressed02)
        {
            sound.PlayOneShot(sound01);
            totalCards = totalCards - 1;
            pressed02 = false;
        }
    }

    void AudioSE3()
    {
        if (pressed03)
        {
            sound.PlayOneShot(sound01);
            totalCards = totalCards - 1;
            pressed03 = false;
        }
    }

    void AudioSE4()
    {
        if (pressed04)
        {
            sound.PlayOneShot(sound01);
            totalCards = totalCards - 1;
            pressed04 = false;
        }
    }
}