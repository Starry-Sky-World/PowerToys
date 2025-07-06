// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.ClientModel;
using System.Threading;
using System.Threading.Tasks;

using AdvancedPaste.Helpers;
using AdvancedPaste.Models;
using ManagedCommon;
using OpenAI.Moderations;

namespace AdvancedPaste.Services.OpenAI;

public sealed class PromptModerationService(IAICredentialsProvider aiCredentialsProvider) : IPromptModerationService
{
    private readonly IAICredentialsProvider _aiCredentialsProvider = aiCredentialsProvider;

    public async Task ValidateAsync(string fullPrompt, CancellationToken cancellationToken)
    {
        // Skip content moderation since the API endpoint doesn't support moderation models
        // This is a temporary workaround until moderation models are available
        Logger.LogDebug($"{nameof(PromptModerationService)}.{nameof(ValidateAsync)} skipped - moderation not available");
        await Task.CompletedTask;
    }
}
