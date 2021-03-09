using System;
using UnityMVVM.Model;

namespace TestScroll.Model
{
    [Serializable]
    public class PlayerAccountModel : ModelBase
    {
        public int Rating { get; private set; }
        public string Name { get; private set; }


        public PlayerAccountModel(int rating, string name)
        {
            Rating = rating;
            Name = name;
        }
    }
}
