using Machine.Specifications;

namespace Cratis.Events.Specs.for_EventStream
{
    class when_creating_a_new_committed_event_stream : given.an_empty_committed_event_stream
    {
        It should_have_no_events = () => EventStream.HasEvents.ShouldBeFalse();
        It should_be_an_empty_collection = () => EventStream.Count.ShouldEqual(0);
    }
}
