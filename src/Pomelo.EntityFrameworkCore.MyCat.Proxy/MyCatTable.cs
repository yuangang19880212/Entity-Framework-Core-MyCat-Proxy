﻿namespace Pomelo.EntityFrameworkCore.MyCat.Proxy
{
    public class MyCatTable
    {
        public string TableName { get; set; }

        public string[] Keys { get; set; }

        public bool IsAutoIncrement { get; set; }

        public string[] DataNodes { get; set; }
    }
}
