using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class Touch : MonoBehaviour
{
    // カウント用変数
    int Cnt;
    // 結果表示用変数
    int result;
    // タイマー用変数
    int timer;

    // フレーム毎に呼ばれる関数
    void Update()
    {
        // マウスがクリックされたら
        if (Input.GetMouseButtonDown(0))
        {
            // カウントを増やす
            Cnt++;
        }

        //カウントをTextコンポーネントへ 
        this.GetComponent<Text>().text = Cnt + "クリック";

        // もしtimerが500以上になったら
        if (timer > 300)
        {
            // カウントを0に戻す
            //カウントをTextコンポーネントへ 
            this.GetComponent<Text>().text = "結果は" + result + "クリックでした～";
        }
        else
        {
            result = Cnt;
        }
        // タイマーを増やす
        timer++;
    }
}