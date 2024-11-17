using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Dto.QuestDtos;
using Villa.EntityLayer.Entities;

namespace Villa.BusinessLayer.Validators.QuestValidator
{
   public class CreateQuestValidator:AbstractValidator<Quest>
    {
        public CreateQuestValidator()
        {
            RuleFor(x => x.Question).NotEmpty().WithMessage("Soru Boş Bırakılamaz.");
            RuleFor(x => x.Question).MinimumLength(10).WithMessage("Minumum 10 Karekterli bir soru giriniz.");
            RuleFor(x => x.Question).MaximumLength(200).WithMessage("Maksimum 10 Karekterli bir soru giriniz.");


            RuleFor(x => x.Answer).NotEmpty().WithMessage("Cevap Boş Bırakılamaz.");
            RuleFor(x => x.Answer).MinimumLength(10).WithMessage("Minumum 10 Karekterli bir soru giriniz.");
            RuleFor(x => x.Answer).MaximumLength(200).WithMessage("Maksimum 10 Karekterli bir soru giriniz.");
        }
    }
}
