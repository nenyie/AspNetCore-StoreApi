using FluentValidation;
using Product.API.Application.Command.CreateProduct;

namespace Product.API.Validators
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator(ILogger<CreateProductCommandValidator> logger)
        {
            logger.LogInformation("Product validation");
            RuleFor(product => product.ProductDate).NotEmpty().WithMessage("No Product Date Found");
            RuleFor(product => product.ProductDiscount).NotEmpty().WithMessage("No ProductDiscount  Found");
            RuleFor(product => product.Coupon).NotEmpty().WithMessage("No Coupon Found");
            RuleFor(product => product.Five).NotEmpty().WithMessage("No Five Found");
            RuleFor(product => product.CouponExpiryDate).NotEmpty().WithMessage("No CouponExpiryDate Found");
            RuleFor(product => product.CouponStartDate).NotEmpty().WithMessage("No CouponStartDate Found");
            RuleFor(product => product.CouponValidityPeriod).NotEmpty().WithMessage("No CouponValidityPeriod Found");
            RuleFor(product => product.Description).NotEmpty().WithMessage("No Description Found");
            RuleFor(product => product.DiscontStartDate).NotEmpty().WithMessage("No DiscontStartDate Found");
            RuleFor(product => product.DiscountValidityPeriod).NotEmpty().WithMessage("No DiscountValidityPeriod Found");
            RuleFor(product => product.FiftyToHundred).NotEmpty().WithMessage("No FiftyToHundred Found");
            RuleFor(product => product.FreeShiping).NotEmpty().WithMessage("No FreeShiping Found");
        }
    }
}
