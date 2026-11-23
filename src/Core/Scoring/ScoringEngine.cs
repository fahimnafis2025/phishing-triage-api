using PhishingTriage.Core.Models;

namespace PhishingTriage.Core.Scoring;

// Ported from Tines Inbox Email Triage v6 — implemented Day 2.
// Trust = 100 - risk. Bands: 81-100 Safe, 51-80 Suspicious, 0-50 Malicious.
// Strong -> Malicious. Deceptive -> Suspicious alone.
// Context -> counts only if >=2 groups or >=20 pts AND sender not trusted.
public static class ScoringEngine
{
    public static string BandFor(int trustScore)
        => trustScore >= 81 ? "Safe" : trustScore >= 51 ? "Suspicious" : "Malicious";

    public static TriageResult Score(Submission submission, Evidence evidence)
        => throw new NotImplementedException("Day 2: implement v6 scoring here");
}
