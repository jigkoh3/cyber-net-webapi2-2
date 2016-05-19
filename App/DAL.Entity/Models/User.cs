using DAL.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity.Models
{
    public class Users : EntityBase
    {
        //facebook profile
        //{
        //  "id": "10202867439560482",
        //  "first_name": "Theerasak",
        //  "last_name": "Tubrit",
        //  "birthday": "08/02/1978",
        //  "gender": "male",
        //  "email": "jigkoh3@hotmail.com",
        //  "picture": {
        //    "data": {
        //      "url": "https://fbcdn-profile-a.akamaihd.net/hprofile-ak-xpa1/v/t1.0-1/p50x50/1914558_10207345241742738_1468652976330975842_n.jpg?oh=7405c6fdd6c8a20b415e7d2b88011952&oe=57770E46&__gda__=1467229561_86c630b47d0c7e70b3ab68291382b66b"
        //    }
        //  },
        //  "cover": {
        //    "id": "10207345217822140",
        //    "offset_y": 50,
        //    "source": "https://scontent.xx.fbcdn.net/hphotos-xfl1/v/t1.0-9/1559654_10207345217822140_8921992760712417650_n.jpg?oh=061d3768779bac4e96f7b5ffe9563dc2&oe=5775C790"
        //  }
        //}
        [Key]
        public string id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string birthday { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string picture { get; set; }
        public string cover { get; set; }

    }
}
