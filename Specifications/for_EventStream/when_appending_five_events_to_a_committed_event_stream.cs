using System.Collections.Generic;
using Machine.Specifications;

namespace Cratis.Events.Specs.for_EventStream
{
    public class when_appending_five_events_to_a_committed_event_stream : given.an_empty_committed_event_stream
    {
        static List<IEvent> Events;

        Establish context =
            () =>
                {
                    Events = new List<IEvent>();
                    var version = EventSourceVersion.Zero.NextCommit();
                    for (var i = 0; i < 5; i++ )
                    {
                        Events.Add(new SimpleEvent(EventSourceId) { Version = version });
                        version = version.NextSequence();
                    } 
                };

        Because of = () => EventStream.Append(Events);

        It should_have_events = () => EventStream.HasEvents.ShouldBeTrue();
        It should_have_an_event_count_of_5 = () => EventStream.Count.ShouldEqual(5);

    }
}