using System;
using UnityMVVM.Model;

namespace TestScroll.Model
{
    [Serializable]
    public class PlayerAccountModel : ModelBase
    {
        public int Rating { get; }
        public string Name { get; }


        public PlayerAccountModel(int rating, string name)
        {
            Rating = rating;
            Name = name;
        }
    }
}
