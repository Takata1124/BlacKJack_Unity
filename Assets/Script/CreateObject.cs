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
    string preScore = "①: ";

    [SerializeField]
    GameObject playerScoreText2;
    Text pScoreText2;
    int pScore2 = 0;
    string preScore2 = "②: ";

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

    [SerializeField]
    GameObject phObj;

    [SerializeField]
    GameObject phObj2;

    [SerializeField]
    GameObject ehObj;

    GameObject Obj;
    GameObject Obj2;
    GameObject Obj3;
    GameObject Obj4;
    GameObject Obj5;
    GameObject Obj6;
    GameObject Obj7;
    GameObject Obj8;

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
    private GameObject playerObj5;
    private GameObject playerObj6;

    private Image playerImage;
    private Image playerImage2;
    private Image playerImage3;
    private Image playerImage4;

    private Sprite sprite;

    Sprite[] cardsprites;
    List<int> cards;

    int eNumber;
    int pNumber;
    int pNumber2;
    int iniNumber;

    List<int> numbers = new List<int>();

    int eNum;
    int enum1;
    int pNum;
    int pNum2;
    int pnum;

    List<int> nums = new List<int>();

    List<int> numsAA = new List<int>();
    List<int> numsBB = new List<int>();
    List<int> numsCC = new List<int>();
    List<int> numsEE = new List<int>();

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
    Button dealerObjB;

    [SerializeField]
    GameObject openObj;
    Button openObjB;

    [SerializeField]
    GameObject passObj;
    Button passObjB;

    int passN = 1;

    [SerializeField]
    GameObject addPlayerObj;
    Button addPlayerObjB;

    [SerializeField]
    GameObject addPlayerObj1;
    Button addPlayerObj1B;

    [SerializeField]
    GameObject addPlayerObj2;
    Button addPlayerObj2B;

    [SerializeField]
    GameObject spliteObj;
    Button spliteObjB;

    bool splitePressed = false;

    [SerializeField]
    GameObject switchObj;
    Button switchObjB;

    bool swithFirst = true;

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
    int transNum = 75;

    int pushNumP = 0;

    int ePushNum = 1;
    int iniEpushNum;
    int eTransNum = -75;

    int epushNumP = 0;

    int cardNum = 0;
    int pcardNum = 0;
    int ecardNum = 0;

    GameObject objA;
    RectTransform oPosA;

    GameObject pObjA;
    RectTransform pPosA;
    Image imageA;

    GameObject objB;
    RectTransform oPosB;

    GameObject pObjB;
    RectTransform pPosB;
    Image imageB;

    GameObject objC;
    RectTransform oPosC;

    GameObject pObjC;
    RectTransform pPosC;
    Image imageC;

    GameObject objD;
    RectTransform oPosD;

    GameObject pObjD;
    RectTransform pPosD;
    Image imageD;

    GameObject objZ;

    float transPosX;
    float etransPosX;

    bool checkEScorePressed = false;
    bool addEnemyPressed = false;
    bool addPushed = false;
    bool addfirst;
    bool spliteFirst;

    bool score21 = false;

    string addressStart = "進行｢ディーラーアイコンを押してください｣";
    string addressWarning = "進行｢手札が17以上になるようカードを追加してください or ゲームを降りてください｣";
    string addressBetting = "ハートをベットしてください";
    string addressSelecting = "進行｢次の行動を選択してください｣";

    int cardNumA;
    int cardNumE;

    int push = 0;

    bool addOne;
    bool addSecond;

    int pushA = 0;
    int pushB = 0;

    bool substract = true;

    int listResultAA;
    int resultAA;

    int listResultBB;
    int resultBB;

    int listResultCC;
    int resultCC;

    int listResultEE;
    int resultEE;

    bool iniGameSetUp;

    // Start is called before the first frame update
    void Start()
    {
        switchObjB = switchObj.GetComponent<Button>();

        deckiText = deckitextObj.GetComponent<Text>();
        scoreText = scoretextObj.GetComponent<Text>();
        turnText = turnTextObj.GetComponent<Text>();

        lifeText = lifeTextObj.GetComponent<Text>();
        life = 5;

        betText = BetTextObj.GetComponent<Text>();
        bet = 0;

        pNum = 0;

        pScoreText = playerScoreText.GetComponent<Text>();
        pScoreText2 = playerScoreText2.GetComponent<Text>();
        eScoreText = enemyScoreText.GetComponent<Text>();

        openObj.SetActive(false);
        openObjB = openObj.GetComponent<Button>();

        passObjB = passObj.GetComponent<Button>();
        passObjB.interactable = false;

        addPlayerObjB = addPlayerObj.GetComponent<Button>();
        addPlayerObjB.interactable = false;

        spliteObjB = spliteObj.GetComponent<Button>();

        dealerObjB = dealerObj.GetComponent<Button>();
        
        addPlayerObj1B = addPlayerObj1.GetComponent<Button>();
        addPlayerObj2B = addPlayerObj2.GetComponent<Button>();

        sound = GetComponent<AudioSource>();
        soundO = GetComponent<AudioSource>();

        StartSetup();

        CardSplites();

        IniCreatePlayer();

        IniCreateEnemy();
    }

    void StartSetup()
    {
        winTextObj.SetActive(false);
        loseTextObj.SetActive(false);
        drawtextObj.SetActive(false);
        bustTextObj.SetActive(false);

        gameOverTextObj.SetActive(false);

        phObj.SetActive(false);
        phObj2.SetActive(false);

        ehObj.SetActive(false);

        addPlayerObj.SetActive(true); 
        addPlayerObj1.SetActive(false);
        addPlayerObj2.SetActive(false);

        spliteObj.SetActive(true);

        switchObjB.interactable = false;

        splitePressed = false;
        spliteFirst = true;
        substract = true;
        addSecond = false;
        iniGameSetUp = false;

        push = 0;
        pushA = 0;
        pushB = 0;

        numsAA.Clear();
        numsBB.Clear();
        numsCC.Clear();
        numsEE.Clear();

        resultAA = 0;
        resultBB = 0;
        resultCC = 0;
        resultEE = 0;    
    }

    // Update is called once per frame
    void Update()
    {
        deckiText.text = totalCards.ToString() + afterText;
        scoreText.text = ScoreText + score.ToString();
        turnText.text = preTurnText + turn.ToString();

        if (splitePressed)
        {
            pScoreText.text = preScore + pScore.ToString();
        }
        else
        {
            pScoreText.text = pScore.ToString();
        }

        pScoreText2.text = preScore2 + pScore2.ToString();
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
        StartSetup();

        pScore = 0;
        pScore2 = 0;
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

        deckObj.SetActive(true);
        deckitextObj.SetActive(true);

        graveObj.SetActive(true);

        otransPressed = false;
        setPressed = false;
        plusPressed = false;
        plusPressed2 = false;

        checkEScorePressed = false;

        pushNum = 1;
        transNum = 75;

        ePushNum = 1;
        eTransNum = -75;

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
            objZ = GameObject.Find("player" + a.ToString());
            Destroy(objZ);
        }

        for (int a = 2; a <= iniEpushNum; a++)
        {
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

                    if (eNum == 11 | eNum == 1)
                    {
                        numsEE.Add(eNum);
                    }
                    else
                    {

                    }

                    enemyObj.SetActive(false);
                    goto default;

                case 1:
                    enemyObj2 = Instantiate(cardsObject, new Vector3(-75, 500, 0), Quaternion.identity);
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

                    if (eNum == 11 | eNum == 1)
                    {
                        numsEE.Add(eNum);
                    }
                    else
                    {

                    }

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
        imageA = pObjA.GetComponent<Image>();

        eNumber = Random.Range(0, 55);

        while (numbers.Contains(eNumber))
        {
            eNumber = Random.Range(0, 55);
        }

        imageA.sprite = cardsprites[cards[eNumber]];

        CheckENumber();

        if (eScore < 11)
        {
            if (eNum == 11 | eNum == 1)
            {
                numsEE.Add(pNum);
            }
            else
            {

            }
        }
        else
        {

        }

        pObjA.SetActive(false);

        etransPosX = etransPosX / 25;

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

                    if (pNum == 11 | pNum == 1)
                    {
                        numsAA.Add(pNum);
                        numsCC.Add(pNum);

                        int numnum = numsCC.Count;
                        Debug.Log("numnum" + numnum);

                    }
                    else
                    {

                    }

                    playerObj.SetActive(false);
                    goto default;

                case 1:
                    playerObj2 = Instantiate(cardsObject, new Vector3(75, -500, 0), Quaternion.identity);
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

                    if (pNum == 11 | pNum == 1)
                    {
                        numsBB.Add(pNum);
                        numsCC.Add(pNum);

                        int numnum2 = numsCC.Count;
                        Debug.Log("numnum2" + numnum2);

                    }
                    else
                    {

                    }

                    listResultAA = numsAA.Count;

                    playerObj2.SetActive(false);
                    goto default;

                default:
                    break;
            }
        }
    }

    public void AddPlayer()
    {
        if (splitePressed)
        {
            iniGameSetUp = false;
            spliteObjB.interactable = false;

            push = push + 1;
             
            pushNum = pushNum + 1 + 2 * (push - 1);
            pushNumP = pushNum + 1;
        
            cardNum = cardNum + 2;

            Obj5 = Instantiate(cardsObject, new Vector3(0, 0, 0), Quaternion.identity);
            Obj5.transform.SetParent(card.transform, false);
            Obj5.name = "pSample " + pushNum.ToString();

            Obj6 = Instantiate(cardsObject, new Vector3(0, 0, 0), Quaternion.identity);
            Obj6.transform.SetParent(card.transform, false);
            Obj6.name = "pSample " + pushNumP.ToString();

            objA = GameObject.Find("pSample " + pushNum.ToString());
            oPosA = objA.GetComponent<RectTransform>();

            objB = GameObject.Find("pSample " + pushNumP.ToString());
            oPosB = objB.GetComponent<RectTransform>();

            transPosX = transNum * push;

            playerObj3 = Instantiate(cardsObject, new Vector3(transPosX, -250, 0), Quaternion.identity);
            playerObj3.transform.SetParent(playereCard.transform, false);
            playerObj3.name = "player" + pushNum.ToString();

            playerObj4 = Instantiate(cardsObject, new Vector3(transPosX, -500, 0), Quaternion.identity);
            playerObj4.transform.SetParent(playereCard.transform, false);
            playerObj4.name = "player" + pushNumP.ToString();

            pObjA = GameObject.Find("player" + pushNum.ToString());
            pPosA = pObjA.GetComponent<RectTransform>();
            imageA = pObjA.GetComponent<Image>();

            pObjB = GameObject.Find("player" + pushNumP.ToString());
            pPosB = pObjB.GetComponent<RectTransform>();
            imageB = pObjB.GetComponent<Image>();

            pNumber = Random.Range(0, 55);
            pNumber2 = Random.Range(0, 55);

            while (numbers.Contains(pNumber))
            {
                pNumber = Random.Range(0, 55);
            }

            imageA.sprite = cardsprites[cards[pNumber]];

            while (numbers.Contains(pNumber2) && pNumber == pNumber2)
            {
                pNumber2 = Random.Range(0, 55);
            }

            imageB.sprite = cardsprites[cards[pNumber2]];

            CheckPNumber();

            if (pScore < 11)
            {
                if (pNum2 == 11 | pNum2 == 1)
                {
                    numsAA.Add(pNum2);
                }
                else
                {

                }
            }
            else
            {

            }

            if (pScore2 < 11)
            {
                if (pNum == 11 | pNum == 1)
                {
                    numsBB.Add(pNum);
                }
                else
                {

                }
            }
            else
            {

            }

            pObjA.SetActive(false);
            pObjB.SetActive(false);

            transPosX = transPosX / 25;

            plusPressed = true;
        }
        else
        {
            iniGameSetUp = false;
            spliteObjB.interactable = false;

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
            imageA = pObjA.GetComponent<Image>();

            pNumber = Random.Range(0, 55);

            while (numbers.Contains(pNumber))
            {
                pNumber = Random.Range(0, 55);
            }

            imageA.sprite = cardsprites[cards[pNumber]];

            CheckPNumber();

            if (pScore < 11)
            {
                if (pNum == 11 | pNum == 1)
                {
                    numsCC.Add(pNum);
                }
                else
                {

                }
            }
            else
            {

            }

            pObjA.SetActive(false);

            transPosX = transPosX / 25;

            plusPressed = true;
        }
    }

    public void Addplayer1()
    {
        addOne = true;

        switchObjB.interactable = false;

        int inipush = 1;
        int pushAA = 0;
        pushA = pushA + 1;
        pushAA = inipush + pushA;

        push = push + 1;
        pushNum = pushNumP + 1 + (push - 2);
        cardNum = cardNum + 1;

        Obj7 = Instantiate(cardsObject, new Vector3(0, 0, 0), Quaternion.identity);
        Obj7.transform.SetParent(card.transform, false);
        Obj7.name = "pSample " + pushNum.ToString();

        objC = GameObject.Find("pSample " + pushNum.ToString());
        oPosC = objC.GetComponent<RectTransform>();

        transPosX = transNum * pushAA;

        playerObj5 = Instantiate(cardsObject, new Vector3(transPosX, -500, 0), Quaternion.identity);
        playerObj5.transform.SetParent(playereCard.transform, false);
        playerObj5.name = "player" + pushNum.ToString();

        pObjC = GameObject.Find("player" + pushNum.ToString());
        imageC = pObjC.GetComponent<Image>();

        pNumber = Random.Range(0, 55);

        while (numbers.Contains(pNumber))
        {
            pNumber = Random.Range(0, 55);
        }

        imageC.sprite = cardsprites[cards[pNumber]];

        CheckPNumber();

        if (pScore < 11)
        {
            if (pNum == 11 | pNum == 1)
            {
                numsAA.Add(pNum);
            }
            else
            {

            }
        }
        else
        {

        }

        pObjC.SetActive(false);

        transPosX = transPosX / 25;

        plusPressed = true;
    }

    public void Addplayer2()
    {
        addSecond = true;

        switchObjB.interactable = false;

        int inipush = 1;
        int pushBB = 0;
        pushB = pushB + 1;
        pushBB = inipush + pushB;

        push = push + 1;

        Debug.Log("push = " + push.ToString());

        pushNum = pushNumP + 1 + (push - 2) ;
        cardNum = cardNum + 1;

        Obj8 = Instantiate(cardsObject, new Vector3(0, 0, 0), Quaternion.identity);
        Obj8.transform.SetParent(card.transform, false);
        Obj8.name = "pSample " + pushNum.ToString();

        objD = GameObject.Find("pSample " + pushNum.ToString());
        oPosD = objD.GetComponent<RectTransform>();

        transPosX = transNum * pushBB;

        playerObj6 = Instantiate(cardsObject, new Vector3(transPosX, -250, 0), Quaternion.identity);
        playerObj6.transform.SetParent(playereCard.transform, false);
        playerObj6.name = "player" + pushNum.ToString();

        pObjD = GameObject.Find("player" + pushNum.ToString());
        imageD = pObjD.GetComponent<Image>();

        pNumber = Random.Range(0, 55);

        while (numbers.Contains(pNumber))
        {
            pNumber = Random.Range(0, 55);
        }

        imageD.sprite = cardsprites[cards[pNumber]];

        CheckPNumber();

        if (pScore2 < 11)
        {
            if (pNum == 11 | pNum == 1)
            {
                numsBB.Add(pNum);
            }
            else
            {

            }
        }
        else
        {

        }

        pObjD.SetActive(false);

        transPosX = transPosX / 25;

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
        else if (pNumber <= 9)
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

        Debug.Log("pNum = " + pNum.ToString()); ;

        iniPushNum = pushNum;

        if (!addOne && !addSecond && splitePressed)
        {
            if (pNumber2 == 0)
            {
                if (pScore2 < 11)
                {
                    pNum2 = 11;
                }
                else
                {
                    pNum2 = 1;
                }
            }
            else if (pNumber2 <= 9)
            {
                pNum2 = pNumber2 + 1;
            }
            else if (10 <= pNumber2 && pNumber2 <= 13)
            {
                pNum2 = 10;
            }
            else if (pNumber2 == 14)
            {
                if (pScore2 < 11)
                {
                    pNum2 = 11;
                }
                else
                {
                    pNum2 = 1;
                }
            }
            else if (15 <= pNumber2 && pNumber2 <= 23)
            {
                pNum2 = pNumber2 - 13;
            }
            else if (24 <= pNumber2 && pNumber2 <= 27)
            {
                pNum2 = 10;
            }
            else if (pNumber2 == 28)
            {
                if (pScore2 < 11)
                {
                    pNum2 = 11;
                }
                else
                {
                    pNum2 = 1;
                }
            }
            else if (29 <= pNumber2 && pNumber2 <= 37)
            {
                pNum2 = pNumber2 - 27;
            }
            else if (38 <= pNumber2 && pNumber2 <= 41)
            {
                pNum2 = 10;
            }
            else if (pNumber2 == 42)
            {
                if (pScore2 < 11)
                {
                    pNum2 = 11;
                }
                else
                {
                    pNum2 = 1;
                }
            }
            else if (43 <= pNumber2 && pNumber2 <= 51)
            {
                pNum2 = pNumber2 - 41;
            }
            else
            {
                pNum2 = 10;
            }
            numbers.Add(pNumber2);
            nums.Add(pNum2);

            Debug.Log("pNum2 = " + pNum2.ToString());

            iniPushNum = pushNumP;
        }
        else
        {

        }
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
            Debug.Log("A" +nums[cardNum].ToString());
        }
        else
        {
            if (addPushed)
            {
                eScore = eScore + nums[cardNumE];
                addPushed = false;

                Debug.Log("カード枚数は" + cardNum.ToString());
                Debug.Log("B" + nums[cardNum].ToString());
            }
            else
            {
                cardNum = cardNum + 4;
                eScore = eScore + nums[cardNum];

                Debug.Log("カード枚数は" + cardNum.ToString());
                Debug.Log("C" + nums[cardNum].ToString());
            }
        }

        checkEScorePressed = true;
        
        //soundO.PlayOneShot(soundOpen);
    }

    void EnemyPointCheck()
    {
        if (checkEScorePressed && !score21 && eScore < 17)
        {
            if (eScore <= pScore | eScore <= pScore2)
            {
                AddEnemy();
            }
            else
            {

            }        
        }
        else if (checkEScorePressed && score21 && eScore < 21)
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
            oPos2.localPosition += new Vector3(0, 20.0f, 0);
            AudioSE();
        }

        if (otransPressed && oPos2.localPosition.y == 500 && oPos.localPosition.y > -500)
        {
            oPos.localPosition += new Vector3(0, -20.0f, 0);
            AudioSE2();
        }

        if (otransPressed && oPos.localPosition.y == -500 && oPos3.localPosition.y < 500)
        {
            oPos3.localPosition += new Vector3(-3.4f, 20.0f, 0);
            AudioSE3();
        }

        if (otransPressed && oPos3.localPosition.y == 500 && oPos4.localPosition.y > -500)
        {
            oPos4.localPosition += new Vector3(3.4f, -20.0f, 0);
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

            iniGameSetUp = true;

            enemyObj.SetActive(true);
            enemyObj2.SetActive(true);

            playerObj.SetActive(true);
            playerObj2.SetActive(true);

            Obj.SetActive(false);
            Obj2.SetActive(false);
            Obj4.SetActive(false);

            phObj.SetActive(true);
            ehObj.SetActive(true);

            int cardNumA = cardNum + 1;
            int cardNumB = cardNum + 2;
            int cardNumC = cardNum + 3;

            cardNumE = cardNum + 4;
            
            if (turn < 2)
            {
                pScore = nums[0] + nums[1];
                eScore = nums[2];

                cardNum = cardNum + 3;

                Debug.Log("D" + nums[0].ToString());
                Debug.Log("E" + nums[1].ToString());
                Debug.Log("F" + nums[2].ToString());
                Debug.Log("カード枚数は" + cardNum.ToString()) ;
                
            }
            else
            {
                pScore = nums[cardNumA] + nums[cardNumB];
                eScore = nums[cardNumC];
                addfirst = true;

                Debug.Log("G" + nums[cardNumA].ToString());
                Debug.Log("H" + nums[cardNumB].ToString());
                Debug.Log("I" + nums[cardNumC].ToString());

                Debug.Log("カード枚数は" + cardNum.ToString());
            }
            setPressed = false;
        }
    }

    void AddTransObj()
    {
        if (!addOne && !addSecond && splitePressed)
        {
            if (plusPressed && oPosA.localPosition.y > -500)
            {
                oPosA.localPosition += new Vector3(transPosX, -20.0f, 0);
                addPlayerObjB.interactable = false;
                AudioSE();
            }
            else if (plusPressed && oPosA.localPosition.y == -500 && oPosB.localPosition.y > -250)
            {
                oPosB.localPosition += new Vector3(transPosX, -10.0f, 0);
                addPlayerObjB.interactable = false;
                AudioSE2();
            }
            else if (plusPressed && oPosB.localPosition.y == -250)
            {
                if (turn > 1)
                {
                    addPushed = true;

                    if (addfirst)
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
                pressed02 = true;

                Destroy(objA);
                Destroy(objB);
                pObjA.SetActive(true);
                pObjB.SetActive(true);

                cardNumA = cardNum - 1;

                pScore = pScore + nums[cardNum];
                pScore2 = pScore2 + nums[cardNumA];
                plusPressed = false;

                switchObjB.interactable = true;

                spliteObj.SetActive(false);

                addPlayerObj.SetActive(false);

                addPlayerObj1.SetActive(true);
                addPlayerObj2.SetActive(true);

                Debug.Log("カード枚数は" + cardNum.ToString());
                Debug.Log("J" + cardNumA.ToString());
                Debug.Log("H" + nums[cardNum].ToString());
                Debug.Log("I" + nums[cardNumA].ToString());
            }
        }
        else if(!addOne && addSecond && splitePressed)
        {
            if (plusPressed && oPosD.localPosition.y > -250)
            {
                oPosD.localPosition += new Vector3(transPosX, -10.0f, 0);

                addPlayerObj1B.interactable = false;
                addPlayerObj2B.interactable = false;

                AudioSE();

                if (plusPressed && oPosD.localPosition.y == -250)
                {
                    addPlayerObj1B.interactable = true;
                    addPlayerObj2B.interactable = true;

                    pressed01 = true;

                    Destroy(objD);
                    pObjD.SetActive(true);

                    pScore2 = pScore2 + nums[cardNum];
                    plusPressed = false;

                    pushNum = pushNum + 1;

                    addSecond = false;

                    Debug.Log("カード枚数は" + cardNum.ToString());
                    Debug.Log("J" + nums[cardNum].ToString());
                }
                else
                {

                }

            }
        }
        else if (addOne && !addSecond && splitePressed)
        {
            if (plusPressed && oPosC.localPosition.y > -500)
            {
                oPosC.localPosition += new Vector3(transPosX, -20.0f, 0);

                addPlayerObj1B.interactable = false;
                addPlayerObj2B.interactable = false;

                AudioSE();

                if (plusPressed && oPosC.localPosition.y == -500)
                {
                    addPlayerObj1B.interactable = true;
                    addPlayerObj2B.interactable = true;

                    pressed01 = true;

                    Destroy(objC);
                    pObjC.SetActive(true);

                    pScore = pScore + nums[cardNum];
                    plusPressed = false;

                    pushNum = pushNum + 1;

                    addOne = false;

                    Debug.Log("カード枚数は" + cardNum.ToString());
                    Debug.Log("J" + nums[cardNum].ToString());
                }
                else
                {

                }

            }
        }
        else
        {
            if (plusPressed && oPosA.localPosition.y > -500)
            {
                oPosA.localPosition += new Vector3(transPosX, -20.0f, 0);
                addPlayerObjB.interactable = false;
                AudioSE();

                if (plusPressed && oPosA.localPosition.y == -500)
                {
                    if (turn > 1)
                    {
                        addPushed = true;

                        if (addfirst)
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

                    Destroy(objA);
                    pObjA.SetActive(true);
                    addPlayerObjB.interactable = true;

                    pScore = pScore + nums[cardNum];
                    plusPressed = false;

                    Debug.Log("カード枚数は" + cardNum.ToString());
                    Debug.Log("J" + nums[cardNum].ToString());
                }
                else
                {

                }
            }
        }
    }

    void AddTransEObj()
    {
        if (addEnemyPressed && oPosA.localPosition.y < 500)
        {
            oPosA.localPosition += new Vector3(etransPosX, 20.0f, 0);
            AudioSE();
        }
        else
        {

        }

        if (addEnemyPressed && oPosA.localPosition.y == 500)
        {
            pressed01 = true;

            Destroy(objA);
            pObjA.SetActive(true);

            ehObj.SetActive(true);

            eScore = eScore + nums[cardNum];

            Debug.Log("カード枚数は" + cardNum.ToString());
            Debug.Log("K" + nums[cardNum].ToString());

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
            dealerObjB.interactable = false;
            openObjB.interactable = false;
            
            passObjB.interactable = false;
            spliteObjB.interactable = false;

            addPlayerObjB.interactable = false;
        }
        else
        {
            dealerObjB.interactable = true;

            if (iniGameSetUp)
            {
                openObjB.interactable = true;
                passObjB.interactable = true;
                addPlayerObjB.interactable = true;
                spliteObjB.interactable = true;

            }
            else
            {

            }
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
        if (pScore == 21 | pScore2 == 21)
        {
            score21 = true;
        }
        else
        {

        }

        if (pScore > 21)
        {
            listResultAA = numsAA.Count - resultAA;
            listResultCC = numsCC.Count - resultCC;

            Debug.Log("playerAA" + listResultAA.ToString());
            Debug.Log("playerCC" + listResultCC.ToString());

            if (splitePressed)
            {
                if (listResultAA > 0)
                {
                    pScore = pScore - 10;
                    resultAA = resultAA + 1;
                }
                else
                {
                    deckitextObj.SetActive(false);
                    deckObj.SetActive(false);
                    graveObj.SetActive(false);
                    bustTextObj.SetActive(true);

                    addPlayerObjB.interactable = false;
                    openObj.SetActive(false);
                    dealerObj.SetActive(true);
                }
            }
            else
            {
                if (listResultCC > 0)
                {
                    pScore = pScore - 10;
                    resultCC = resultCC + 1;
                    Debug.Log("result");
                }
                else
                {
                    deckitextObj.SetActive(false);
                    deckObj.SetActive(false);
                    graveObj.SetActive(false);
                    bustTextObj.SetActive(true);

                    addPlayerObjB.interactable = false;
                    openObj.SetActive(false);
                    dealerObj.SetActive(true);
                }
            }
        }

        if (pScore2 > 21)
        {
            listResultBB = numsBB.Count - resultBB;

            if (splitePressed)
            {
                if (listResultBB > 0)
                {
                    pScore2 = pScore2 - 10;
                    resultBB = resultBB + 1;
                }
                else
                {
                    deckitextObj.SetActive(false);
                    deckObj.SetActive(false);
                    graveObj.SetActive(false);
                    bustTextObj.SetActive(true);

                    addPlayerObjB.interactable = false;
                    openObj.SetActive(false);
                    dealerObj.SetActive(true);
                }
            }
            else
            {

            }
        }

        if (eScore > 21)
        {
            listResultEE = numsEE.Count - resultEE;

            Debug.Log("enemy" + listResultEE.ToString());

            if (listResultEE > 0)
            {
                eScore = eScore - 10;
                resultEE = resultEE + 1;
            }
            else
            {
                deckitextObj.SetActive(false);
                deckObj.SetActive(false);
                graveObj.SetActive(false);

                bustTextObj.SetActive(true);
                openObj.SetActive(false);
                dealerObj.SetActive(true);
            }

        }

        if (pScore == 21)
        {
            addPlayerObjB.interactable = false;
            addPlayerObj1B.interactable = false;
        }

        if (pScore2 == 21)
        {
            addPlayerObj2B.interactable = false;
        }

        if (splitePressed)
        {
            if (eScore >= pScore && eScore >= pScore2 && 17 <= eScore && eScore <= 21)
            {
                deckitextObj.SetActive(false);
                deckObj.SetActive(false);
                graveObj.SetActive(false);

                openObj.SetActive(false);
                dealerObj.SetActive(true);

                if (pScore == eScore | pScore2 == eScore)
                {
                    drawtextObj.SetActive(true);
                }
                else if (pScore > eScore | pScore2 > eScore)
                {
                    winTextObj.SetActive(true);
                }
                else
                {

                }
            }
            else
            {

            }
        }
        else
        {
            if (pScore == eScore && 17 <= eScore && eScore <= 21)
            {
                drawtextObj.SetActive(true);

                deckitextObj.SetActive(false);
                deckObj.SetActive(false);
                graveObj.SetActive(false);

                openObj.SetActive(false);
                dealerObj.SetActive(true);
            }
            else if (pScore < eScore && 17 <= eScore && eScore <= 21)
            {
                loseTextObj.SetActive(true);

                deckitextObj.SetActive(false);
                deckObj.SetActive(false);
                graveObj.SetActive(false);

                openObj.SetActive(false);
                dealerObj.SetActive(true);
            }
            else if (pScore > eScore && 17 <= eScore && eScore <= 21)
            {
                winTextObj.SetActive(true);

                deckitextObj.SetActive(false);
                deckObj.SetActive(false);
                graveObj.SetActive(false);

                openObj.SetActive(false);
                dealerObj.SetActive(true);
            }
            else
            {

            }

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

    public void SpliteButton()
    {
        //if (nums[0] == nums[1])
        //{

        splitePressed = true;

        phObj2.SetActive(true);

        RectTransform pPos = playerObj2.GetComponent<RectTransform>();
        pPos.localPosition = new Vector3(0f, -250.0f, 0);

        if (turn < 2)
        {
            pScore = pScore - nums[1];
            pScore2 = nums[1];

        }
        else
        {
            int cardNumA = cardNum + 1;
            int cardNumB = cardNum + 2;

            pScore = pScore - nums[cardNumB];
            pScore2 = nums[cardNumB];
        }

        spliteFirst = false;
       
        //}
        //else
        //{

        //}
    }

    public void SwitchButton()
    {

        pPosA.localPosition = new Vector3(75, -500, 0);
        pPosB.localPosition = new Vector3(75, -250, 0);

        pScore = pScore - nums[cardNum] + nums[cardNumA];
        pScore2 = pScore2 - nums[cardNumA] + nums[cardNum];

        switchObjB.interactable = false;
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