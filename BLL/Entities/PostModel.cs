﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class PostModel
    {
        public int PostId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
        public int Score { get; set; }
        public int views { get; set; }
        public string Body { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public int AnswerCount { get; set; }
        public int ComentsCount { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }

    }
}
