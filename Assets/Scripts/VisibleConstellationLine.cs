using UnityEngine;

public class VisibleConstellationLine : MonoBehaviour
{
    GameObject lines;            // Linesゲームオブジェクト

    void Start()
    {
        // 親からLinesを検索する
        var consstellation = transform.GetComponentInParent<DrawConstellation>();
        lines = consstellation.LinesParent;
        // 星座線を非表示にする
        lines.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        // レイヤーがViewHitかどうか
        if (other.gameObject.layer == LayerMask.NameToLayer("ViewHit"))
        {
            // コライダーに当たらなくなったら非表示にする
            lines.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        // レイヤーがViewObjectかどうか
        if (other.gameObject.layer == LayerMask.NameToLayer("ViewHit"))
        {
            // コライダーに当たらなくなったら非表示にする
            lines.SetActive(false);
        }
    }
}