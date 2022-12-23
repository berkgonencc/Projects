﻿using BlogApp.Business.Abstract;
using BlogApp.Data.Abstract;
using BlogApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Concrete
{
    public class PostManager : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostManager(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public Task CreateAsync(Post entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Post entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Post>> GetAll()
        {
            return await _postRepository.GetAll();
        }

        public async Task<Post> GetById(int id)
        {
            return await _postRepository.GetById(id);
        }

        public async Task<List<Post>> GetTrendingPostsAsync()
        {
            return await _postRepository.GetTrendingPostsAsync();
        }

        public Task UpdateAsync(Post entity)
        {
            throw new NotImplementedException();
        }
    }
}
