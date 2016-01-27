using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_RPG
{
    interface IPokemon
    {
        string Name { get; set; }
        int NatIndex { get; set; }
        string Description { get; set; }
        PokeType Type1 { get; set; }
        PokeType? Type2 { get; set; }
        int HP { get; set; }
        int Attack { get; set; }
        int Defense { get; set; }
        int SpeAttack { get; set; }
        int SpeDefense { get; set; }
        int Speed { get; set; }
        int Level { get; set; }
        GrowthRate GrowRate { get; set; }
        float CatchRate { get; set; }
        int BaseHappiness { get; set; }
        int BaseExp { get; set; }
        float Height { get; set; }
        float Weight { get; set; }
        List<Moves> MoveList { get; set; }
        Variant VariantType { get; set; }
        Trained TrainedType { get; set; }
        Item HoldItem { get; set; }
        bool TradedOrNot { get; set; }
        int EV { get; set; }
        int IV { get; set; }
        Sex Gender { get; set; }

    }
}
