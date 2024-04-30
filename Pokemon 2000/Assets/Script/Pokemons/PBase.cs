using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemons", menuName = "Pokemon/Create new Pokemon")]
public class PBase : ScriptableObject
{
    [SerializeField] int pokemonID;
    [SerializeField] string pokemonName;

    [TextArea]
    [SerializeField] string pokeDescription;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
