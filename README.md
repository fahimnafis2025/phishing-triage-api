# Phishing Triage API

ASP.NET Core 10 REST API that scores a suspicious email Safe / Suspicious / Malicious,
using the same v6 triage rules as my live Tines Inbox Email Triage work.

- Trust = 100 - risk. Bands: 81-100 Safe, 51-80 Suspicious, 0-50 Malicious.
- Checks SPF / DKIM / DMARC + From / Reply-To / Return-Path, extracts URLs / attachments,
  enriches with reputation providers (mock by default).
- Malicious verdicts create a Case in Salesforce via its REST API (Day 3).
- Stack: C# / ASP.NET Core 10, AWS Lambda + API Gateway, DynamoDB on-demand, S3, Cognito later.

## Status — Day 1 scaffold
Scaffold only. Scoring engine and Salesforce integration land Day 2-3.
See `../phishing-triage-api-starter-plan.md` and the 7-day plan.

## How to run (on your PC)
```
dotnet --version   # needs .NET 10 SDK
dotnet restore
dotnet test
dotnet run --project src/Api
# then: GET http://localhost:5000/health
# POST http://localhost:5000/api/v1/submissions
```

## Endpoints (v1)
- `POST /api/v1/submissions` — ingest JSON or .eml, returns submissionId + verdict
- `GET /api/v1/submissions/{id}` — submission + verdict, trust score, evidence
- `GET /api/v1/submissions?verdict=&limit=` — list, filterable by verdict
- `POST /api/v1/submissions/{id}/recheck` — re-run enrichment + scoring
- `GET /health`

## Notes
- No real API keys in this repo. Enrichment is interface-based, mock by default.
  The free VirusTotal key is optional and OFF by default — it must not be used in
  commercial / client workflows.
- No client mail in fixtures. All test mail is synthetic / anonymised.
