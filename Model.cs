using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public Coins() { }
    private int _amount;

    public bool TryDiscard(int price)
    {
        if (_amount < price)
            return false;

        _amount -= price;

        _render.text = $"Coins: {_amount}";
        _animator.SetTrigger("OnPickupCoin");
        PlayerPrefs.SetInt("Coins", _amount);

        return true;
    }
}
