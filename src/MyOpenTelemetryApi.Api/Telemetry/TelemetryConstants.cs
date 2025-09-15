namespace MyOpenTelemetryApi.Api.Telemetry;

public static class TelemetryConstants
{
    public const string ServiceName = "MyOpenTelemetryApi";

    // Activity names
    public static class Activities
    {
        public const string ContactService = "ContactService";
        public const string GroupService = "GroupService";
        public const string TagService = "TagService";
        public const string DatabaseOperation = "DatabaseOperation";
    }

    // Metric names
    public static class Metrics
    {
        public const string ContactsCreated = "contacts.created";
        public const string ContactsDeleted = "contacts.deleted";
        public const string ContactSearches = "contacts.searches";
        public const string DatabaseQueryDuration = "db.query.duration";
    }

    // Tag names
    public static class Tags
    {
        public const string ContactId = "contact.id";
        public const string GroupId = "group.id";
        public const string TagId = "tag.id";
        public const string SearchTerm = "search.term";
        public const string ResultCount = "result.count";
        public const string OperationType = "operation.type";
    }
}
