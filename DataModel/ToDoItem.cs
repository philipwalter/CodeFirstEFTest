using System;

namespace DataModel
{
    public class ToDoItem
    {

        public int ID { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        public System.Nullable<DateTime> DateCreated { get; set; }
        public System.Nullable<DateTime> DateModified { get; set; }

    }
}
