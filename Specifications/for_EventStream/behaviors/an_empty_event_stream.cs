using System;
using Cratis.Events.Specs.for_EventStream.given;
using Machine.Specifications;

namespace Cratis.Events.Specs.behaviors
{
    [Behaviors]
    public class an_empty_event_stream
    {
        protected static EventStream EventStream;

        private It should_have_no_events = () => EventStream.HasEvents.ShouldBeFalse();
        private It should_be_an_empty_collection = () => EventStream.Count.ShouldEqual(0);
    }
}