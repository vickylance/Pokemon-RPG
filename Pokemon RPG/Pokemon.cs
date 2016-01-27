using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_RPG
{
    class Pokemon : IPokemon
    {
        private string _name;
        private int _natIndex;
        private string _description;
        private PokeType _type1;
        private PokeType? _type2;
        private int _hp;
        private int _attack;
        private int _defense;
        private int _speAttack;
        private int _speDefense;
        private int _speed;
        private int _level;
        private GrowthRate _growthRate;
        private float _catchRate;
        private int _baseHappiness;
        private int _baseExp;
        private float _height;
        private float _weight;
        private List<Moves> _movelist;
        private Variant _variantType;
        private Trained _trainerType;
        private Item _holdItem;
        private bool _tradedOrNot;
        private int _ev;
        private int _iv;
        private Sex _gender;

        public Sex Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public int IV
        {
            get { return _iv; }
            set { _iv = value; }
        }

        public int EV
        {
            get { return _ev; }
            set { _ev = value; }
        }

        public bool TradedOrNot
        {
            get { return _tradedOrNot; }
            set { _tradedOrNot = value; }
        }

        public Item HoldItem
        {
            get { return _holdItem; }
            set { _holdItem = value; }
        }

        public Trained TrainedType
        {
            get { return _trainerType; }
            set { _trainerType = value; }
        }

        public Variant VariantType
        {
            get { return _variantType; }
            set { _variantType = value; }
        }
        
        public List<Moves> MoveList
        {
            get { return _movelist; }
            set { _movelist = value; }
        }

        public float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public float Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public int BaseExp
        {
            get { return _baseExp; }
            set { _baseExp = value; }
        }

        public int BaseHappiness
        {
            get { return _baseHappiness; }
            set { _baseHappiness = value; }
        }

        public float CatchRate
        {
            get { return _catchRate; }
            set { _catchRate = value; }
        }


        public GrowthRate GrowRate
        {
            get { return _growthRate; }
            set { _growthRate = value; }
        }

        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public int SpeDefense
        {
            get { return _speDefense; }
            set { _speDefense = value; }
        }

        public int SpeAttack
        {
            get { return _speAttack; }
            set { _speAttack = value; }
        }

        public int Defense
        {
            get { return _defense; }
            set { _defense = value; }
        }

        public int Attack
        {
            get { return _attack; }
            set { _attack = value; }
        }

        public int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }

        public PokeType? Type2
        {
            get { return _type2; }
            set { _type2 = value; }
        }

        public PokeType Type1
        {
            get { return _type1; }
            set { _type1 = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int NatIndex
        {
            get { return _natIndex; }
            set { _natIndex = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

    }
}
