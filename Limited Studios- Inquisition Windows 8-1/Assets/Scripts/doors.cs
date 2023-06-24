using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class doors : MonoBehaviour
{
    EnemyAI enemy;
    PlayerMovement player;

    public Transform d1c, d2c, d3c, d4c, d5c, d6c, d7c, d8c, d9c, d10c,
       d11c, d12c, d13c, d14c, d15c, d16c, d17c, d18c, wallsMain, posts,
        wallsAngled, wallsRooms, doorOb, torches, keys, traps;

    public Transform d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12,
        d13, d14, d15, d16, d17, d18;

    bool key1, key2, key3, key4, key5, key6, key7, key8, key9, key10,
        key11, key12, key13, key14, key15, key16, key17, key18, walls = false;

    int keyPickUp = 0;

    public int change;

    public Image keyIMG1;
    public Image keyIMG2;
    public Image keyIMG3;
    public Image keyIMG4;
    public Image keyIMG5;
    public Image keyIMG6;
    public Image keyIMG7;
    public Image keyIMG8;
    public Image keyIMG9;
    public Image keyIMG10;
    public Image keyIMG11;
    public Image keyIMG12;
    public Image keyIMG13;
    public Image keyIMG14;
    public Image keyIMG15;
    public Image keyIMG16;
    public Image keyIMG17;
    public Image keyIMG18;


    public void ChangeToScene(int changeToScene)
    {
        SceneManager.LoadScene(changeToScene);
    }

    private void Update()
    {
        if (keyPickUp == 1)
        {
            keyIMG1.gameObject.SetActive(true);            
        }
        if (keyPickUp == 2)
        {
            keyIMG2.gameObject.SetActive(true);
        }
        if (keyPickUp == 3)
        {
            keyIMG3.gameObject.SetActive(true);
        }
        if (keyPickUp == 4)
        {
            keyIMG4.gameObject.SetActive(true);
        }
        if (keyPickUp == 5)
        {
            keyIMG5.gameObject.SetActive(true);
        }
        if (keyPickUp == 6)
        {
            keyIMG6.gameObject.SetActive(true);
        }
        if (keyPickUp == 7)
        {
            keyIMG7.gameObject.SetActive(true);
        }
        if (keyPickUp == 8)
        {
            keyIMG8.gameObject.SetActive(true);
        }
        if (keyPickUp == 9)
        {
            keyIMG9.gameObject.SetActive(true);
        }
        if (keyPickUp == 10)
        {
            keyIMG10.gameObject.SetActive(true);
        }
        if (keyPickUp == 11)
        {
            keyIMG11.gameObject.SetActive(true);
        }
        if (keyPickUp == 12)
        {
            keyIMG12.gameObject.SetActive(true);
        }
        if (keyPickUp == 13)
        {
            keyIMG13.gameObject.SetActive(true);
        }
        if (keyPickUp == 14)
        {
            keyIMG14.gameObject.SetActive(true);
        }
        if (keyPickUp == 15)
        {
            keyIMG15.gameObject.SetActive(true);
        }
        if (keyPickUp == 16)
        {
            keyIMG16.gameObject.SetActive(true);
        }
        if (keyPickUp == 17)
        {
            keyIMG17.gameObject.SetActive(true);
        }
        if (keyPickUp == 18)
        {
            keyIMG18.gameObject.SetActive(true);
        }   
        if (keyPickUp == 20)
        {
            keyIMG1.gameObject.SetActive(false);
            keyIMG2.gameObject.SetActive(false);
            keyIMG3.gameObject.SetActive(false);
            keyIMG4.gameObject.SetActive(false);
            keyIMG5.gameObject.SetActive(false);
            keyIMG6.gameObject.SetActive(false);
            keyIMG7.gameObject.SetActive(false);
            keyIMG8.gameObject.SetActive(false);
            keyIMG9.gameObject.SetActive(false);
            keyIMG10.gameObject.SetActive(false);
            keyIMG11.gameObject.SetActive(false);
            keyIMG12.gameObject.SetActive(false);
            keyIMG13.gameObject.SetActive(false);
            keyIMG14.gameObject.SetActive(false);
            keyIMG15.gameObject.SetActive(false);
            keyIMG16.gameObject.SetActive(false);
            keyIMG17.gameObject.SetActive(false);
            keyIMG18.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key1") && !key18)
        {
            other.gameObject.SetActive(false);
            key1 = true;
            keyPickUp = 1;
        }
        if (other.gameObject.CompareTag("Key2") && !key18)
        {
            other.gameObject.SetActive(false);
            key2 = true;
            keyPickUp = 2;
        }
        if (other.gameObject.CompareTag("Key3") && !key18)
        {
            other.gameObject.SetActive(false);
            key3 = true;
            keyPickUp = 3;
        }
        if (other.gameObject.CompareTag("Key4") && !key18)
        {
            other.gameObject.SetActive(false);
            key4 = true;
            keyPickUp = 4;
        }
        if (other.gameObject.CompareTag("Key5") && !key18)
        {
            other.gameObject.SetActive(false);
            key5 = true;
            keyPickUp = 5;
        }
        if (other.gameObject.CompareTag("Key6") && !key18)
        {
            other.gameObject.SetActive(false);
            key6 = true;
            keyPickUp = 6;
        }
        if (other.gameObject.CompareTag("Key7") && !key18)
        {
            other.gameObject.SetActive(false);
            key7 = true;
            keyPickUp = 7;
        }
        if (other.gameObject.CompareTag("Key8") && !key18)
        {
            other.gameObject.SetActive(false);
            key8 = true;
            keyPickUp = 8;
        }
        if (other.gameObject.CompareTag("Key9") && !key18)
        {
            other.gameObject.SetActive(false);
            key9 = true;
            keyPickUp = 9;
        }
        if (other.gameObject.CompareTag("Key10") && !key18)
        {
            other.gameObject.SetActive(false);
            key10 = true;
            keyPickUp = 10;
        }
        if (other.gameObject.CompareTag("Key11") && !key18)
        {
            other.gameObject.SetActive(false);
            key11 = true;
            keyPickUp = 11;
        }
        if (other.gameObject.CompareTag("Key12") && !key18)
        {
            other.gameObject.SetActive(false);
            key12 = true;
            keyPickUp = 12;
        }
        if (other.gameObject.CompareTag("Key13") && !key18)
        {
            other.gameObject.SetActive(false);
            key13 = true;
            keyPickUp = 13;
        }
        if (other.gameObject.CompareTag("Key14") && !key18)
        {
            other.gameObject.SetActive(false);
            key14 = true;
            keyPickUp = 14;
        }
        if (other.gameObject.CompareTag("Key15") && !key18)
        {
            other.gameObject.SetActive(false);
            key15 = true;
            keyPickUp = 15;
        }
        if (other.gameObject.CompareTag("Key16") && !key18)
        {
            other.gameObject.SetActive(false);
            key16 = true;
            keyPickUp = 16;
        }
        if (other.gameObject.CompareTag("Key17") && !key18)
        {
            other.gameObject.SetActive(false);
            key17 = true;
            keyPickUp = 17;
        }
        if (other.gameObject.CompareTag("Key18") && !key18)
        {
            other.gameObject.SetActive(false);
            key18 = true;
            keyPickUp = 18;
        }
        if (other.gameObject.CompareTag("Key20"))
        {
            other.gameObject.SetActive(false);
            key18 = true;
            walls = true;
            keyPickUp = 18;
        }

        //------------------------------------------------------------------------------------------------------------------------

        if (key1 == true && other.gameObject.CompareTag("D1"))
        {
            //Debug.Log("Key 1");
            keyPickUp = 20;
            other.gameObject.SetActive(false);
            d1c.gameObject.SetActive(false);
            d1.gameObject.SetActive(true);
        }
        if (key2 == true && other.gameObject.CompareTag("D2"))
        {
            //Debug.Log("Key 2");
            keyPickUp = 20;
            other.gameObject.SetActive(false);
            d2c.gameObject.SetActive(false);
            d2.gameObject.SetActive(true);
        }
        if (key3 == true && other.gameObject.CompareTag("D3"))
        {
            //Debug.Log("Key 3");
            keyPickUp = 20;
            other.gameObject.SetActive(false);
            d3c.gameObject.SetActive(false);
            d3.gameObject.SetActive(true);
        }
        if (key4 == true && other.gameObject.CompareTag("D4"))
        {
            //Debug.Log("Key 4");
            keyPickUp = 20;
            other.gameObject.SetActive(false);
            d4c.gameObject.SetActive(false);
            d4.gameObject.SetActive(true);
        }
        if (key5 == true && other.gameObject.CompareTag("D5"))
        {
            //Debug.Log("Key 5");
            keyPickUp = 20;
            other.gameObject.SetActive(false);
            d5c.gameObject.SetActive(false);
            d5.gameObject.SetActive(true);
        }
        if (key6 == true && other.gameObject.CompareTag("D6"))
        {
            //Debug.Log("Key 6");
            keyPickUp = 20;
            other.gameObject.SetActive(false);
            d6c.gameObject.SetActive(false);
            d6.gameObject.SetActive(true);
        }
        if (key7 == true && other.gameObject.CompareTag("D7"))
        {
            //Debug.Log("Key 7");
            keyPickUp = 20;
            other.gameObject.SetActive(false);
            d7c.gameObject.SetActive(false);
            d7.gameObject.SetActive(true);
        }
        if (key8 == true && other.gameObject.CompareTag("D8"))
        {
            //Debug.Log("Key 8");
            keyPickUp = 20;
            other.gameObject.SetActive(false);
            d8c.gameObject.SetActive(false);
            d8.gameObject.SetActive(true);
        }
        if (key9 == true && other.gameObject.CompareTag("D9"))
        {
            //Debug.Log("Key 9");
            keyPickUp = 20;
            other.gameObject.SetActive(false);
            d9c.gameObject.SetActive(false);
            d9.gameObject.SetActive(true);
        }
        if (key10 == true && other.gameObject.CompareTag("D10"))
        {
            //Debug.Log("Key 10");
            keyPickUp = 20;
            other.gameObject.SetActive(false);
            d10c.gameObject.SetActive(false);
            d10.gameObject.SetActive(true);
        }
        if (key11 == true && other.gameObject.CompareTag("D11"))
        {
            //Debug.Log("Key 11");
            keyPickUp = 20;
            other.gameObject.SetActive(false);
            d11c.gameObject.SetActive(false);
            d11.gameObject.SetActive(true);
        }
        if (key12 == true && other.gameObject.CompareTag("D12"))
        {
            //Debug.Log("Key 12");
            keyPickUp = 20;
            other.gameObject.SetActive(false);
            d12c.gameObject.SetActive(false);
            d12.gameObject.SetActive(true);
        }
        if (key13 == true && other.gameObject.CompareTag("D13"))
        {
            //Debug.Log("Key 13");
            keyPickUp = 20;
            d13c.gameObject.SetActive(false);
            d13.gameObject.SetActive(true);
        }
        if (key14 == true && other.gameObject.CompareTag("D14"))
        {
            //Debug.Log("Key 14");
            keyPickUp = 20;
            other.gameObject.SetActive(false);
            d14c.gameObject.SetActive(false);
            d14.gameObject.SetActive(true);
        }
        if (key15 == true && other.gameObject.CompareTag("D15"))
        {
            //Debug.Log("Key 15");
            keyPickUp = 20;
            other.gameObject.SetActive(false);
            d15c.gameObject.SetActive(false);
            d15.gameObject.SetActive(true);
        }
        if (key16 == true && other.gameObject.CompareTag("D16"))
        {
            //Debug.Log("Key 16");
            keyPickUp = 20;
            other.gameObject.SetActive(false);
            d16c.gameObject.SetActive(false);
            d16.gameObject.SetActive(true);
        }
        if (key17 == true && other.gameObject.CompareTag("D17"))
        {
            //Debug.Log("Key 17");
            keyPickUp = 20;
            other.gameObject.SetActive(false);
            d17c.gameObject.SetActive(false);
            d17.gameObject.SetActive(true);
        }
        if (key18 == true && other.gameObject.CompareTag("D18"))
        {
            //Debug.Log("Key 18");
            keyPickUp = 20;
            other.gameObject.SetActive(false);
            d18c.gameObject.SetActive(false);
            d18.gameObject.SetActive(true);
            ChangeToScene(change);
        }
        if (walls == true)
        {            
            wallsMain.gameObject.SetActive(false);
            wallsRooms.gameObject.SetActive(false);
            posts.gameObject.SetActive(false);
            wallsAngled.gameObject.SetActive(false);
            doorOb.gameObject.SetActive(false);
            torches.gameObject.SetActive(false);
            keys.gameObject.SetActive(false);
            traps.gameObject.SetActive(false);
            tag = "Cheat";
            
        }

    }
}