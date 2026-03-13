using ECommerce.Discount.Entity.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Discount.Business.Validators
{
    public class CouponValidator:AbstractValidator<Coupon>

    {
        public CouponValidator()
        {
            RuleFor(x => x.Code).NotEmpty().WithMessage("Kod boş olamaz");
            RuleFor(x => x.DiscountRate).NotEmpty().WithMessage("İndirim oranı boş olamaz");
            RuleFor(x => x.ExpireDate).NotEmpty().WithMessage("Son geçerlilik tarihi  boş olamaz");
        }
    }
}
