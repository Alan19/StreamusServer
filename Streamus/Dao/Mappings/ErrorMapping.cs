﻿using System;
using FluentNHibernate.Mapping;
using Streamus.Domain;

namespace Streamus.Dao.Mappings
{
    public class ErrorMapping : ClassMap<Error>
    {
        public ErrorMapping()
        {
            Table("[Errors]");

            Id(e => e.Id).GeneratedBy.GuidComb().UnsavedValue(Guid.Empty);

            //  Only update properties which have changed.
            DynamicUpdate();

            Map(e => e.Message).Not.Nullable();
            Map(e => e.LineNumber).Not.Nullable();
            Map(e => e.Url).Not.Nullable();
            Map(e => e.ClientVersion).Not.Nullable();
            Map(e => e.TimeOccurred).Not.Nullable();
            Map(e => e.OperatingSystem).Not.Nullable();
            Map(e => e.Architecture).Not.Nullable();
        }
    }
}