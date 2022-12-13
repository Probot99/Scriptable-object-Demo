using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Cardprint : MonoBehaviour
{
    public   CardUpdate helllo;
    public Text nameText ;
    public Text descriptionText;
    public Image ArtworkImage;

    public Text manaText;
    public Text attackText;
    public Text HealthText;


    private void Start()
    {
        Debug.Log(helllo.name);
        nameText.text = helllo.name;
        descriptionText.text = helllo.description;
        ArtworkImage.sprite = helllo.artwork;
        manaText.text = helllo.manaCost.ToString();
        attackText.text = helllo.attack.ToString();
        HealthText.text = helllo.health.ToString(); 
        
    }
}
