using UnityEngine;
using System.Collections;

public class AutoCookie : MonoBehaviour
{
    public float interval = 1f;
    public int cookiesPerSecond = 1;

    private bool isActive = false;

    public void ActivateAutoCookie()
    {
        if (!isActive)
        {
            isActive = true;
            StartCoroutine(AutoFarm());
        }
    }

    IEnumerator AutoFarm()
    {
        while (isActive)
        {
            yield return new WaitForSeconds(interval);

            Var.score += cookiesPerSecond;
            The.gameUI.UpdateScore();
        }
    }
}