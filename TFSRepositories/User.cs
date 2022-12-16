namespace tfs.User;
public class Rootobject
{
    public string Id { get; set; }
    public Descriptor Descriptor { get; set; }
    public string ProviderDisplayName { get; set; }
    public string CustomDisplayName { get; set; }
    public string DisplayName { get; set; }
    public bool IsActive { get; set; }
    public int UniqueUserId { get; set; }
    public bool IsContainer { get; set; }
    public object[] Members { get; set; }
    public object[] MemberOf { get; set; }
    public Properties Properties { get; set; }
}

public class Descriptor
{
    public string IdentityType { get; set; }
    public string Identifier { get; set; }
}

public class Properties
{
    public string SchemaClassName { get; set; }
    public string Description { get; set; }
    public string Domain { get; set; }
    public string Account { get; set; }
    public string DN { get; set; }
    public string Mail { get; set; }
    public string SpecialType { get; set; }
    public DateTime ComplianceValidated { get; set; }
    public string DirectoryAlias { get; set; }
}
