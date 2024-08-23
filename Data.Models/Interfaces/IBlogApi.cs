namespace Data.Models.Interfaces;

public interface IBlogApi
{
    /// <summary>
    /// Gets the count of blog posts asynchronously.
    /// </summary>
    /// <returns>The task representing the asynchronous operation. The task result contains the count of blog posts.</returns>
    Task<int> GetBlogPostCountAsync();

    /// <summary>
    /// Gets a list of blog posts asynchronously.
    /// </summary>
    /// <param name="numberOfPosts">The number of blog posts to retrieve.</param>
    /// <param name="startIndex">The starting index of the blog posts.</param>
    /// <returns>The task representing the asynchronous operation. The task result contains the list of blog posts.</returns>
    Task<List<BlogPost>> GetBlogPostsAsync(int numberOfPosts, int startIndex);

    /// <summary>
    /// Gets a list of categories asynchronously.
    /// </summary>
    /// <returns>The task representing the asynchronous operation. The task result contains the list of categories.</returns>
    Task<List<Category>> GetCategoriesAsync();

    /// <summary>
    /// Gets a list of tags asynchronously.
    /// </summary>
    /// <returns>The task representing the asynchronous operation. The task result contains the list of tags.</returns>
    Task<List<Tag>> GetTagsAsync();

    /// <summary>
    /// Gets a list of comments for a specific blog post asynchronously.
    /// </summary>
    /// <param name="blogPostId">The ID of the blog post.</param>
    /// <returns>The task representing the asynchronous operation. The task result contains the list of comments.</returns>
    Task<List<Comment>> GetCommentsAsync(string blogPostId);

    /// <summary>
    /// Gets a blog post by its ID asynchronously.
    /// </summary>
    /// <param name="id">The ID of the blog post.</param>
    /// <returns>The task representing the asynchronous operation. The task result contains the blog post.</returns>
    Task<BlogPost?> GetBlogPostAsync(string id);

    /// <summary>
    /// Gets a category by its ID asynchronously.
    /// </summary>
    /// <param name="id">The ID of the category.</param>
    /// <returns>The task representing the asynchronous operation. The task result contains the category.</returns>
    Task<Category?> GetCategoryAsync(string id);

    /// <summary>
    /// Gets a tag by its ID asynchronously.
    /// </summary>
    /// <param name="id">The ID of the tag.</param>
    /// <returns>The task representing the asynchronous operation. The task result contains the tag.</returns>
    Task<Tag?> GetTagAsync(string id);

    /// <summary>
    /// Saves a blog post asynchronously.
    /// </summary>
    /// <param name="item">The blog post to save.</param>
    /// <returns>The task representing the asynchronous operation.</returns>
    Task<BlogPost?> SaveBlogPostAsync(BlogPost item);

    /// <summary>
    /// Saves a category asynchronously.
    /// </summary>
    /// <param name="item">The category to save.</param>
    /// <returns>The task representing the asynchronous operation.</returns>
    Task<Category?> SaveCategoryAsync(Category item);

    /// <summary>
    /// Saves a tag asynchronously.
    /// </summary>
    /// <param name="item">The tag to save.</param>
    /// <returns>The task representing the asynchronous operation.</returns>
    Task<Tag?> SaveTagAsync(Tag item);

    /// <summary>
    /// Saves a comment asynchronously.
    /// </summary>
    /// <param name="item">The comment to save.</param>
    /// <returns>The task representing the asynchronous operation.</returns>
    Task<Comment?> SaveCommentAsync(Comment item);

    /// <summary>
    /// Deletes a blog post by its ID asynchronously.
    /// </summary>
    /// <param name="id">The ID of the blog post to delete.</param>
    /// <returns>The task representing the asynchronous operation.</returns>
    Task DeleteBlogPostAsync(string id);

    /// <summary>
    /// Deletes a category by its ID asynchronously.
    /// </summary>
    /// <param name="id">The ID of the category to delete.</param>
    /// <returns>The task representing the asynchronous operation.</returns>
    Task DeleteCategoryAsync(string id);

    /// <summary>
    /// Deletes a tag by its ID asynchronously.
    /// </summary>
    /// <param name="id">The ID of the tag to delete.</param>
    /// <returns>The task representing the asynchronous operation.</returns>
    Task DeleteTagAsync(string id);

    /// <summary>
    /// Deletes a comment by its ID asynchronously.
    /// </summary>
    /// <param name="id">The ID of the comment to delete.</param>
    /// <returns>The task representing the asynchronous operation.</returns>
    /// Task DeleteCommentAsync(string id);
}
