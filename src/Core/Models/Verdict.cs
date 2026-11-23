namespace PhishingTriage.Core.Models;

public enum Verdict { Safe, Suspicious, Malicious }

public record Evidence(
    string Spf, string Dkim, string Dmarc,
    string? SenderIp, string[] Urls);

public record TriageResult(
    Verdict Verdict, int TrustScore, string Band,
    string[] Reasons, Evidence Evidence, string[] Checked);
