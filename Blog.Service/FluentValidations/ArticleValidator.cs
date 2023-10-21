using Blog.Entity.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.FluentValidations
{
    public class ArticleValidator : AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Başlık Boş Geçilemez")
                .NotNull()
                .MinimumLength(3).WithMessage("Minimum 3 karakterden oluşmalı!")
                .MaximumLength(150).WithMessage("Maximum 150 karakterden oluşmalı!")
                .WithName("Başık");


            RuleFor(x => x.Content)
                .NotEmpty().WithMessage("İçerik boş geçilemez!")
                .NotNull()
                .MinimumLength(3).WithMessage("İçerik minimum 3 karakterden oluşmalı!")
                .MaximumLength(500).WithMessage("İçerik maximum 500 karakterden oluşmalı!")
                .WithName("İçerik");
        }
    }
}
