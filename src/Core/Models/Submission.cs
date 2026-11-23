namespace PhishingTriage.Core.Models;

public record Submission(
    string Id, string From, string Subject,
    string[] Headers, string Body, string[] Urls, string[] Attachments);
