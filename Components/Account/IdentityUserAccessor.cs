using Feedora_revised.Data;
using Microsoft.AspNetCore.Identity;

namespace Feedora_revised.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<Feedora_revisedUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<Feedora_revisedUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
