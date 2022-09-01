using System;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator : AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail Adresi Boş Geçilemez");
			RuleFor(x => x.WriterName).NotEmpty().WithMessage("Ad Soyad Kısmı Boş Geçilemez");
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Parola kısmı Boş Geçilemez");
			RuleFor(x => x.WriterImage).NotEmpty().WithMessage("Görsel Kısmı Boş Geçilemez");
			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen 2 karakterden fazla giriş yapınız");
			RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen 50 karakterden az giriş yapınız");
		}
	}
}

