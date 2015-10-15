using DataAnnotationsExtensions.ClientValidation;
using ExpressiveAnnotations.Attributes;
using ExpressiveAnnotations.MvcUnobtrusive.Validators;
using System.Web.Mvc;

[assembly: WebActivator.PreApplicationStartMethod(typeof(DieCup.App_Start.RegisterClientValidationExtensions), "Start")]
 
namespace DieCup.App_Start {
    public static class RegisterClientValidationExtensions {
        public static void Start() {
            DataAnnotationsModelValidatorProviderExtensions.RegisterValidationExtensions();
            DataAnnotationsModelValidatorProvider.RegisterAdapter(
                typeof(RequiredIfAttribute), typeof(RequiredIfValidator));
            DataAnnotationsModelValidatorProvider.RegisterAdapter(
                typeof(AssertThatAttribute), typeof(AssertThatValidator));
        }
    }
}