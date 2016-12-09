using System;

namespace Cratis.Events.Specs.for_EventStream
{
    public class SimpleEvent : Event
    {
        public SimpleEvent(Guid eventSourceId, long id) : base(eventSourceId,id)
        {
            
        }

        public SimpleEvent(Guid eventSourceId) : this(eventSourceId,0)
        {
        }


        public string Content { get; set; }
    }
}