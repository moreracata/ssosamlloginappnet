using test_app.Server.Endpoints;
using Microsoft.OpenApi.Models;
using test_app.Server.Models;
var builder = WebApplication.CreateBuilder(args);


// Register services
builder.Services.AddSingleton<ProductService>();
var samlSettingsData = new SamlSettings()
{
    Issuer = "https://portal.sso.us-east-1.amazonaws.com/saml/assertion/MDUwNDk0MjU2NDA5X2lucy0wNGY2Y2VlZmYxNGM1MmIy",
    AssertionConsumerServiceUrl = "https://ec2-23-22-131-175.compute-1.amazonaws.com/api/SamlConsume",
    IdentityProviderUrl = "https://portal.sso.us-east-1.amazonaws.com/saml/assertion/MDUwNDk0MjU2NDA5X2lucy0wNGY2Y2VlZmYxNGM1MmIy",
    IdentityProviderCertificate = @"MIID+zCCAuOgAwIBAgIUOdLhjggYm3A5+vUsg4KvfNBn/7swDQYJKoZIhvcNAQELBQAwgYwxCzAJBgNVBAYTAkNSMREwDwYDVQQIDAhBbGFqdWVsYTESMBAGA1UEBwwJU2FuIFJhbW9uMREwDwYDVQQKDAhDdWx0aXZhcjELMAkGA1UECwwCSVQxETAPBgNVBAMMCENhdGFsaW5hMSMwIQYJKoZIhvcNAQkBFhRtb3JlcmFjYXRhQGdtYWlsLmNvbTAeFw0yNDA4MTQxNTQ2NTFaFw0yNTA4MTQxNTQ2NTFaMIGMMQswCQYDVQQGEwJDUjERMA8GA1UECAwIQWxhanVlbGExEjAQBgNVBAcMCVNhbiBSYW1vbjERMA8GA1UECgwIQ3VsdGl2YXIxCzAJBgNVBAsMAklUMREwDwYDVQQDDAhDYXRhbGluYTEjMCEGCSqGSIb3DQEJARYUbW9yZXJhY2F0YUBnbWFpbC5jb20wggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQC+JwbTQkL72lJHM13NdhUnZ+me7Q7S4STuiZ97s8YbK0AElJOhxlElzmUlGokQ4XItxem8mEnLBCF/iMcGd5EI95DRSAFcmuMO6z20i6g7/tIKHc+w9sOjoh8l7TI3dlDjsE5NXf/PNgkIO000F6MFyuRYfBzlsmbbBWCrvR1Fd2t2R1b48tNu/xx91eMQd/v/oS9DKOTlOFoX4ufz9VvXeAIxu3u6htRblFm9LPuN4lNUsM9Gqmm+5bVjgKeCxqCt6MPZn0DO0bCznBde3lbDSHODyg7BZOpfr5SljZD9sRgrekXROl/lX1lq2SkrKK2wwn0BI7oVoLSuUELgjprRAgMBAAGjUzBRMB0GA1UdDgQWBBS7JGht3jIOTrQg/TC6Ogtssc1cfjAfBgNVHSMEGDAWgBS7JGht3jIOTrQg/TC6Ogtssc1cfjAPBgNVHRMBAf8EBTADAQH/MA0GCSqGSIb3DQEBCwUAA4IBAQAOWNPEoI8mm573htOcgw2gl6NNgzSUBsK90f2zwjTvo+7BEqxW1wr+gkrsP3LVMws4+s+QAHJkTfccEkAB7mvM/OibeJIDqD/VwKiJ6qpELeDpoN6glg+EaHg8Nh56Pp8ej8Okzw7TP3RHwfOiH+Yp2IoppIZrNnV1Y+qCYiHS084x9lffZiHyOAuZOW1nuioz+2oeZqAp+F4GJ0evJwJkXjwOcWvmxXhB447z7m8GMvTTnIjSNogdXEhNTeuhE6xLm+PVT9ciQI1Js97rmBN9WR/blUcY2wiO10CM/+OF2TDqeGhJ95b5W+kaem++U3VO1dqMwdZ3s0gvlrpyXljO",
    ServiceProviderUrl = "https://ec2-23-22-131-175.compute-1.amazonaws.com/",
    LogoutUrl = "https://ec2-23-22-131-175.compute-1.amazonaws.com/api/Logout",
    MetadataUrl = "https://ec2-23-22-131-175.compute-1.amazonaws.com/api/SPMetadataXML",
};

builder.Services.AddSingleton<SamlSettings>(samlSettingsData);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// Map endpoints
app.MapAuthEndpoints();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();