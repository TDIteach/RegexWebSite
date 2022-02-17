using Autofac;
using RegexWebSite.Core.Interfaces;
using RegexWebSite.Core.Services;

namespace RegexWebSite.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}
