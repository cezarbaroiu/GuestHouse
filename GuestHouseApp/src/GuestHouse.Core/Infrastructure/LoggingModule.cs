using System;
using System.Linq;
using Autofac;
using Autofac.Core;
using GuestHouse.Core.Contracts;
using GuestHouse.Core.Infrastructure.Helpers;

namespace GuestHouse.Core.Infrastructure
{
    public class LoggingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register((c, p) =>
                new Logger(p.TypedAs<Type>())
            ).AsImplementedInterfaces();

            builder.RegisterType<LoggerConfiguration>()
                .AsSelf()
                .AutoActivate();
        }

        protected override void AttachToComponentRegistration(IComponentRegistry componentRegistry, IComponentRegistration registration)
        {
            registration.Preparing += (sender, args) =>
            {
                var forType = args.Component.Activator.LimitType;

                var logParamenter = new ResolvedParameter(
                    (p, c) => p.ParameterType == typeof(ILogger),
                    (p, c) => c.Resolve<ILogger>(TypedParameter.From(forType))
                    );

                args.Parameters = args.Parameters.Union(new[] {logParamenter});
            };
        }
    }
}
