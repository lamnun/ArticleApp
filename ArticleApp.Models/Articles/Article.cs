using Dul.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace ArticleApp.Models
{
    /// <summary>
    /// Article 모델 클래스 : Articles 테이블과 일대일로 매핑
    /// </summary>
    public class Article : AuditableBase
    {
        //일련번호
        public int Id { get; set; }

        //제목
        //[Required]
        public string Title {get; set;}

        //내용
        [Required(ErrorMessage = "내용을 입력하세요")]
        public string Content { get; set; }

        public bool IsPinned { get; set; } = false;

    }
}
