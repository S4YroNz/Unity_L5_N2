using UnityEngine;
using UnityEngine.UI;

public class CoinsPresenter : MonoBehaviour
{
    private Root _init;

    public void Init(Root init)
    {
        _init = init;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Contains("Coin"))
            OnPickupCoin();
    }

    public void OnPickupCoin()
    {
        _init._coins._amount++;
        _render.text = $"Coins: {_init._coins._amount}";
        _animator.SetTrigger("OnPickupCoin");
        PlayerPrefs.SetInt("Coins", _init._coins._amount);
    }
}
