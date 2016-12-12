using Machine.Specifications;

namespace Cratis.Events.Specs.for_EventStream
{
    public class when_appending_an_event_to_an_uncommitted_event_stream : given.an_empty_uncommitted_event_stream
    {
        static IEvent Event;

        Establish context =
            () =>
                {
                    Event = new SimpleEvent(EventStream.EventSourceId);
                };

        Because of = () => EventStream.Append(Event);


        It should_have_events = () => EventStream.HasEvents.ShouldBeTrue();
        It should_have_an_event_count_of_1 = () => EventStream.Count.ShouldEqual(1);
    }
}