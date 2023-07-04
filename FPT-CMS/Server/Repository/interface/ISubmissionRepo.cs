﻿using Server.Entity;

namespace Server.Repository.@interface;

public interface ISubmissionRepo
{
    Submission GetSubmissionById(int submissionId);
    Submission AddSubmission(Submission submission);
    Submission UpdateSubmission(Submission submission);
    Submission GetExactSubmission(int topicId, int studentId);
    Submission DelteSubmission(int submissionId);
    List<Submission> GetSubmissionsOfTopic(int topicId);
}