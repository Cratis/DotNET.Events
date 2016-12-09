using System.Collections.Generic;
using Cratis.Events;
using Cratis.Events.Specs.behaviors;
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

#pragma warning disable 0169
        Behaves_like<an_event_stream_with_one_event_appended> an_event_stream;
#pragma warning restore 0169        

    }
}