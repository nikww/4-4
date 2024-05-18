using System;
using System.Collections.Generic;
using Avalonia44.Models;

namespace Avalonia44.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public List<Blog> BlogContent { get; set; }

    public List<News> NewsContent { get; set; }
    public MainWindowViewModel()
    {
        BlogContent = new List<Blog>
        {
            new Blog
            {
                title = "УРА",

                text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque" +
                " laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est" +
                ", qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit,sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex eacommodi consequatur?" +
                " Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",

                image_path = "moree.jpg",

                tags = new List<string>() { "Tag1", "Tag2", "Tag3", "Tag4" }
            }
        };



        NewsContent = new List<News>
        {
            new News
            {
                text_1 =  "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse...",
                
                text_2 = "FAME EP.1",
                
                pbtime_1 = DateTime.Now.AddHours(-7),

                pbtime_2 = DateTime.Now
            }
        };
            
    }
   
}
