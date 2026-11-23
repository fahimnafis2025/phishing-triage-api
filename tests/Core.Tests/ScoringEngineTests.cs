using PhishingTriage.Core.Scoring;
using Xunit;

namespace PhishingTriage.Core.Tests;

// Day 2: add fixtures here — Safe (209.85.220.41, SPF/DKIM/DMARC pass + aligned),
// Suspicious (SPF fail / lure phrase), Malicious (auth-fail + impersonation).
public class ScoringEngineTests
{
    [Theory]
    [InlineData(95, "Safe")]
    [InlineData(70, "Suspicious")]
    [InlineData(20, "Malicious")]
    public void BandFor_ReturnsCorrectBand(int trust, string expected)
        => Assert.Equal(expected, ScoringEngine.BandFor(trust));
}
