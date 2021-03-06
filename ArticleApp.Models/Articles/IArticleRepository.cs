﻿using Dul.Domain.Common;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ArticleApp.Models
{
    /// <summary>
    /// repository 리파지토리
    /// 
    /// </summary>
    public interface IArticleRepository
    {
        Task<Article> AddArticleAsync(Article article);       //입력
        Task<List<Article>> GetArticlesAsync();               //출력
        Task<Article> GetArticleByIdAsync(int id);            //상세보기 
        Task<Article> EditArticleAsync(Article article);      //수정
        Task DeleteArticleAsync(int i);                       //삭제

        Task<PagingResult<Article>> GetAllAsync(
            int pageIndex, int pageSize);                     //페이징 처리 
    }
}
