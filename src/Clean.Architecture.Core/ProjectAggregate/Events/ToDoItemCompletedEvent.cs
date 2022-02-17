using RegexWebSite.Core.ProjectAggregate;
using RegexWebSite.SharedKernel;

namespace RegexWebSite.Core.ProjectAggregate.Events;

public class ToDoItemCompletedEvent : BaseDomainEvent
{
  public ToDoItem CompletedItem { get; set; }

  public ToDoItemCompletedEvent(ToDoItem completedItem)
  {
    CompletedItem = completedItem;
  }
}
