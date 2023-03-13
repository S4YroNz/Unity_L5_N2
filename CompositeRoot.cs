using UnityEngine;
using UnityEngine.UI;

public class CompositeRoot : MonoBehaviour
{
    [SerializeField] private Text _render;
    [SerializeField] private Animator _animator;
    [SerializeField] private CoinsPresenter _coinsPresenter;

    private Coins _coins;

    public Coins Coins => _coins;

    private void Awake()
    {
        _coins = new Coins();
        _coins._amount = PlayerPrefs.GetInt("Coins", 0);

        _coinsPresenter.Init(this);
    }
}
