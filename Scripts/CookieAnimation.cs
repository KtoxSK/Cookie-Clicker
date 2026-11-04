using System.Collections;
using UnityEngine;

public class CookieAnimation : MonoBehaviour
{
    Vector3 startScale;

    private void Start()
    {
        startScale = transform.localScale;
    }

    public void AnimateClick()
    {
        StopAllCoroutines();
        StartCoroutine(ClickAnimation());
    }

    IEnumerator ClickAnimation()
    {
        transform.localScale = startScale * 0.9f;

        yield return new WaitForSecondsRealtime(0.05f);

        transform.localScale = startScale;
    }
}