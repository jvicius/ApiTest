using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Todo
    {
        public Guid Id { set; get; }
        public string Description { set; get; }
        public DateTime CreateDateTime { set; get; }
        public DateTime DateOfLastChange { set; get; }
        public bool Completed { set; get; }
    }
}
