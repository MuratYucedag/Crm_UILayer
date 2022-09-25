using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class UnitValidator : AbstractValidator<Unit>
    {
        public UnitValidator()
        {
            RuleFor(x => x.UnitName).NotEmpty().WithMessage("Birim adı boş geçilemez");
            RuleFor(x => x.UnitDescription).NotEmpty().WithMessage("Birim açıklaması boş geçilemez");
            RuleFor(x => x.UnitName).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri girişi yapın");
            RuleFor(x => x.UnitName).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapın");
            RuleFor(x => x.UnitDescription).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter veri girişi yapın");
            RuleFor(x => x.UnitDescription).MinimumLength(10).WithMessage("Lütfen en az 10 karakter veri girişi yapın");
        }
    }
}
