namespace test_app.Server.Models;

    public class SamlSettings
{
    public string Issuer { get; set; }
    public string AssertionConsumerServiceUrl { get; set; }
    public string IdentityProviderUrl { get; set; }
    public string IdentityProviderCertificate { get; set; }
    public required string ServiceProviderUrl { get; set; }
    public required string LogoutUrl { get; set; }
    public required string MetadataUrl { get; set; }
}

