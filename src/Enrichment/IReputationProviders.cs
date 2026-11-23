namespace PhishingTriage.Enrichment;

// Interface-based, mock by default. Real providers behind env-var keys only.
// Free VirusTotal key stays optional and OFF by default — must not be used
// in commercial / client workflows.
public interface IUrlReputation { Task<string> CheckAsync(string url); }
public interface IIpReputation { Task<string> CheckAsync(string ip); }
public interface IDomainReputation { Task<string> CheckAsync(string domain); }

public class MockUrlReputation : IUrlReputation
{
    public Task<string> CheckAsync(string url) => Task.FromResult("not seen");
}
