using System;
using System.Security.Claims;
using System.Web;
using Microsoft.Owin.Security;

namespace GpsMonitor.Mvc.Models.Shared
{
    public class AppUser : ClaimsPrincipal
    {
        public AppUser(ClaimsPrincipal principal)
            : base(principal)
        { }

        private IAuthenticationManager AuthenticationManager => HttpContext.Current.GetOwinContext().Authentication;

        public int UserId => Convert.ToInt32(AuthenticationManager.User.FindFirst(ClaimTypes.Sid).Value);

        public string CompanyUser => AuthenticationManager.User.Identity.IsAuthenticated 
            ? AuthenticationManager.User.FindFirst(ClaimTypes.NameIdentifier).Value : string.Empty;

        public string Country => FindFirst(ClaimTypes.Country).Value ?? string.Empty;

        public string MailUser => AuthenticationManager.User.Identity.IsAuthenticated 
            ? AuthenticationManager.User.FindFirst(ClaimTypes.Email).Value : string.Empty;

        public string Perfil => AuthenticationManager.User.Identity.IsAuthenticated 
            ? AuthenticationManager.User.FindFirst(ClaimTypes.Role).Value : string.Empty;

        public int PerfilId => AuthenticationManager.User.Identity.IsAuthenticated 
            ? Convert.ToInt32(AuthenticationManager.User.FindFirst("PerfilId").Value) : 0;
    }
}