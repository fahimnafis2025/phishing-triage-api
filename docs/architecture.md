# Architecture — Day 1

API (ASP.NET Core 8) -> Core (header parsing + scoring) -> Enrichment (mock by default)
-> Infrastructure (in-memory now, DynamoDB + S3 later) -> Salesforce REST (Day 3, Case on Malicious)

Day 2 fills in ScoringEngine.Score. Day 3 adds the Salesforce client.
