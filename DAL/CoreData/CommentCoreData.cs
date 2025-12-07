using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.CoreData
{
    public class CommentCoreData : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData(
                new Comment
                {
                    CommentID = 1,
                    CommentUserName = "Aylin Məmmədova",
                    CommentUserMail = "aylin@mail.com",
                    CommentUserComment = "Tur çox gözəl təşkil olunmuşdu, təşəkkürlər!",
                    CommentStatus = true,
                    UserId = 1
                },
                new Comment
                {
                    CommentID = 2,
                    CommentUserName = "Elvin Quliyev",
                    CommentUserMail = "elvin@mail.com",
                    CommentUserComment = "Qidalanma zəif idi, amma ümumi xidmət yaxşı idi.",
                    CommentStatus = true,
                    UserId = 2
                },
                new Comment
                {
                    CommentID = 3,
                    CommentUserName = "Nərmin Həsənova",
                    CommentUserMail = "nermin@mail.com",
                    CommentUserComment = "Bələdçi çox məlumatlı idi, turdan çox razı qaldım.",
                    CommentStatus = true,
                    UserId = 3
                },
                new Comment
                {
                    CommentID = 4,
                    CommentUserName = "Murad Əliyev",
                    CommentUserMail = "murad@mail.com",
                    CommentUserComment = "Qiymət-Performans mükəmməldi, yenə gələcəm.",
                    CommentStatus = true,
                    UserId = 4
                }, new Comment {
        CommentID = 5,
        CommentUserName = "Günel Məmmədli",
        CommentUserMail = "gunel@mail.com",
        CommentUserComment = "Çox maraqlı yerləri gəzdik, hər şey super idi.",
        CommentStatus = true,
        UserId = 5
    },
    new Comment {
        CommentID = 6,
        CommentUserName = "Rəşad Əhmədov",
        CommentUserMail = "resad@mail.com",
        CommentUserComment = "Avtobus bir az gec gəldi amma yenə də xoş keçdi.",
        CommentStatus = false,
        UserId = 6
    },
    new Comment {
        CommentID = 7,
        CommentUserName = "Ləman Əliyeva",
        CommentUserMail = "leman@mail.com",
        CommentUserComment = "Foto zonalar möhtəşəm idi, təşəkkürlər!",
        CommentStatus = true,
        UserId = 7
    },
    new Comment {
        CommentID = 8,
        CommentUserName = "Kamran Məlikov",
        CommentUserMail = "kamran@mail.com",
        CommentUserComment = "Tur rəhbəri əla idi, tam peşəkar yanaşma.",
        CommentStatus = true,
        UserId = 8
    },
    new Comment {
        CommentID = 9,
        CommentUserName = "Aysel Hüseyn",
        CommentUserMail = "aysel@mail.com",
        CommentUserComment = "Bir az yorucu idi, amma görməli yerlər gözəl idi.",
        CommentStatus = true,
        UserId = 9
    },
    new Comment {
        CommentID = 10,
        CommentUserName = "Faiq Rzayev",
        CommentUserMail = "faiq@mail.com",
        CommentUserComment = "Bu, iştirak etdiyim ən yaxşı turlardan biri oldu!",
        CommentStatus = true,
        UserId = 10
    }
            );
        }
    }
}