﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatVeXemPhim.Models
{
    public class File
    {
        public int FileId { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public int MovieID { get; set; }
        public virtual Movie Movie { get; set; }

    }
}