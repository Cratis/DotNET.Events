using System.Collections.Generic;
using Machine.Specifications;

namespace Cratis.Events.Specs.for_EventStream
{
    public class when_appending_an_event_to_a_committed_event_stream : given.an_empty_committed_event_stream
    {
        static IEvent Event;

        Establish context =
            () =>
                {
                    Event = new SimpleEvent(EventSourceId) { Version = new EventSourceVersion(1, 0) }; 
                };

        Because of = () => EventStream.Append(new List<IEvent>() { Event });

        It should_have_events = () => EventStream.HasEvents.ShouldBeTrue();
        It should_have_an_event_count_of_1 = () => EventStream.Count.ShouldEqual(1);

    }
}