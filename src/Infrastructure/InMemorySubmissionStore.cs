using PhishingTriage.Core.Models;
using System.Collections.Concurrent;

namespace PhishingTriage.Infrastructure;

// Day 1-2: in-memory store behind the same interface DynamoDB will use later.
public class InMemorySubmissionStore
{
    private readonly ConcurrentDictionary<string, TriageResult> _store = new();
    public void Save(string id, TriageResult result) => _store[id] = result;
    public TriageResult? Get(string id) => _store.TryGetValue(id, out var r) ? r : null;
}
