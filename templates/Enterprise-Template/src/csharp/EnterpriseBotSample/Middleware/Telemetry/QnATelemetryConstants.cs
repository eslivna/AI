﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace EnterpriseBotSample.Middleware.Telemetry
{
    /// <summary>
    /// The Application Insights property names that we're logging.
    /// </summary>
    public static class QnATelemetryConstants
    {
        public const string ActivityIdProperty = "activityId";
        public const string UsernameProperty = "username";
        public const string ConversationIdProperty = "conversationId";
        public const string OriginalQuestionProperty = "originalQuestion";
        public const string QuestionProperty = "question";
        public const string AnswerProperty = "answer";
        public const string ScoreProperty = "score";
        public const string ArticleFoundProperty = "qnAItemFound";
    }
}