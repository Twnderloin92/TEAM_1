using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitButtons : MonoBehaviour
{
    public ChooseUnitButton[] _seeds = new ChooseUnitButton[4];
    public ChooseUnitButton[] _stealers = new ChooseUnitButton[4];
    public ChooseUnitButton[] _booms = new ChooseUnitButton[4];
    void Start()
    {
        Init();
    }
    void Init()
    {
        var gameData = GameData.GetInstance();
        for(int i = 1; i <= 3; i++)
        {
            bool _isHave;
            gameData._unitDic.TryGetValue(_seeds[i]._unitName, out _isHave);
            if (!_isHave)
            {
                _seeds[i].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            }
        }
        for (int i = 1; i <= 3; i++)
        {
            bool _isHave;
            gameData._unitDic.TryGetValue(_stealers[i]._unitName, out _isHave);
            if (!_isHave)
            {
                _stealers[i].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            }
        }
        for (int i = 1; i <= 3; i++)
        {
            bool _isHave;
            gameData._unitDic.TryGetValue(_booms[i]._unitName, out _isHave);
            if (!_isHave)
            {
                _booms[i].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            }
        }
    }

}
